using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zag_pos
{
    public partial class Zagadnienie_posrednika : Form
    {
        public static int rowCount;
        public static int columnCount;
        public static int m;
        public static int n;
        public static int dataCounter = 0;
        public TextBox[] txtbox = new TextBox[500];
        public Label[] ll = new Label[500];
        public static int[] dataArr;

        public Zagadnienie_posrednika()
        {
            InitializeComponent();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(liczba_dostawcow.Text)) && !(String.IsNullOrEmpty(liczba_odbiorcow.Text)) && (liczba_dostawcow!= null) && (liczba_odbiorcow!= null) && (Char.IsNumber(liczba_odbiorcow.Text, 0)) && (Char.IsNumber(liczba_dostawcow.Text, 0)))
            {
                dataCounter = 0;
                m = Int32.Parse(liczba_dostawcow.Text);
                n = Int32.Parse(liczba_odbiorcow.Text);
                columnCount = n + 2;
                rowCount = m + 3;

                GenerateTable(columnCount, rowCount);
                zatwierdz.Visible = true;

                Size = new Size(tableLayoutPanel1.Width,500);
                CenterToScreen();

            }


            else 

            {
                MessageBox.Show("Nieprawidłowe dane! Spróbuj jeszcze raz", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateTable(int columnCount, int rowCount)
        {
            //Wyczyść istniejące kontrolki, generujemy nowy układ tabeli
            tableLayoutPanel1.Controls.Clear();

            //Wyczyść istniejący styl wiersza i kolumny s
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            //Teraz wygenerujemy tabelę, ustawiając liczbę wierszy i kolumn pierwsza
            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;

            for (int x = 0; x < columnCount; x++)
            {
                //Najpierw dodaj kolumnę
                tableLayoutPanel1.Font = new Font(FontFamily.GenericSansSerif, 7.5F, FontStyle.Regular);
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    //Następnie dodaj wiersz. Zrób to tylko raz, podczas tworzenia pierwszej kolumny
                    if (x == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    if (x == 0 && y == 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "Podaż";
                        tableLayoutPanel1.Controls.Add(lbl, x, y);
                    }
                    else if (x == 0 && y == 1)
                    {
                        Label lbl = new Label();
                        lbl.Text = "dostawcow";
                        tableLayoutPanel1.Controls.Add(lbl, x, y);
                    }
                    else if (x == columnCount / 2 && y == 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "Popyt odbiorców";
                        tableLayoutPanel1.Controls.Add(lbl, x, y);
                    }
                    else if (x == columnCount - 1 && y == 1)
                    {
                        Label lbl = new Label();
                        lbl.Text = "Cena zakupu";
                        tableLayoutPanel1.Controls.Add(lbl, x, y);

                    }
                    else if (x == 0 && y == rowCount - 1)
                    {
                        Label lbl = new Label();
                        lbl.Text = "Cena sprzedaży";
                        tableLayoutPanel1.Controls.Add(lbl, x, y);

                    }
                    else if (x == columnCount - 1 && y == rowCount - 1)
                    {

                    }
                    else if (y > 0)
                    {
                        txtbox[dataCounter] = new TextBox();
                        tableLayoutPanel1.Controls.Add(txtbox[dataCounter], x, y);
                        if (m == 2 && n == 3)
                        {
                            int[] tt = new int[] {20, 30, 10, 8, 12, 30, 28, 14, 9, 25, 27, 17, 19, 30, 10, 12};

                            txtbox[dataCounter].Text = tt[dataCounter].ToString();
                            dataCounter++;
                        }

                        else if (m == 2 && n == 2)
                        {
                            int[] tt = new int[] {30, 20, 25, 6, 2, 11, 35, 4, 5, 13, 6, 7};

                            txtbox[dataCounter].Text = tt[dataCounter].ToString();
                            dataCounter++;
                        }

                        else
                        {
                            dataCounter++;
                        }
                    }
                    
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if(wprowadzDane())
                start();
            else
            {
                MessageBox.Show("Nieprawidłowe dane! Spróbuj jeszcze raz", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void start()
        {
            Calculations cal = new Calculations();
            cal.calculator(n, m);
            cal.calculate();
            cal.zyskCalkowity();
            cal.funkcja();
            cal.alphaBeta();
            alp(Calculations.alpha);
            bet(Calculations.beta);
            cal.zmienneKryterialne();
            cal.kosztIprzychodCalkowity();
            list(Calculations.kC, Calculations.pC);

            macierzZyskowJednostkowych();

            zyskiJednostkoweLabel.Visible = true;
            optymalnePrzewozyLabel.Visible = true;

            Size = new Size(1300, 755);
            CenterToScreen();
        }

        private bool wprowadzDane()
        {
            dataArr = new int[dataCounter];

            for (int i = 0; i < dataCounter; i++)
            {
                if (String.IsNullOrEmpty(txtbox[i].Text) || (txtbox[i] == null) || !Char.IsNumber(txtbox[i].Text, 0) || Int32.Parse(txtbox[i].Text) <= 0)
                    return false;

                dataArr[i] = Int32.Parse(txtbox[i].Text);

            }

            return true;
        }

        private void macierzZyskowJednostkowych()
        {
            int column = n+1, row = m + 1;
            int licznik=0;

            macierz_zyskow_jedn.Controls.Clear();
            macierz_zyskow_jedn.ColumnStyles.Clear();
            macierz_zyskow_jedn.RowStyles.Clear();

            macierz_zyskow_jedn.ColumnCount = column;
            macierz_zyskow_jedn.RowCount = row;

            for (int x = 0; x < column; x++)
            {
                macierz_zyskow_jedn.Font = new Font(FontFamily.GenericSansSerif, 7.5F, FontStyle.Regular);
                macierz_zyskow_jedn.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < row; y++)
                {
                    if (x == 0)
                    {
                        macierz_zyskow_jedn.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    if (x == 0 && y > 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "D_" + y;
                        macierz_zyskow_jedn.Controls.Add(lbl, x, y);
                    }

                    else if (y==0 && x > 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "O_" + x;
                        macierz_zyskow_jedn.Controls.Add(lbl, x, y);
                    }

                    else if (y > 0)
                    {
                        //string ttt = Calculations.zC[x - 1][y - 1].ToString();
                        ll[licznik]  = new Label();
                        macierz_zyskow_jedn.Controls.Add(ll[licznik], x, y);
                        ll[licznik].Text = Calculations.zC[y - 1][x - 1].ToString();
                        licznik++;
                    }


                }

            }
        }

        private void optymalnePrzewozy()
        {
            int column = n + 1, row = m + 1;
            int licznik = 0;

            optymalne_przewozy.Controls.Clear();
            optymalne_przewozy.ColumnStyles.Clear();
            optymalne_przewozy.RowStyles.Clear();

            optymalne_przewozy.ColumnCount = column;
            optymalne_przewozy.RowCount = row;

            for (int x = 0; x < column; x++)
            {
                optymalne_przewozy.Font = new Font(FontFamily.GenericSansSerif, 7.5F, FontStyle.Regular);
                optymalne_przewozy.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < row; y++)
                {
                    if (x == 0)
                    {
                        optymalne_przewozy.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    if (x == 0 && y > 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "D_" + y;
                        optymalne_przewozy.Controls.Add(lbl, x, y);
                    }

                    else if (y == 0 && x > 0)
                    {
                        Label lbl = new Label();
                        lbl.Text = "O_" + x;
                        optymalne_przewozy.Controls.Add(lbl, x, y);
                    }

                    else if (y > 0)
                    {
                        //string ttt = Calculations.zC[x - 1][y - 1].ToString();
                        ll[licznik] = new Label();
                        optymalne_przewozy.Controls.Add(ll[licznik], x, y);
                        ll[licznik].Text = Calculations.zC[y - 1][x - 1].ToString();
                        licznik++;
                    }
                  
                }

            }
        }

        public void alp(int []a)
        {
            string aa = "";
            for (int i=0; i<a.Length; i++)
            {
                if (i == (a.Length - 1))
                    aa += "alpha F = " + a[i] + "\n";
                else
                    aa += "alpha " + (i+1) + " = " + a[i] + "\n";
            }

            alpha1.Text = aa;
            alpha1.Visible = true;

        }

        public void bet(int[] b)
        {
            string bb="";
            for (int i = 0; i < b.Length; i++)
            {
                if (i == (b.Length-1))
                    bb += "beta F = " + b[i] + "\n";
                else
                    bb += "beta " + (i+1) + " = " + b[i] + "\n";
            }

            beta1.Text = bb;
            beta1.Visible = true;

        }

        public void list(int kC, int pC)
        {
            koszt_c_label.Text = koszt_c_label.Text + kC.ToString();
            przychod_c_label.Text = przychod_c_label.Text + pC.ToString();

            koszt_c_label.Visible = true;
            przychod_c_label.Visible = true;
            zysk_p_label.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void alpha_0_Click(object sender, EventArgs e)
        {

        }

        private void beta1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void koszt_c_label_Click(object sender, EventArgs e)
        {

        }
    }
}

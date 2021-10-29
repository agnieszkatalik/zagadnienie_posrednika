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
    public partial class Form1 : Form
    {
        public static int rowCount;
        public static int columnCount;
        public static int m;
        public static int n;
        public static int dataCounter = 0;
        public TextBox[] txtbox = new TextBox[500];
        public static int[] dataArr;

        public Form1()
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

            if (Char.IsNumber(liczba_odbiorcow.Text, 0) && Char.IsNumber(liczba_dostawcow.Text, 0))
            {
                dataCounter = 0;
                m = Int32.Parse(liczba_dostawcow.Text);
                n = Int32.Parse(liczba_odbiorcow.Text);
                columnCount = n + 2;
                rowCount = m + 3;

                GenerateTable(columnCount, rowCount);
                zatwierdz.Visible = true;
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
                tableLayoutPanel1.Font = new Font(FontFamily.GenericSansSerif, 7.5F, FontStyle.Bold);
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
                        txtbox[dataCounter].Text = (dataCounter).ToString();
                        dataCounter++;
                    }

                }

            }

            dataCounter--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void zatwierdz_Click(object sender, EventArgs e)
        {
            dataArr = new int [dataCounter];

            for (int i = 0; i < dataCounter; i++)
            {
                dataArr[i] = Int32.Parse(txtbox[i].Text);
            }
                
            Calculations cal = new Calculations();
            cal.calculator(n,m);
            int huukhkuh = cal.m;
            cal.calculate();
            cal.zyskCalkowity();
            cal.funkcja();
            alp(Calculations.alpha);
            bet(Calculations.beta);

            jednostkoweKosztyTransportu();


        }

        private void jednostkoweKosztyTransportu()
        {
            int column = m+1, row = n + 1;
            int licznik;

            macierz_zyskow_jedn.Controls.Clear();
            macierz_zyskow_jedn.ColumnStyles.Clear();
            macierz_zyskow_jedn.RowStyles.Clear();

            macierz_zyskow_jedn.ColumnCount = column;
            macierz_zyskow_jedn.RowCount = row;

            for (int x = 0; x < column; x++)
            {
                macierz_zyskow_jedn.Font = new Font(FontFamily.GenericSansSerif, 7.5F, FontStyle.Bold);
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
                        /* Label lbl = new Label();
                        lbl.Text = 
                        macierz_zyskow_jedn.Controls.Add(lbl[licznik], x, y);
                        licznikr++;*/
                    }

                }

            }
        }

        public void alp(int []a)
        {
            string aa = "";
            for (int i=0; i<a.Length; i++)
            {
                aa += "alpha " + i + " = " + a[i] + "\n";
            }

            alpha1.Text = aa;
            alpha1.Visible = true;

        }

        public void bet(int[] b)
        {
            string bb="";
            for (int i = 0; i < b.Length; i++)
            {
                bb += "beta " + i + " = " + b[i] + "\n";
            }

            beta1.Text = bb;
            beta1.Visible = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = n.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = m.ToString();
        }

        private void alpha_0_Click(object sender, EventArgs e)
        {

        }

        private void beta1_Click(object sender, EventArgs e)
        {

        }
    }
}


namespace zag_pos
{
    partial class Zagadnienie_posrednika
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.podaj_odb_label = new System.Windows.Forms.Label();
            this.podaj_d_label = new System.Windows.Forms.Label();
            this.liczba_odbiorcow = new System.Windows.Forms.TextBox();
            this.liczba_dostawcow = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.zmienne_kryterialne = new System.Windows.Forms.TableLayoutPanel();
            this.macierz_zyskow_jedn = new System.Windows.Forms.TableLayoutPanel();
            this.beta1 = new System.Windows.Forms.Label();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.alpha1 = new System.Windows.Forms.Label();
            this.zyskiJednostkoweLabel = new System.Windows.Forms.Label();
            this.optymalnePrzewozyLabel = new System.Windows.Forms.Label();
            this.koszt_c_label = new System.Windows.Forms.Label();
            this.przychod_c_label = new System.Windows.Forms.Label();
            this.zysk_p_label = new System.Windows.Forms.Label();
            this.zmienneKryterialneLabel = new System.Windows.Forms.Label();
            this.optymalne_przewozy = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 252);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 177);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // podaj_odb_label
            // 
            this.podaj_odb_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.podaj_odb_label.AutoSize = true;
            this.podaj_odb_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.podaj_odb_label.Location = new System.Drawing.Point(39, 29);
            this.podaj_odb_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.podaj_odb_label.Name = "podaj_odb_label";
            this.podaj_odb_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.podaj_odb_label.Size = new System.Drawing.Size(144, 16);
            this.podaj_odb_label.TabIndex = 3;
            this.podaj_odb_label.Text = "Podaj liczbę odbiorców:";
            this.podaj_odb_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // podaj_d_label
            // 
            this.podaj_d_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.podaj_d_label.AutoSize = true;
            this.podaj_d_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.podaj_d_label.Location = new System.Drawing.Point(39, 62);
            this.podaj_d_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.podaj_d_label.Name = "podaj_d_label";
            this.podaj_d_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.podaj_d_label.Size = new System.Drawing.Size(150, 16);
            this.podaj_d_label.TabIndex = 4;
            this.podaj_d_label.Text = "Podaj liczbę dostawców:";
            this.podaj_d_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // liczba_odbiorcow
            // 
            this.liczba_odbiorcow.Location = new System.Drawing.Point(237, 23);
            this.liczba_odbiorcow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liczba_odbiorcow.Name = "liczba_odbiorcow";
            this.liczba_odbiorcow.Size = new System.Drawing.Size(48, 23);
            this.liczba_odbiorcow.TabIndex = 0;
            // 
            // liczba_dostawcow
            // 
            this.liczba_dostawcow.Location = new System.Drawing.Point(237, 59);
            this.liczba_dostawcow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.liczba_dostawcow.Name = "liczba_dostawcow";
            this.liczba_dostawcow.Size = new System.Drawing.Size(48, 23);
            this.liczba_dostawcow.TabIndex = 1;
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ok.Location = new System.Drawing.Point(131, 100);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 28);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // zmienne_kryterialne
            // 
            this.zmienne_kryterialne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zmienne_kryterialne.AutoScroll = true;
            this.zmienne_kryterialne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.zmienne_kryterialne.ColumnCount = 2;
            this.zmienne_kryterialne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.zmienne_kryterialne.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.zmienne_kryterialne.Location = new System.Drawing.Point(-262, 283);
            this.zmienne_kryterialne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zmienne_kryterialne.Name = "zmienne_kryterialne";
            this.zmienne_kryterialne.RowCount = 2;
            this.zmienne_kryterialne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.zmienne_kryterialne.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.zmienne_kryterialne.Size = new System.Drawing.Size(602, 163);
            this.zmienne_kryterialne.TabIndex = 13;
            this.zmienne_kryterialne.Visible = false;
            // 
            // macierz_zyskow_jedn
            // 
            this.macierz_zyskow_jedn.AutoScroll = true;
            this.macierz_zyskow_jedn.ColumnCount = 2;
            this.macierz_zyskow_jedn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.macierz_zyskow_jedn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.macierz_zyskow_jedn.Location = new System.Drawing.Point(31, 510);
            this.macierz_zyskow_jedn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.macierz_zyskow_jedn.Name = "macierz_zyskow_jedn";
            this.macierz_zyskow_jedn.RowCount = 2;
            this.macierz_zyskow_jedn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.macierz_zyskow_jedn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.macierz_zyskow_jedn.Size = new System.Drawing.Size(602, 181);
            this.macierz_zyskow_jedn.TabIndex = 11;
            // 
            // beta1
            // 
            this.beta1.AutoSize = true;
            this.beta1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beta1.Location = new System.Drawing.Point(1078, 43);
            this.beta1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.beta1.Name = "beta1";
            this.beta1.Size = new System.Drawing.Size(44, 16);
            this.beta1.TabIndex = 16;
            this.beta1.Text = "beta =";
            // 
            // zatwierdz
            // 
            this.zatwierdz.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zatwierdz.Location = new System.Drawing.Point(31, 205);
            this.zatwierdz.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(131, 29);
            this.zatwierdz.TabIndex = 21;
            this.zatwierdz.Text = "Zatwierdź dane";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Visible = false;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // alpha1
            // 
            this.alpha1.AutoSize = true;
            this.alpha1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alpha1.Location = new System.Drawing.Point(917, 43);
            this.alpha1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.alpha1.Name = "alpha1";
            this.alpha1.Size = new System.Drawing.Size(50, 16);
            this.alpha1.TabIndex = 15;
            this.alpha1.Text = "alpha =";
            // 
            // zyskiJednostkoweLabel
            // 
            this.zyskiJednostkoweLabel.AutoSize = true;
            this.zyskiJednostkoweLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zyskiJednostkoweLabel.Location = new System.Drawing.Point(31, 474);
            this.zyskiJednostkoweLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zyskiJednostkoweLabel.Name = "zyskiJednostkoweLabel";
            this.zyskiJednostkoweLabel.Size = new System.Drawing.Size(186, 16);
            this.zyskiJednostkoweLabel.TabIndex = 23;
            this.zyskiJednostkoweLabel.Text = "Tabela zysków jednostkowych:";
            // 
            // optymalnePrzewozyLabel
            // 
            this.optymalnePrzewozyLabel.AutoSize = true;
            this.optymalnePrzewozyLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.optymalnePrzewozyLabel.Location = new System.Drawing.Point(680, 464);
            this.optymalnePrzewozyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optymalnePrzewozyLabel.Name = "optymalnePrzewozyLabel";
            this.optymalnePrzewozyLabel.Size = new System.Drawing.Size(194, 16);
            this.optymalnePrzewozyLabel.TabIndex = 24;
            this.optymalnePrzewozyLabel.Text = "Tabela optymalnych przewozów:";
            // 
            // koszt_c_label
            // 
            this.koszt_c_label.AutoSize = true;
            this.koszt_c_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.koszt_c_label.Location = new System.Drawing.Point(671, 43);
            this.koszt_c_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.koszt_c_label.Name = "koszt_c_label";
            this.koszt_c_label.Size = new System.Drawing.Size(107, 16);
            this.koszt_c_label.TabIndex = 25;
            this.koszt_c_label.Text = "Koszt całkowity: ";
            // 
            // przychod_c_label
            // 
            this.przychod_c_label.AutoSize = true;
            this.przychod_c_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.przychod_c_label.Location = new System.Drawing.Point(671, 76);
            this.przychod_c_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.przychod_c_label.Name = "przychod_c_label";
            this.przychod_c_label.Size = new System.Drawing.Size(128, 16);
            this.przychod_c_label.TabIndex = 26;
            this.przychod_c_label.Text = "Przychód całkowity: ";
            // 
            // zysk_p_label
            // 
            this.zysk_p_label.AutoSize = true;
            this.zysk_p_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zysk_p_label.Location = new System.Drawing.Point(671, 111);
            this.zysk_p_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.zysk_p_label.Name = "zysk_p_label";
            this.zysk_p_label.Size = new System.Drawing.Size(110, 16);
            this.zysk_p_label.TabIndex = 27;
            this.zysk_p_label.Text = "Zysk pośrednika: ";
            // 
            // zmienneKryterialneLabel
            // 
            this.zmienneKryterialneLabel.AutoSize = true;
            this.zmienneKryterialneLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zmienneKryterialneLabel.Location = new System.Drawing.Point(671, 241);
            this.zmienneKryterialneLabel.Name = "zmienneKryterialneLabel";
            this.zmienneKryterialneLabel.Size = new System.Drawing.Size(323, 16);
            this.zmienneKryterialneLabel.TabIndex = 28;
            this.zmienneKryterialneLabel.Text = "Tabela poglądowa końcowych zmiennych kryterialnych";
            // 
            // optymalne_przewozy
            // 
            this.optymalne_przewozy.ColumnCount = 2;
            this.optymalne_przewozy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optymalne_przewozy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optymalne_przewozy.Location = new System.Drawing.Point(681, 510);
            this.optymalne_przewozy.Name = "optymalne_przewozy";
            this.optymalne_przewozy.RowCount = 2;
            this.optymalne_przewozy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optymalne_przewozy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optymalne_przewozy.Size = new System.Drawing.Size(602, 181);
            this.optymalne_przewozy.TabIndex = 29;
            // 
            // Zagadnienie_posrednika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 156);
            this.Controls.Add(this.optymalne_przewozy);
            this.Controls.Add(this.zmienneKryterialneLabel);
            this.Controls.Add(this.zysk_p_label);
            this.Controls.Add(this.przychod_c_label);
            this.Controls.Add(this.koszt_c_label);
            this.Controls.Add(this.optymalnePrzewozyLabel);
            this.Controls.Add(this.zyskiJednostkoweLabel);
            this.Controls.Add(this.beta1);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.alpha1);
            this.Controls.Add(this.macierz_zyskow_jedn);
            this.Controls.Add(this.zmienne_kryterialne);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.liczba_dostawcow);
            this.Controls.Add(this.liczba_odbiorcow);
            this.Controls.Add(this.podaj_d_label);
            this.Controls.Add(this.podaj_odb_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Zagadnienie_posrednika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zagadnienie posrednika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label podaj_odb_label;
        private System.Windows.Forms.Label podaj_d_label;
        private System.Windows.Forms.TextBox liczba_odbiorcow;
        private System.Windows.Forms.TextBox liczba_dostawcow;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TableLayoutPanel zmienne_kryterialne;
        private System.Windows.Forms.TableLayoutPanel macierz_zyskow_jedn;
        private System.Windows.Forms.Button zatwierdz;
        private System.Windows.Forms.Label beta1;
        private System.Windows.Forms.Label alpha1;
        private System.Windows.Forms.Label zyskiJednostkoweLabel;
        private System.Windows.Forms.Label optymalnePrzewozyLabel;
        private System.Windows.Forms.Label koszt_c_label;
        private System.Windows.Forms.Label przychod_c_label;
        private System.Windows.Forms.Label zysk_p_label;
        private System.Windows.Forms.Label zmienneKryterialneLabel;
        private System.Windows.Forms.TableLayoutPanel optymalne_przewozy;
    }
}


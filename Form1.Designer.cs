
namespace zag_pos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.liczba_odbiorcow = new System.Windows.Forms.TextBox();
            this.liczba_dostawcow = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.alpha_0 = new System.Windows.Forms.Label();
            this.alpha_1 = new System.Windows.Forms.Label();
            this.alpha_2 = new System.Windows.Forms.Label();
            this.a0 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.zatwierdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 238);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 313);
            this.tableLayoutPanel1.TabIndex = 5;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podaj liczbę odbiorców:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj liczbę dostawców:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // liczba_odbiorcow
            // 
            this.liczba_odbiorcow.Location = new System.Drawing.Point(183, 22);
            this.liczba_odbiorcow.Name = "liczba_odbiorcow";
            this.liczba_odbiorcow.Size = new System.Drawing.Size(48, 23);
            this.liczba_odbiorcow.TabIndex = 0;
            this.liczba_odbiorcow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // liczba_dostawcow
            // 
            this.liczba_dostawcow.Location = new System.Drawing.Point(183, 55);
            this.liczba_dostawcow.Name = "liczba_dostawcow";
            this.liczba_dostawcow.Size = new System.Drawing.Size(48, 23);
            this.liczba_dostawcow.TabIndex = 1;
            this.liczba_dostawcow.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ok.Location = new System.Drawing.Point(156, 96);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(22, 781);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(533, 194);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(22, 569);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(533, 194);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(584, 569);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(533, 194);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(581, 781);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(536, 194);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // alpha_0
            // 
            this.alpha_0.AutoSize = true;
            this.alpha_0.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alpha_0.Location = new System.Drawing.Point(22, 1005);
            this.alpha_0.Name = "alpha_0";
            this.alpha_0.Size = new System.Drawing.Size(73, 20);
            this.alpha_0.TabIndex = 15;
            this.alpha_0.Text = "alpha 0 =";
            this.alpha_0.Visible = false;
            // 
            // alpha_1
            // 
            this.alpha_1.AutoSize = true;
            this.alpha_1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alpha_1.Location = new System.Drawing.Point(22, 1037);
            this.alpha_1.Name = "alpha_1";
            this.alpha_1.Size = new System.Drawing.Size(71, 20);
            this.alpha_1.TabIndex = 16;
            this.alpha_1.Text = "alpha 1 =";
            this.alpha_1.Visible = false;
            // 
            // alpha_2
            // 
            this.alpha_2.AutoSize = true;
            this.alpha_2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alpha_2.Location = new System.Drawing.Point(22, 1069);
            this.alpha_2.Name = "alpha_2";
            this.alpha_2.Size = new System.Drawing.Size(73, 20);
            this.alpha_2.TabIndex = 17;
            this.alpha_2.Text = "alpha 2 =";
            this.alpha_2.Visible = false;
            // 
            // a0
            // 
            this.a0.AutoSize = true;
            this.a0.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a0.Location = new System.Drawing.Point(92, 1005);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(17, 20);
            this.a0.TabIndex = 18;
            this.a0.Text = "0";
            this.a0.Visible = false;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(92, 1037);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(17, 20);
            this.a1.TabIndex = 19;
            this.a1.Text = "0";
            this.a1.Visible = false;
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.Location = new System.Drawing.Point(92, 1069);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(17, 20);
            this.a2.TabIndex = 20;
            this.a2.Text = "0";
            this.a2.Visible = false;
            // 
            // zatwierdz
            // 
            this.zatwierdz.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zatwierdz.Location = new System.Drawing.Point(22, 171);
            this.zatwierdz.Name = "zatwierdz";
            this.zatwierdz.Size = new System.Drawing.Size(131, 44);
            this.zatwierdz.TabIndex = 21;
            this.zatwierdz.Text = "ZATWIERDŹ DANE";
            this.zatwierdz.UseVisualStyleBackColor = true;
            this.zatwierdz.Visible = false;
            this.zatwierdz.Click += new System.EventHandler(this.zatwierdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 1121);
            this.Controls.Add(this.zatwierdz);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a0);
            this.Controls.Add(this.alpha_2);
            this.Controls.Add(this.alpha_1);
            this.Controls.Add(this.alpha_0);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.liczba_dostawcow);
            this.Controls.Add(this.liczba_odbiorcow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox liczba_odbiorcow;
        private System.Windows.Forms.TextBox liczba_dostawcow;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label alpha_0;
        private System.Windows.Forms.Label alpha_1;
        private System.Windows.Forms.Label alpha_2;
        private System.Windows.Forms.Label a0;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Button zatwierdz;
    }
}


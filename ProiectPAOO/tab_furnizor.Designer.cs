﻿
namespace ProiectPAOO
{
    partial class tab_furnizor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.imp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textcaut = new System.Windows.Forms.TextBox();
            this.caut = new System.Windows.Forms.Button();
            this.filtru = new System.Windows.Forms.TextBox();
            this.clr = new System.Windows.Forms.Button();
            this.sterg = new System.Windows.Forms.Button();
            this.modif = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.codc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cod = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Tan;
            this.back.ForeColor = System.Drawing.Color.Black;
            this.back.Location = new System.Drawing.Point(700, 326);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(88, 23);
            this.back.TabIndex = 61;
            this.back.Text = "Back to Login";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.DarkOrchid;
            this.exp.ForeColor = System.Drawing.Color.Aqua;
            this.exp.Location = new System.Drawing.Point(111, 239);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 60;
            this.exp.Text = "Export";
            this.exp.UseVisualStyleBackColor = false;
            this.exp.Click += new System.EventHandler(this.exp_Click);
            // 
            // imp
            // 
            this.imp.BackColor = System.Drawing.Color.DarkOrchid;
            this.imp.ForeColor = System.Drawing.Color.Aqua;
            this.imp.Location = new System.Drawing.Point(30, 239);
            this.imp.Name = "imp";
            this.imp.Size = new System.Drawing.Size(75, 23);
            this.imp.TabIndex = 59;
            this.imp.Text = "Import";
            this.imp.UseVisualStyleBackColor = false;
            this.imp.Click += new System.EventHandler(this.imp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Filtru:";
            // 
            // textcaut
            // 
            this.textcaut.Location = new System.Drawing.Point(93, 213);
            this.textcaut.Name = "textcaut";
            this.textcaut.Size = new System.Drawing.Size(118, 20);
            this.textcaut.TabIndex = 57;
            // 
            // caut
            // 
            this.caut.Location = new System.Drawing.Point(12, 211);
            this.caut.Name = "caut";
            this.caut.Size = new System.Drawing.Size(75, 23);
            this.caut.TabIndex = 56;
            this.caut.Text = "Cautare";
            this.caut.UseVisualStyleBackColor = true;
            this.caut.Click += new System.EventHandler(this.caut_Click);
            // 
            // filtru
            // 
            this.filtru.Location = new System.Drawing.Point(264, 290);
            this.filtru.Name = "filtru";
            this.filtru.Size = new System.Drawing.Size(203, 20);
            this.filtru.TabIndex = 55;
            this.filtru.TextChanged += new System.EventHandler(this.filtru_TextChanged);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.Color.White;
            this.clr.Location = new System.Drawing.Point(111, 182);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 23);
            this.clr.TabIndex = 54;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.clr_Click);
            // 
            // sterg
            // 
            this.sterg.BackColor = System.Drawing.Color.Red;
            this.sterg.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sterg.Location = new System.Drawing.Point(111, 153);
            this.sterg.Name = "sterg";
            this.sterg.Size = new System.Drawing.Size(75, 23);
            this.sterg.TabIndex = 53;
            this.sterg.Text = "Stergere";
            this.sterg.UseVisualStyleBackColor = false;
            this.sterg.Click += new System.EventHandler(this.sterg_Click);
            // 
            // modif
            // 
            this.modif.BackColor = System.Drawing.Color.LightSalmon;
            this.modif.Location = new System.Drawing.Point(30, 182);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(75, 23);
            this.modif.TabIndex = 52;
            this.modif.Text = "Modificare";
            this.modif.UseVisualStyleBackColor = false;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(559, 269);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Lime;
            this.add.Location = new System.Drawing.Point(30, 153);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 50;
            this.add.Text = "Adaugare";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // codc
            // 
            this.codc.Location = new System.Drawing.Point(111, 115);
            this.codc.Name = "codc";
            this.codc.Size = new System.Drawing.Size(100, 20);
            this.codc.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cod Client:";
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(111, 91);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 20);
            this.telefon.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Telefon:";
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(111, 64);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(100, 20);
            this.adresa.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Adresa:";
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(111, 38);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nume:";
            // 
            // cod
            // 
            this.cod.Location = new System.Drawing.Point(111, 12);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(100, 20);
            this.cod.TabIndex = 33;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cod Furnizor:";
            // 
            // tab_furnizor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.imp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textcaut);
            this.Controls.Add(this.caut);
            this.Controls.Add(this.filtru);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.sterg);
            this.Controls.Add(this.modif);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.codc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.label1);
            this.Name = "tab_furnizor";
            this.Text = "furnizor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button imp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textcaut;
        private System.Windows.Forms.Button caut;
        private System.Windows.Forms.TextBox filtru;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button sterg;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox codc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cod;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
    }
}
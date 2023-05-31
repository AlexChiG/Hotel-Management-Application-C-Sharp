
namespace ProiectPAOO
{
    partial class Meniu
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
            this.label1 = new System.Windows.Forms.Label();
            this.ang = new System.Windows.Forms.Button();
            this.cli = new System.Windows.Forms.Button();
            this.fur = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.Button();
            this.cam = new System.Windows.Forms.Button();
            this.dep = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alege o tabela:";
            // 
            // ang
            // 
            this.ang.Location = new System.Drawing.Point(69, 65);
            this.ang.Name = "ang";
            this.ang.Size = new System.Drawing.Size(85, 23);
            this.ang.TabIndex = 1;
            this.ang.Text = "Angajat";
            this.ang.UseVisualStyleBackColor = true;
            this.ang.Click += new System.EventHandler(this.ang_Click);
            // 
            // cli
            // 
            this.cli.Location = new System.Drawing.Point(69, 94);
            this.cli.Name = "cli";
            this.cli.Size = new System.Drawing.Size(86, 23);
            this.cli.TabIndex = 2;
            this.cli.Text = "Client";
            this.cli.UseVisualStyleBackColor = true;
            this.cli.Click += new System.EventHandler(this.cli_Click);
            // 
            // fur
            // 
            this.fur.Location = new System.Drawing.Point(69, 123);
            this.fur.Name = "fur";
            this.fur.Size = new System.Drawing.Size(86, 23);
            this.fur.TabIndex = 3;
            this.fur.Text = "Furnizor";
            this.fur.UseVisualStyleBackColor = true;
            this.fur.Click += new System.EventHandler(this.fur_Click);
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(160, 123);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(85, 23);
            this.rez.TabIndex = 6;
            this.rez.Text = "Rezervare";
            this.rez.UseVisualStyleBackColor = true;
            this.rez.Click += new System.EventHandler(this.rez_Click);
            // 
            // cam
            // 
            this.cam.Location = new System.Drawing.Point(160, 94);
            this.cam.Name = "cam";
            this.cam.Size = new System.Drawing.Size(85, 23);
            this.cam.TabIndex = 5;
            this.cam.Text = "Camera";
            this.cam.UseVisualStyleBackColor = true;
            this.cam.Click += new System.EventHandler(this.cam_Click);
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(160, 65);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(85, 23);
            this.dep.TabIndex = 4;
            this.dep.Text = "Departament";
            this.dep.UseVisualStyleBackColor = true;
            this.dep.Click += new System.EventHandler(this.dep_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(114, 152);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back to Login";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(315, 242);
            this.Controls.Add(this.back);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.cam);
            this.Controls.Add(this.dep);
            this.Controls.Add(this.fur);
            this.Controls.Add(this.cli);
            this.Controls.Add(this.ang);
            this.Controls.Add(this.label1);
            this.Name = "Meniu";
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ang;
        private System.Windows.Forms.Button cli;
        private System.Windows.Forms.Button fur;
        private System.Windows.Forms.Button rez;
        private System.Windows.Forms.Button cam;
        private System.Windows.Forms.Button dep;
        private System.Windows.Forms.Button back;
    }
}
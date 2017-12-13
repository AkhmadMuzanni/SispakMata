namespace ProjectSistemPakar
{
    partial class Hasil
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
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtKesimpulan = new System.Windows.Forms.TextBox();
            this.txtGejala = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 426);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 13;
            this.btnKembali.Text = "BACK";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // txtKesimpulan
            // 
            this.txtKesimpulan.Location = new System.Drawing.Point(12, 193);
            this.txtKesimpulan.Multiline = true;
            this.txtKesimpulan.Name = "txtKesimpulan";
            this.txtKesimpulan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKesimpulan.Size = new System.Drawing.Size(460, 227);
            this.txtKesimpulan.TabIndex = 10;
            this.txtKesimpulan.Text = "Kesimpulan";
            // 
            // txtGejala
            // 
            this.txtGejala.Location = new System.Drawing.Point(12, 72);
            this.txtGejala.Multiline = true;
            this.txtGejala.Name = "txtGejala";
            this.txtGejala.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGejala.Size = new System.Drawing.Size(460, 115);
            this.txtGejala.TabIndex = 9;
            this.txtGejala.Text = "Gejala";
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(397, 426);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 14;
            this.btnKeluar.Text = "KELUAR";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "DIAGNOSIS PENYAKIT MATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "SISTEM PAKAR";
            // 
            // Hasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtKesimpulan);
            this.Controls.Add(this.txtGejala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hasil";
            this.Text = "Hasil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hasil_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembali;
        public System.Windows.Forms.TextBox txtKesimpulan;
        public System.Windows.Forms.TextBox txtGejala;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
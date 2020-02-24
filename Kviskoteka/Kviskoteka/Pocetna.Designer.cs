namespace Kviskoteka
{
    partial class Pocetna
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
            this.kreni_btn = new System.Windows.Forms.Button();
            this.postavke_btn = new System.Windows.Forms.Button();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(189, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli na kvizanje s Morževima!";
            // 
            // kreni_btn
            // 
            this.kreni_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kreni_btn.Location = new System.Drawing.Point(119, 77);
            this.kreni_btn.Name = "kreni_btn";
            this.kreni_btn.Size = new System.Drawing.Size(112, 61);
            this.kreni_btn.TabIndex = 1;
            this.kreni_btn.Text = "Kreni!";
            this.kreni_btn.UseVisualStyleBackColor = true;
            this.kreni_btn.Click += new System.EventHandler(this.kreni_btn_Click);
            // 
            // postavke_btn
            // 
            this.postavke_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.postavke_btn.Location = new System.Drawing.Point(326, 77);
            this.postavke_btn.Name = "postavke_btn";
            this.postavke_btn.Size = new System.Drawing.Size(112, 61);
            this.postavke_btn.TabIndex = 2;
            this.postavke_btn.Text = "Postavke";
            this.postavke_btn.UseVisualStyleBackColor = true;
            this.postavke_btn.Click += new System.EventHandler(this.postavke_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_btn.Location = new System.Drawing.Point(537, 77);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(112, 61);
            this.dodaj_btn.TabIndex = 3;
            this.dodaj_btn.Text = "Dodaj pitanja";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 181);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 244);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.postavke_btn);
            this.Controls.Add(this.kreni_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pocetna";
            this.Text = "Pocetni";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kreni_btn;
        private System.Windows.Forms.Button postavke_btn;
        private System.Windows.Forms.Button dodaj_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


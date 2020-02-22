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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodosli na kvizanje s Morzevima!";
            // 
            // kreni_btn
            // 
            this.kreni_btn.Location = new System.Drawing.Point(16, 43);
            this.kreni_btn.Name = "kreni_btn";
            this.kreni_btn.Size = new System.Drawing.Size(75, 23);
            this.kreni_btn.TabIndex = 1;
            this.kreni_btn.Text = "Kreni!";
            this.kreni_btn.UseVisualStyleBackColor = true;
            // 
            // postavke_btn
            // 
            this.postavke_btn.Location = new System.Drawing.Point(130, 43);
            this.postavke_btn.Name = "postavke_btn";
            this.postavke_btn.Size = new System.Drawing.Size(75, 23);
            this.postavke_btn.TabIndex = 2;
            this.postavke_btn.Text = "Postavke";
            this.postavke_btn.UseVisualStyleBackColor = true;
            this.postavke_btn.Click += new System.EventHandler(this.postavke_btn_Click);
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Location = new System.Drawing.Point(235, 43);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(89, 23);
            this.dodaj_btn.TabIndex = 3;
            this.dodaj_btn.Text = "Dodaj pitanja";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.postavke_btn);
            this.Controls.Add(this.kreni_btn);
            this.Controls.Add(this.label1);
            this.Name = "Pocetna";
            this.Text = "Pocetni";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kreni_btn;
        private System.Windows.Forms.Button postavke_btn;
        private System.Windows.Forms.Button dodaj_btn;
    }
}


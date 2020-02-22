namespace Kviskoteka
{
    partial class DodajZavrsnu
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
            this.pitanje_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pravi_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.krivi1_text = new System.Windows.Forms.TextBox();
            this.krivi2_text = new System.Windows.Forms.TextBox();
            this.krivi3_text = new System.Windows.Forms.TextBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite pitanje:";
            // 
            // pitanje_text
            // 
            this.pitanje_text.Location = new System.Drawing.Point(16, 36);
            this.pitanje_text.Name = "pitanje_text";
            this.pitanje_text.Size = new System.Drawing.Size(457, 20);
            this.pitanje_text.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite točan odgovor:";
            // 
            // pravi_text
            // 
            this.pravi_text.Location = new System.Drawing.Point(16, 105);
            this.pravi_text.Name = "pravi_text";
            this.pravi_text.Size = new System.Drawing.Size(457, 20);
            this.pravi_text.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unesite neka 3 netočna odgovora:";
            // 
            // krivi1_text
            // 
            this.krivi1_text.Location = new System.Drawing.Point(16, 177);
            this.krivi1_text.Name = "krivi1_text";
            this.krivi1_text.Size = new System.Drawing.Size(457, 20);
            this.krivi1_text.TabIndex = 6;
            // 
            // krivi2_text
            // 
            this.krivi2_text.Location = new System.Drawing.Point(16, 204);
            this.krivi2_text.Name = "krivi2_text";
            this.krivi2_text.Size = new System.Drawing.Size(457, 20);
            this.krivi2_text.TabIndex = 7;
            // 
            // krivi3_text
            // 
            this.krivi3_text.Location = new System.Drawing.Point(16, 231);
            this.krivi3_text.Name = "krivi3_text";
            this.krivi3_text.Size = new System.Drawing.Size(457, 20);
            this.krivi3_text.TabIndex = 8;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_btn.Location = new System.Drawing.Point(16, 274);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(457, 31);
            this.dodaj_btn.TabIndex = 9;
            this.dodaj_btn.Text = "Dodaj završnu igru!";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // DodajZavrsnu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.krivi3_text);
            this.Controls.Add(this.krivi2_text);
            this.Controls.Add(this.krivi1_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pravi_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pitanje_text);
            this.Controls.Add(this.label1);
            this.Name = "DodajZavrsnu";
            this.Text = "DodajZavrsnu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitanje_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pravi_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox krivi1_text;
        private System.Windows.Forms.TextBox krivi2_text;
        private System.Windows.Forms.TextBox krivi3_text;
        private System.Windows.Forms.Button dodaj_btn;
    }
}
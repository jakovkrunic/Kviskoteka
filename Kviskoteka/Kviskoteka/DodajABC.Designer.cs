namespace Kviskoteka
{
    partial class DodajABC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prvi_radio = new System.Windows.Forms.RadioButton();
            this.prvi_text = new System.Windows.Forms.TextBox();
            this.drugi_text = new System.Windows.Forms.TextBox();
            this.drugi_radio = new System.Windows.Forms.RadioButton();
            this.treci_radio = new System.Windows.Forms.RadioButton();
            this.treci_text = new System.Windows.Forms.TextBox();
            this.dodaj_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite pitanje:";
            // 
            // pitanje_text
            // 
            this.pitanje_text.Location = new System.Drawing.Point(17, 40);
            this.pitanje_text.Name = "pitanje_text";
            this.pitanje_text.Size = new System.Drawing.Size(457, 20);
            this.pitanje_text.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite 3 moguća odgovora i odaberite koje je točno:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.treci_text);
            this.groupBox1.Controls.Add(this.treci_radio);
            this.groupBox1.Controls.Add(this.drugi_radio);
            this.groupBox1.Controls.Add(this.drugi_text);
            this.groupBox1.Controls.Add(this.prvi_text);
            this.groupBox1.Controls.Add(this.prvi_radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(17, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(457, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odgovori";
            // 
            // prvi_radio
            // 
            this.prvi_radio.AutoSize = true;
            this.prvi_radio.Location = new System.Drawing.Point(6, 33);
            this.prvi_radio.Name = "prvi_radio";
            this.prvi_radio.Size = new System.Drawing.Size(14, 13);
            this.prvi_radio.TabIndex = 0;
            this.prvi_radio.TabStop = true;
            this.prvi_radio.UseVisualStyleBackColor = true;
            // 
            // prvi_text
            // 
            this.prvi_text.Location = new System.Drawing.Point(26, 29);
            this.prvi_text.Name = "prvi_text";
            this.prvi_text.Size = new System.Drawing.Size(422, 21);
            this.prvi_text.TabIndex = 1;
            // 
            // drugi_text
            // 
            this.drugi_text.Location = new System.Drawing.Point(26, 57);
            this.drugi_text.Name = "drugi_text";
            this.drugi_text.Size = new System.Drawing.Size(422, 21);
            this.drugi_text.TabIndex = 2;
            // 
            // drugi_radio
            // 
            this.drugi_radio.AutoSize = true;
            this.drugi_radio.Location = new System.Drawing.Point(6, 61);
            this.drugi_radio.Name = "drugi_radio";
            this.drugi_radio.Size = new System.Drawing.Size(14, 13);
            this.drugi_radio.TabIndex = 3;
            this.drugi_radio.TabStop = true;
            this.drugi_radio.UseVisualStyleBackColor = true;
            // 
            // treci_radio
            // 
            this.treci_radio.AutoSize = true;
            this.treci_radio.Location = new System.Drawing.Point(6, 89);
            this.treci_radio.Name = "treci_radio";
            this.treci_radio.Size = new System.Drawing.Size(14, 13);
            this.treci_radio.TabIndex = 4;
            this.treci_radio.TabStop = true;
            this.treci_radio.UseVisualStyleBackColor = true;
            // 
            // treci_text
            // 
            this.treci_text.Location = new System.Drawing.Point(27, 85);
            this.treci_text.Name = "treci_text";
            this.treci_text.Size = new System.Drawing.Size(421, 21);
            this.treci_text.TabIndex = 5;
            // 
            // dodaj_btn
            // 
            this.dodaj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj_btn.Location = new System.Drawing.Point(17, 258);
            this.dodaj_btn.Name = "dodaj_btn";
            this.dodaj_btn.Size = new System.Drawing.Size(457, 30);
            this.dodaj_btn.TabIndex = 9;
            this.dodaj_btn.Text = "Dodaj ABC pitalicu!";
            this.dodaj_btn.UseVisualStyleBackColor = true;
            this.dodaj_btn.Click += new System.EventHandler(this.dodaj_btn_Click);
            // 
            // DodajABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 297);
            this.Controls.Add(this.dodaj_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pitanje_text);
            this.Controls.Add(this.label1);
            this.Name = "DodajABC";
            this.Text = "DodajABC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitanje_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox drugi_text;
        private System.Windows.Forms.TextBox prvi_text;
        private System.Windows.Forms.RadioButton prvi_radio;
        private System.Windows.Forms.TextBox treci_text;
        private System.Windows.Forms.RadioButton treci_radio;
        private System.Windows.Forms.RadioButton drugi_radio;
        private System.Windows.Forms.Button dodaj_btn;
    }
}
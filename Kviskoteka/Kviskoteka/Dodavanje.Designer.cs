namespace Kviskoteka
{
    partial class Dodavanje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.abc_radio = new System.Windows.Forms.RadioButton();
            this.as_radio = new System.Windows.Forms.RadioButton();
            this.det_radio = new System.Windows.Forms.RadioButton();
            this.zav_radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.zav_radio);
            this.groupBox1.Controls.Add(this.det_radio);
            this.groupBox1.Controls.Add(this.as_radio);
            this.groupBox1.Controls.Add(this.abc_radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 118);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odabir igre";
            // 
            // abc_radio
            // 
            this.abc_radio.AutoSize = true;
            this.abc_radio.Location = new System.Drawing.Point(6, 20);
            this.abc_radio.Name = "abc_radio";
            this.abc_radio.Size = new System.Drawing.Size(102, 19);
            this.abc_radio.TabIndex = 0;
            this.abc_radio.TabStop = true;
            this.abc_radio.Text = "ABC pitalica";
            this.abc_radio.UseVisualStyleBackColor = true;
            // 
            // as_radio
            // 
            this.as_radio.AutoSize = true;
            this.as_radio.Location = new System.Drawing.Point(6, 46);
            this.as_radio.Name = "as_radio";
            this.as_radio.Size = new System.Drawing.Size(123, 19);
            this.as_radio.TabIndex = 1;
            this.as_radio.TabStop = true;
            this.as_radio.Text = "Igra asocijacija";
            this.as_radio.UseVisualStyleBackColor = true;
            // 
            // det_radio
            // 
            this.det_radio.AutoSize = true;
            this.det_radio.Location = new System.Drawing.Point(6, 71);
            this.det_radio.Name = "det_radio";
            this.det_radio.Size = new System.Drawing.Size(112, 19);
            this.det_radio.TabIndex = 2;
            this.det_radio.TabStop = true;
            this.det_radio.Text = "Igra detekcije";
            this.det_radio.UseVisualStyleBackColor = true;
            // 
            // zav_radio
            // 
            this.zav_radio.AutoSize = true;
            this.zav_radio.Location = new System.Drawing.Point(6, 96);
            this.zav_radio.Name = "zav_radio";
            this.zav_radio.Size = new System.Drawing.Size(104, 19);
            this.zav_radio.TabIndex = 3;
            this.zav_radio.TabStop = true;
            this.zav_radio.Text = "Zavrsna igra";
            this.zav_radio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(54, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(138, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Dodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 168);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dodavanje";
            this.Text = "Dodavanje";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton zav_radio;
        internal System.Windows.Forms.RadioButton det_radio;
        internal System.Windows.Forms.RadioButton as_radio;
        internal System.Windows.Forms.RadioButton abc_radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
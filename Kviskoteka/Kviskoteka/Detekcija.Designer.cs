namespace Kviskoteka
{
    partial class Detekcija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detekcija));
            this.naslov = new System.Windows.Forms.Label();
            this.zapocni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trenutniIspitivac = new System.Windows.Forms.Label();
            this.odgovorOsobe = new System.Windows.Forms.Label();
            this.kojuOsobuPita = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.osoba1 = new System.Windows.Forms.Button();
            this.osoba2 = new System.Windows.Forms.Button();
            this.osoba3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.preskoci = new System.Windows.Forms.Button();
            this.glasajPrije = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.naslov.Location = new System.Drawing.Point(32, 21);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(209, 36);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Igra Detekcije";
            // 
            // zapocni
            // 
            this.zapocni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapocni.Location = new System.Drawing.Point(35, 83);
            this.zapocni.Name = "zapocni";
            this.zapocni.Size = new System.Drawing.Size(112, 36);
            this.zapocni.TabIndex = 1;
            this.zapocni.Text = "Započni!";
            this.zapocni.UseVisualStyleBackColor = true;
            this.zapocni.Click += new System.EventHandler(this.zapocni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(356, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 113);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(459, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(490, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(518, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // trenutniIspitivac
            // 
            this.trenutniIspitivac.AutoSize = true;
            this.trenutniIspitivac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trenutniIspitivac.Location = new System.Drawing.Point(36, 223);
            this.trenutniIspitivac.Name = "trenutniIspitivac";
            this.trenutniIspitivac.Size = new System.Drawing.Size(59, 20);
            this.trenutniIspitivac.TabIndex = 7;
            this.trenutniIspitivac.Text = "label6";
            // 
            // odgovorOsobe
            // 
            this.odgovorOsobe.AutoSize = true;
            this.odgovorOsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odgovorOsobe.Location = new System.Drawing.Point(296, 225);
            this.odgovorOsobe.Name = "odgovorOsobe";
            this.odgovorOsobe.Size = new System.Drawing.Size(66, 24);
            this.odgovorOsobe.TabIndex = 8;
            this.odgovorOsobe.Text = "label6";
            // 
            // kojuOsobuPita
            // 
            this.kojuOsobuPita.AutoSize = true;
            this.kojuOsobuPita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kojuOsobuPita.Location = new System.Drawing.Point(178, 224);
            this.kojuOsobuPita.Name = "kojuOsobuPita";
            this.kojuOsobuPita.Size = new System.Drawing.Size(59, 20);
            this.kojuOsobuPita.TabIndex = 9;
            this.kojuOsobuPita.Text = "label7";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(24, 275);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 179);
            this.listBox1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(466, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 123);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(625, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 123);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(788, 279);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 122);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // osoba1
            // 
            this.osoba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osoba1.Location = new System.Drawing.Point(466, 415);
            this.osoba1.Name = "osoba1";
            this.osoba1.Size = new System.Drawing.Size(134, 26);
            this.osoba1.TabIndex = 14;
            this.osoba1.Text = "Osoba A";
            this.osoba1.UseVisualStyleBackColor = true;
            this.osoba1.Click += new System.EventHandler(this.osoba1_Click);
            // 
            // osoba2
            // 
            this.osoba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osoba2.Location = new System.Drawing.Point(627, 418);
            this.osoba2.Name = "osoba2";
            this.osoba2.Size = new System.Drawing.Size(141, 22);
            this.osoba2.TabIndex = 15;
            this.osoba2.Text = "Osoba B";
            this.osoba2.UseVisualStyleBackColor = true;
            this.osoba2.Click += new System.EventHandler(this.osoba2_Click);
            // 
            // osoba3
            // 
            this.osoba3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osoba3.Location = new System.Drawing.Point(792, 415);
            this.osoba3.Name = "osoba3";
            this.osoba3.Size = new System.Drawing.Size(126, 24);
            this.osoba3.TabIndex = 16;
            this.osoba3.Text = "Osoba C";
            this.osoba3.UseVisualStyleBackColor = true;
            this.osoba3.Click += new System.EventHandler(this.osoba3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(450, 452);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(488, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // preskoci
            // 
            this.preskoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.preskoci.Location = new System.Drawing.Point(734, 29);
            this.preskoci.Name = "preskoci";
            this.preskoci.Size = new System.Drawing.Size(185, 38);
            this.preskoci.TabIndex = 18;
            this.preskoci.Text = "Preskoči druge igrače";
            this.preskoci.UseVisualStyleBackColor = true;
            this.preskoci.Click += new System.EventHandler(this.preskoci_Click);
            // 
            // glasajPrije
            // 
            this.glasajPrije.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.glasajPrije.Location = new System.Drawing.Point(734, 88);
            this.glasajPrije.Name = "glasajPrije";
            this.glasajPrije.Size = new System.Drawing.Size(185, 30);
            this.glasajPrije.TabIndex = 19;
            this.glasajPrije.Text = "Glasaj prije isteka vremena";
            this.glasajPrije.UseVisualStyleBackColor = true;
            this.glasajPrije.Click += new System.EventHandler(this.glasajPrije_Click);
            // 
            // Detekcija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 487);
            this.Controls.Add(this.glasajPrije);
            this.Controls.Add(this.preskoci);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.osoba3);
            this.Controls.Add(this.osoba2);
            this.Controls.Add(this.osoba1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kojuOsobuPita);
            this.Controls.Add(this.odgovorOsobe);
            this.Controls.Add(this.trenutniIspitivac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zapocni);
            this.Controls.Add(this.naslov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detekcija";
            this.Text = "Igra Detekcije";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button zapocni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label trenutniIspitivac;
        private System.Windows.Forms.Label odgovorOsobe;
        private System.Windows.Forms.Label kojuOsobuPita;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button osoba1;
        private System.Windows.Forms.Button osoba2;
        private System.Windows.Forms.Button osoba3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button preskoci;
        private System.Windows.Forms.Button glasajPrije;
    }
}
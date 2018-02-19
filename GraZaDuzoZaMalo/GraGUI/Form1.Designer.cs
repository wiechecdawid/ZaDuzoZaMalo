namespace GraGUI
{
    partial class ZaDuzoZaMalo
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
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.labelZacheta = new System.Windows.Forms.Label();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.textBoxOdpowiedz = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCzas = new System.Windows.Forms.Label();
            this.labelLiczProb = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(12, 12);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "Nowa gra";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(12, 48);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(58, 13);
            this.labelZakresOd.TabIndex = 1;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(9, 71);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(58, 13);
            this.labelZakresDo.TabIndex = 2;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(86, 41);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 3;
            this.textBoxZakresOd.Text = "1";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(86, 71);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 4;
            this.textBoxZakresDo.Text = "100";
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(197, 61);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonLosuj.TabIndex = 5;
            this.buttonLosuj.Text = "Losuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            // 
            // labelZacheta
            // 
            this.labelZacheta.AutoSize = true;
            this.labelZacheta.Location = new System.Drawing.Point(12, 116);
            this.labelZacheta.Name = "labelZacheta";
            this.labelZacheta.Size = new System.Drawing.Size(161, 13);
            this.labelZacheta.TabIndex = 6;
            this.labelZacheta.Text = "Liczba wylosowana. Odgadnij ją!";
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(12, 167);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(60, 13);
            this.labelOdpowiedz.TabIndex = 7;
            this.labelOdpowiedz.Text = "Odpowiedź";
            // 
            // textBoxOdpowiedz
            // 
            this.textBoxOdpowiedz.Location = new System.Drawing.Point(12, 144);
            this.textBoxOdpowiedz.Name = "textBoxOdpowiedz";
            this.textBoxOdpowiedz.Size = new System.Drawing.Size(100, 20);
            this.textBoxOdpowiedz.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLiczProb);
            this.panel1.Controls.Add(this.labelCzas);
            this.panel1.Location = new System.Drawing.Point(39, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // labelCzas
            // 
            this.labelCzas.AutoSize = true;
            this.labelCzas.Location = new System.Drawing.Point(13, 16);
            this.labelCzas.Name = "labelCzas";
            this.labelCzas.Size = new System.Drawing.Size(99, 13);
            this.labelCzas.TabIndex = 0;
            this.labelCzas.Text = "Całkowity czas gry:";
            // 
            // labelLiczProb
            // 
            this.labelLiczProb.AutoSize = true;
            this.labelLiczProb.Location = new System.Drawing.Point(13, 50);
            this.labelLiczProb.Name = "labelLiczProb";
            this.labelLiczProb.Size = new System.Drawing.Size(65, 13);
            this.labelLiczProb.TabIndex = 1;
            this.labelLiczProb.Text = "Liczba prób:";
            // 
            // ZaDuzoZaMalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxOdpowiedz);
            this.Controls.Add(this.labelOdpowiedz);
            this.Controls.Add(this.labelZacheta);
            this.Controls.Add(this.buttonLosuj);
            this.Controls.Add(this.textBoxZakresDo);
            this.Controls.Add(this.textBoxZakresOd);
            this.Controls.Add(this.labelZakresDo);
            this.Controls.Add(this.labelZakresOd);
            this.Controls.Add(this.buttonStartStop);
            this.Name = "ZaDuzoZaMalo";
            this.Text = "Gra Za Dużo Za Mało";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.Label labelZacheta;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.TextBox textBoxOdpowiedz;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLiczProb;
        private System.Windows.Forms.Label labelCzas;
    }
}


namespace GraCLI
{
    partial class FormGra
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.buttonPrzerwij = new System.Windows.Forms.Button();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.labelWylosowano = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.panelStatystyki = new System.Windows.Forms.Panel();
            this.labelCzasGry = new System.Windows.Forms.Label();
            this.labelLiczbaRuchow = new System.Windows.Forms.Label();
            this.panelStatystyki.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(12, 12);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(75, 23);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa Gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // buttonPrzerwij
            // 
            this.buttonPrzerwij.Location = new System.Drawing.Point(197, 12);
            this.buttonPrzerwij.Name = "buttonPrzerwij";
            this.buttonPrzerwij.Size = new System.Drawing.Size(75, 23);
            this.buttonPrzerwij.TabIndex = 1;
            this.buttonPrzerwij.Text = "Przerwij";
            this.buttonPrzerwij.UseVisualStyleBackColor = true;
            this.buttonPrzerwij.Click += new System.EventHandler(this.buttonPrzerwij_Click);
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(12, 53);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(61, 13);
            this.labelZakresOd.TabIndex = 2;
            this.labelZakresOd.Text = "Zakres od: ";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(9, 98);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(61, 13);
            this.labelZakresDo.TabIndex = 3;
            this.labelZakresDo.Text = "Zakres do: ";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(79, 50);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresOd.TabIndex = 4;
            this.textBoxZakresOd.Text = "1";
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(76, 95);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxZakresDo.TabIndex = 5;
            this.textBoxZakresDo.Text = "100";
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(197, 71);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(75, 23);
            this.buttonWylosuj.TabIndex = 6;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            // 
            // labelWylosowano
            // 
            this.labelWylosowano.AutoSize = true;
            this.labelWylosowano.Location = new System.Drawing.Point(12, 135);
            this.labelWylosowano.Name = "labelWylosowano";
            this.labelWylosowano.Size = new System.Drawing.Size(164, 13);
            this.labelWylosowano.TabIndex = 7;
            this.labelWylosowano.Text = "Liczba wylosowana. Odgadnij ją: ";
            this.labelWylosowano.Click += new System.EventHandler(this.labelWylosowano_Click);
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(27, 161);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropozycja.TabIndex = 8;
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(146, 159);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(75, 23);
            this.buttonSprawdz.TabIndex = 9;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(24, 218);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(66, 13);
            this.labelOdpowiedz.TabIndex = 10;
            this.labelOdpowiedz.Text = "Odpowiedz: ";
            // 
            // panelStatystyki
            // 
            this.panelStatystyki.Controls.Add(this.labelLiczbaRuchow);
            this.panelStatystyki.Controls.Add(this.labelCzasGry);
            this.panelStatystyki.Location = new System.Drawing.Point(27, 246);
            this.panelStatystyki.Name = "panelStatystyki";
            this.panelStatystyki.Size = new System.Drawing.Size(200, 100);
            this.panelStatystyki.TabIndex = 11;
            // 
            // labelCzasGry
            // 
            this.labelCzasGry.AutoSize = true;
            this.labelCzasGry.Location = new System.Drawing.Point(4, 4);
            this.labelCzasGry.Name = "labelCzasGry";
            this.labelCzasGry.Size = new System.Drawing.Size(102, 13);
            this.labelCzasGry.TabIndex = 0;
            this.labelCzasGry.Text = "Całkowity Czas Gry:";
            // 
            // labelLiczbaRuchow
            // 
            this.labelLiczbaRuchow.AutoSize = true;
            this.labelLiczbaRuchow.Location = new System.Drawing.Point(3, 17);
            this.labelLiczbaRuchow.Name = "labelLiczbaRuchow";
            this.labelLiczbaRuchow.Size = new System.Drawing.Size(135, 13);
            this.labelLiczbaRuchow.TabIndex = 1;
            this.labelLiczbaRuchow.Text = "Całkowita Liczba Ruchów:";
            // 
            // FormGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.panelStatystyki);
            this.Controls.Add(this.labelOdpowiedz);
            this.Controls.Add(this.buttonSprawdz);
            this.Controls.Add(this.textBoxPropozycja);
            this.Controls.Add(this.labelWylosowano);
            this.Controls.Add(this.buttonWylosuj);
            this.Controls.Add(this.textBoxZakresDo);
            this.Controls.Add(this.textBoxZakresOd);
            this.Controls.Add(this.labelZakresDo);
            this.Controls.Add(this.labelZakresOd);
            this.Controls.Add(this.buttonPrzerwij);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "FormGra";
            this.Text = "GraZaDuzoZaMalo";
            this.panelStatystyki.ResumeLayout(false);
            this.panelStatystyki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.Button buttonPrzerwij;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label labelWylosowano;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Panel panelStatystyki;
        private System.Windows.Forms.Label labelLiczbaRuchow;
        private System.Windows.Forms.Label labelCzasGry;
    }
}
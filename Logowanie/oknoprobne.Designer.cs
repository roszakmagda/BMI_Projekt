namespace Logowanie
{
    partial class frmMain
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
            this.bt_Reset = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_wylicz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wiek = new System.Windows.Forms.TextBox();
            this.waga = new System.Windows.Forms.TextBox();
            this.diagnoza = new System.Windows.Forms.TextBox();
            this.wzrost = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.kobieta = new System.Windows.Forms.CheckBox();
            this.mezczyzna = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator BMI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.Location = new System.Drawing.Point(232, 249);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(129, 43);
            this.bt_Reset.TabIndex = 1;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = true;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(416, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Wyjście z programu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_wylicz
            // 
            this.bt_wylicz.Location = new System.Drawing.Point(35, 249);
            this.bt_wylicz.Name = "bt_wylicz";
            this.bt_wylicz.Size = new System.Drawing.Size(132, 43);
            this.bt_wylicz.TabIndex = 1;
            this.bt_wylicz.Text = "Wylicz";
            this.bt_wylicz.UseVisualStyleBackColor = true;
            this.bt_wylicz.Click += new System.EventHandler(this.bt_wylicz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Podaj wagę [kg]";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Podaj wzrost [cm]";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Wiek";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wynik";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // wiek
            // 
            this.wiek.Location = new System.Drawing.Point(199, 114);
            this.wiek.Name = "wiek";
            this.wiek.Size = new System.Drawing.Size(100, 22);
            this.wiek.TabIndex = 2;
            this.wiek.TextChanged += new System.EventHandler(this.wiek_TextChanged);
            // 
            // waga
            // 
            this.waga.Location = new System.Drawing.Point(199, 56);
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(100, 22);
            this.waga.TabIndex = 2;
            this.waga.TextChanged += new System.EventHandler(this.waga_TextChanged);
            // 
            // diagnoza
            // 
            this.diagnoza.Location = new System.Drawing.Point(321, 193);
            this.diagnoza.Name = "diagnoza";
            this.diagnoza.Size = new System.Drawing.Size(190, 22);
            this.diagnoza.TabIndex = 2;
            // 
            // wzrost
            // 
            this.wzrost.Location = new System.Drawing.Point(199, 84);
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(100, 22);
            this.wzrost.TabIndex = 2;
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(199, 193);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 22);
            this.wynik.TabIndex = 2;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // kobieta
            // 
            this.kobieta.AutoSize = true;
            this.kobieta.Location = new System.Drawing.Point(199, 155);
            this.kobieta.Name = "kobieta";
            this.kobieta.Size = new System.Drawing.Size(78, 21);
            this.kobieta.TabIndex = 3;
            this.kobieta.Text = "Kobieta";
            this.kobieta.UseVisualStyleBackColor = true;
            this.kobieta.CheckedChanged += new System.EventHandler(this.kobieta_CheckedChanged_1);
            // 
            // mezczyzna
            // 
            this.mezczyzna.AutoSize = true;
            this.mezczyzna.Location = new System.Drawing.Point(321, 155);
            this.mezczyzna.Name = "mezczyzna";
            this.mezczyzna.Size = new System.Drawing.Size(100, 21);
            this.mezczyzna.TabIndex = 3;
            this.mezczyzna.Text = "Mężczyzna";
            this.mezczyzna.UseVisualStyleBackColor = true;
            this.mezczyzna.CheckedChanged += new System.EventHandler(this.mezczyzna_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Płeć";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 317);
            this.Controls.Add(this.mezczyzna);
            this.Controls.Add(this.kobieta);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.diagnoza);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.wiek);
            this.Controls.Add(this.bt_wylicz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator BMI";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_wylicz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox wiek;
        private System.Windows.Forms.TextBox waga;
        private System.Windows.Forms.TextBox diagnoza;
        private System.Windows.Forms.TextBox wzrost;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.CheckBox kobieta;
        private System.Windows.Forms.CheckBox mezczyzna;
        private System.Windows.Forms.Label label7;
    }
}
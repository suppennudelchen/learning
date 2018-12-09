namespace WerkstattToolbox
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Durchmesser = new System.Windows.Forms.TextBox();
            this.textBox_Schnittgeschwindigkeit = new System.Windows.Forms.TextBox();
            this.textBox_AnzahlZaehne = new System.Windows.Forms.TextBox();
            this.textBox_VorschubProZahn = new System.Windows.Forms.TextBox();
            this.Btn_Berechne_Drehzahl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Ausgabe_Drehzahl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Ausgabe_Vorschub = new System.Windows.Forms.Label();
            this.Btn_Berechne_Vorschub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Durchmesser [mm]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schnittgeschwindigkeit [m/min]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorschub pro Zahn [mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anzahl Zähne";
            // 
            // textBox_Durchmesser
            // 
            this.textBox_Durchmesser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Durchmesser.Location = new System.Drawing.Point(320, 9);
            this.textBox_Durchmesser.Name = "textBox_Durchmesser";
            this.textBox_Durchmesser.Size = new System.Drawing.Size(100, 30);
            this.textBox_Durchmesser.TabIndex = 4;
            // 
            // textBox_Schnittgeschwindigkeit
            // 
            this.textBox_Schnittgeschwindigkeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Schnittgeschwindigkeit.Location = new System.Drawing.Point(320, 45);
            this.textBox_Schnittgeschwindigkeit.Name = "textBox_Schnittgeschwindigkeit";
            this.textBox_Schnittgeschwindigkeit.Size = new System.Drawing.Size(100, 30);
            this.textBox_Schnittgeschwindigkeit.TabIndex = 5;
            // 
            // textBox_AnzahlZaehne
            // 
            this.textBox_AnzahlZaehne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AnzahlZaehne.Location = new System.Drawing.Point(320, 81);
            this.textBox_AnzahlZaehne.Name = "textBox_AnzahlZaehne";
            this.textBox_AnzahlZaehne.Size = new System.Drawing.Size(100, 30);
            this.textBox_AnzahlZaehne.TabIndex = 6;
            // 
            // textBox_VorschubProZahn
            // 
            this.textBox_VorschubProZahn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VorschubProZahn.Location = new System.Drawing.Point(320, 117);
            this.textBox_VorschubProZahn.Name = "textBox_VorschubProZahn";
            this.textBox_VorschubProZahn.Size = new System.Drawing.Size(100, 30);
            this.textBox_VorschubProZahn.TabIndex = 7;
            // 
            // Btn_Berechne_Drehzahl
            // 
            this.Btn_Berechne_Drehzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Berechne_Drehzahl.Location = new System.Drawing.Point(426, 9);
            this.Btn_Berechne_Drehzahl.Name = "Btn_Berechne_Drehzahl";
            this.Btn_Berechne_Drehzahl.Size = new System.Drawing.Size(206, 66);
            this.Btn_Berechne_Drehzahl.TabIndex = 8;
            this.Btn_Berechne_Drehzahl.Text = "Berechne Drehzahl";
            this.Btn_Berechne_Drehzahl.UseVisualStyleBackColor = true;
            this.Btn_Berechne_Drehzahl.Click += new System.EventHandler(this.Btn_Berechne_Drehzahl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(638, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Drehzahl [1/min]";
            // 
            // Ausgabe_Drehzahl
            // 
            this.Ausgabe_Drehzahl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ausgabe_Drehzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ausgabe_Drehzahl.Location = new System.Drawing.Point(828, 29);
            this.Ausgabe_Drehzahl.Name = "Ausgabe_Drehzahl";
            this.Ausgabe_Drehzahl.Size = new System.Drawing.Size(205, 30);
            this.Ausgabe_Drehzahl.TabIndex = 10;
            this.Ausgabe_Drehzahl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(638, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vorschub [mm/min]";
            // 
            // Ausgabe_Vorschub
            // 
            this.Ausgabe_Vorschub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Ausgabe_Vorschub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ausgabe_Vorschub.Location = new System.Drawing.Point(828, 102);
            this.Ausgabe_Vorschub.Name = "Ausgabe_Vorschub";
            this.Ausgabe_Vorschub.Size = new System.Drawing.Size(205, 30);
            this.Ausgabe_Vorschub.TabIndex = 12;
            this.Ausgabe_Vorschub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Berechne_Vorschub
            // 
            this.Btn_Berechne_Vorschub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Berechne_Vorschub.Location = new System.Drawing.Point(426, 81);
            this.Btn_Berechne_Vorschub.Name = "Btn_Berechne_Vorschub";
            this.Btn_Berechne_Vorschub.Size = new System.Drawing.Size(206, 66);
            this.Btn_Berechne_Vorschub.TabIndex = 13;
            this.Btn_Berechne_Vorschub.Text = "Berechne Vorschub";
            this.Btn_Berechne_Vorschub.UseVisualStyleBackColor = true;
            this.Btn_Berechne_Vorschub.Click += new System.EventHandler(this.Btn_Berechne_Vorschub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 644);
            this.Controls.Add(this.Btn_Berechne_Vorschub);
            this.Controls.Add(this.Ausgabe_Vorschub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ausgabe_Drehzahl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Berechne_Drehzahl);
            this.Controls.Add(this.textBox_VorschubProZahn);
            this.Controls.Add(this.textBox_AnzahlZaehne);
            this.Controls.Add(this.textBox_Schnittgeschwindigkeit);
            this.Controls.Add(this.textBox_Durchmesser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Durchmesser;
        private System.Windows.Forms.TextBox textBox_Schnittgeschwindigkeit;
        private System.Windows.Forms.TextBox textBox_AnzahlZaehne;
        private System.Windows.Forms.TextBox textBox_VorschubProZahn;
        private System.Windows.Forms.Button Btn_Berechne_Drehzahl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Ausgabe_Drehzahl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Ausgabe_Vorschub;
        private System.Windows.Forms.Button Btn_Berechne_Vorschub;
    }
}


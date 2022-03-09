namespace Metody04_08
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_mocnina = new System.Windows.Forms.Button();
            this.button_faktorial = new System.Windows.Forms.Button();
            this.button_cifLich = new System.Windows.Forms.Button();
            this.button_prvocislo = new System.Windows.Forms.Button();
            this.button_pocetDel = new System.Windows.Forms.Button();
            this.textBox_zaklad = new System.Windows.Forms.TextBox();
            this.textBox_exponent = new System.Windows.Forms.TextBox();
            this.textBox_faktorial = new System.Windows.Forms.TextBox();
            this.textBox_cifra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_mocnina
            // 
            this.button_mocnina.Location = new System.Drawing.Point(78, 59);
            this.button_mocnina.Name = "button_mocnina";
            this.button_mocnina.Size = new System.Drawing.Size(119, 31);
            this.button_mocnina.TabIndex = 0;
            this.button_mocnina.Text = "Mocnina";
            this.button_mocnina.UseVisualStyleBackColor = true;
            this.button_mocnina.Click += new System.EventHandler(this.button_mocnina_Click);
            // 
            // button_faktorial
            // 
            this.button_faktorial.Location = new System.Drawing.Point(589, 59);
            this.button_faktorial.Name = "button_faktorial";
            this.button_faktorial.Size = new System.Drawing.Size(119, 31);
            this.button_faktorial.TabIndex = 1;
            this.button_faktorial.Text = "Faktorial";
            this.button_faktorial.UseVisualStyleBackColor = true;
            this.button_faktorial.Click += new System.EventHandler(this.button_faktorial_Click);
            // 
            // button_cifLich
            // 
            this.button_cifLich.Location = new System.Drawing.Point(339, 202);
            this.button_cifLich.Name = "button_cifLich";
            this.button_cifLich.Size = new System.Drawing.Size(119, 32);
            this.button_cifLich.TabIndex = 2;
            this.button_cifLich.Text = "CifLichSoucet";
            this.button_cifLich.UseVisualStyleBackColor = true;
            this.button_cifLich.Click += new System.EventHandler(this.button_cifLich_Click);
            // 
            // button_prvocislo
            // 
            this.button_prvocislo.Location = new System.Drawing.Point(78, 389);
            this.button_prvocislo.Name = "button_prvocislo";
            this.button_prvocislo.Size = new System.Drawing.Size(119, 32);
            this.button_prvocislo.TabIndex = 3;
            this.button_prvocislo.Text = "Prvocislo";
            this.button_prvocislo.UseVisualStyleBackColor = true;
            // 
            // button_pocetDel
            // 
            this.button_pocetDel.Location = new System.Drawing.Point(589, 390);
            this.button_pocetDel.Name = "button_pocetDel";
            this.button_pocetDel.Size = new System.Drawing.Size(119, 31);
            this.button_pocetDel.TabIndex = 4;
            this.button_pocetDel.Text = "Počet dělitelů";
            this.button_pocetDel.UseVisualStyleBackColor = true;
            // 
            // textBox_zaklad
            // 
            this.textBox_zaklad.Location = new System.Drawing.Point(78, 33);
            this.textBox_zaklad.Name = "textBox_zaklad";
            this.textBox_zaklad.Size = new System.Drawing.Size(119, 20);
            this.textBox_zaklad.TabIndex = 5;
            this.textBox_zaklad.Text = "5";
            // 
            // textBox_exponent
            // 
            this.textBox_exponent.Location = new System.Drawing.Point(169, 7);
            this.textBox_exponent.Name = "textBox_exponent";
            this.textBox_exponent.Size = new System.Drawing.Size(28, 20);
            this.textBox_exponent.TabIndex = 6;
            this.textBox_exponent.Text = "-2";
            // 
            // textBox_faktorial
            // 
            this.textBox_faktorial.Location = new System.Drawing.Point(589, 33);
            this.textBox_faktorial.Name = "textBox_faktorial";
            this.textBox_faktorial.Size = new System.Drawing.Size(119, 20);
            this.textBox_faktorial.TabIndex = 7;
            this.textBox_faktorial.Text = "5";
            // 
            // textBox_cifra
            // 
            this.textBox_cifra.Location = new System.Drawing.Point(339, 176);
            this.textBox_cifra.Name = "textBox_cifra";
            this.textBox_cifra.Size = new System.Drawing.Size(119, 20);
            this.textBox_cifra.TabIndex = 8;
            this.textBox_cifra.Text = "75382";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_cifra);
            this.Controls.Add(this.textBox_faktorial);
            this.Controls.Add(this.textBox_exponent);
            this.Controls.Add(this.textBox_zaklad);
            this.Controls.Add(this.button_pocetDel);
            this.Controls.Add(this.button_prvocislo);
            this.Controls.Add(this.button_cifLich);
            this.Controls.Add(this.button_faktorial);
            this.Controls.Add(this.button_mocnina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_mocnina;
        private System.Windows.Forms.Button button_faktorial;
        private System.Windows.Forms.Button button_cifLich;
        private System.Windows.Forms.Button button_prvocislo;
        private System.Windows.Forms.Button button_pocetDel;
        private System.Windows.Forms.TextBox textBox_zaklad;
        private System.Windows.Forms.TextBox textBox_exponent;
        private System.Windows.Forms.TextBox textBox_faktorial;
        private System.Windows.Forms.TextBox textBox_cifra;
    }
}


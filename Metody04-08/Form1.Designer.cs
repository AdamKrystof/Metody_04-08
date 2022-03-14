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
            this.textBox_prvocislo = new System.Windows.Forms.TextBox();
            this.textBox_pocetDel = new System.Windows.Forms.TextBox();
            this.textBox_nsd = new System.Windows.Forms.TextBox();
            this.button_NSD = new System.Windows.Forms.Button();
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
            this.button_cifLich.Location = new System.Drawing.Point(78, 228);
            this.button_cifLich.Name = "button_cifLich";
            this.button_cifLich.Size = new System.Drawing.Size(119, 32);
            this.button_cifLich.TabIndex = 2;
            this.button_cifLich.Text = "CifLichSoucet";
            this.button_cifLich.UseVisualStyleBackColor = true;
            this.button_cifLich.Click += new System.EventHandler(this.button_cifLich_Click);
            // 
            // button_prvocislo
            // 
            this.button_prvocislo.Location = new System.Drawing.Point(589, 228);
            this.button_prvocislo.Name = "button_prvocislo";
            this.button_prvocislo.Size = new System.Drawing.Size(119, 32);
            this.button_prvocislo.TabIndex = 3;
            this.button_prvocislo.Text = "Prvocislo";
            this.button_prvocislo.UseVisualStyleBackColor = true;
            this.button_prvocislo.Click += new System.EventHandler(this.button_prvocislo_Click);
            // 
            // button_pocetDel
            // 
            this.button_pocetDel.Location = new System.Drawing.Point(78, 376);
            this.button_pocetDel.Name = "button_pocetDel";
            this.button_pocetDel.Size = new System.Drawing.Size(119, 31);
            this.button_pocetDel.TabIndex = 4;
            this.button_pocetDel.Text = "Počet dělitelů";
            this.button_pocetDel.UseVisualStyleBackColor = true;
            this.button_pocetDel.Click += new System.EventHandler(this.button_pocetDel_Click);
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
            this.textBox_cifra.Location = new System.Drawing.Point(78, 202);
            this.textBox_cifra.Name = "textBox_cifra";
            this.textBox_cifra.Size = new System.Drawing.Size(119, 20);
            this.textBox_cifra.TabIndex = 8;
            this.textBox_cifra.Text = "75382";
            // 
            // textBox_prvocislo
            // 
            this.textBox_prvocislo.Location = new System.Drawing.Point(589, 202);
            this.textBox_prvocislo.Name = "textBox_prvocislo";
            this.textBox_prvocislo.Size = new System.Drawing.Size(119, 20);
            this.textBox_prvocislo.TabIndex = 10;
            this.textBox_prvocislo.Text = "11";
            // 
            // textBox_pocetDel
            // 
            this.textBox_pocetDel.Location = new System.Drawing.Point(78, 350);
            this.textBox_pocetDel.Name = "textBox_pocetDel";
            this.textBox_pocetDel.Size = new System.Drawing.Size(119, 20);
            this.textBox_pocetDel.TabIndex = 11;
            this.textBox_pocetDel.Text = "15";
            this.textBox_pocetDel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_nsd
            // 
            this.textBox_nsd.Location = new System.Drawing.Point(589, 350);
            this.textBox_nsd.Name = "textBox_nsd";
            this.textBox_nsd.Size = new System.Drawing.Size(119, 20);
            this.textBox_nsd.TabIndex = 12;
            this.textBox_nsd.Text = "15";
            // 
            // button_NSD
            // 
            this.button_NSD.Location = new System.Drawing.Point(589, 376);
            this.button_NSD.Name = "button_NSD";
            this.button_NSD.Size = new System.Drawing.Size(119, 31);
            this.button_NSD.TabIndex = 13;
            this.button_NSD.Text = "NSD";
            this.button_NSD.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_NSD);
            this.Controls.Add(this.textBox_nsd);
            this.Controls.Add(this.textBox_pocetDel);
            this.Controls.Add(this.textBox_prvocislo);
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
        private System.Windows.Forms.TextBox textBox_prvocislo;
        private System.Windows.Forms.TextBox textBox_pocetDel;
        private System.Windows.Forms.TextBox textBox_nsd;
        private System.Windows.Forms.Button button_NSD;
    }
}


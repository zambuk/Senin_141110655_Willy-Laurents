namespace Latihan_POS
{
    partial class editBarang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtBarang = new System.Windows.Forms.TextBox();
            this.txtJumlahAwal = new System.Windows.Forms.TextBox();
            this.txtHPP = new System.Windows.Forms.TextBox();
            this.txtJual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Awal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga HPP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Jual";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(190, 33);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(196, 20);
            this.txtKode.TabIndex = 5;
            // 
            // txtBarang
            // 
            this.txtBarang.Location = new System.Drawing.Point(190, 64);
            this.txtBarang.Name = "txtBarang";
            this.txtBarang.Size = new System.Drawing.Size(196, 20);
            this.txtBarang.TabIndex = 6;
            // 
            // txtJumlahAwal
            // 
            this.txtJumlahAwal.Location = new System.Drawing.Point(190, 98);
            this.txtJumlahAwal.Name = "txtJumlahAwal";
            this.txtJumlahAwal.Size = new System.Drawing.Size(196, 20);
            this.txtJumlahAwal.TabIndex = 7;
            // 
            // txtHPP
            // 
            this.txtHPP.Location = new System.Drawing.Point(190, 134);
            this.txtHPP.Name = "txtHPP";
            this.txtHPP.Size = new System.Drawing.Size(196, 20);
            this.txtHPP.TabIndex = 8;
            // 
            // txtJual
            // 
            this.txtJual.Location = new System.Drawing.Point(190, 166);
            this.txtJual.Name = "txtJual";
            this.txtJual.Size = new System.Drawing.Size(196, 20);
            this.txtJual.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // editBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJual);
            this.Controls.Add(this.txtHPP);
            this.Controls.Add(this.txtJumlahAwal);
            this.Controls.Add(this.txtBarang);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "editBarang";
            this.Text = "editBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtBarang;
        private System.Windows.Forms.TextBox txtJumlahAwal;
        private System.Windows.Forms.TextBox txtHPP;
        private System.Windows.Forms.TextBox txtJual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

namespace area
{
    partial class area
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.judul = new System.Windows.Forms.Label();
            this.rumus = new System.Windows.Forms.Label();
            this.bangun_datar = new System.Windows.Forms.ComboBox();
            this.val1 = new System.Windows.Forms.TextBox();
            this.val2 = new System.Windows.Forms.TextBox();
            this.hitung = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.judul.Location = new System.Drawing.Point(101, 19);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(230, 32);
            this.judul.TabIndex = 0;
            this.judul.Text = "Luas Bangun Datar";
            // 
            // rumus
            // 
            this.rumus.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.rumus.Location = new System.Drawing.Point(22, 126);
            this.rumus.Name = "rumus";
            this.rumus.Size = new System.Drawing.Size(387, 42);
            this.rumus.TabIndex = 1;
            this.rumus.Text = "Rumus";
            this.rumus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bangun_datar
            // 
            this.bangun_datar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bangun_datar.FormattingEnabled = true;
            this.bangun_datar.Items.AddRange(new object[] {
            "- Pilih -",
            "Persegi",
            "Persegi Panjang",
            "Segitiga",
            "Lingkaran",
            "Trapesium",
            "Jajar Genjang",
            "Belah Ketupat",
            "Layang-layang"});
            this.bangun_datar.Location = new System.Drawing.Point(22, 80);
            this.bangun_datar.Name = "bangun_datar";
            this.bangun_datar.Size = new System.Drawing.Size(387, 33);
            this.bangun_datar.TabIndex = 5;
            this.bangun_datar.SelectedIndexChanged += new System.EventHandler(this.bangun_datar_SelectedIndexChanged);
            // 
            // val1
            // 
            this.val1.Enabled = false;
            this.val1.Location = new System.Drawing.Point(22, 210);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(387, 31);
            this.val1.TabIndex = 6;
            // 
            // val2
            // 
            this.val2.Enabled = false;
            this.val2.Location = new System.Drawing.Point(22, 285);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(387, 31);
            this.val2.TabIndex = 7;
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(22, 344);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(387, 34);
            this.hitung.TabIndex = 9;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // hasil
            // 
            this.hasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hasil.Location = new System.Drawing.Point(22, 406);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(387, 150);
            this.hasil.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 12;
            // 
            // area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.bangun_datar);
            this.Controls.Add(this.rumus);
            this.Controls.Add(this.judul);
            this.Name = "area";
            this.Text = "Area";
            this.Load += new System.EventHandler(this.area_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.Label rumus;
        private System.Windows.Forms.ComboBox bangun_datar;
        private System.Windows.Forms.TextBox val1;
        private System.Windows.Forms.TextBox val2;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label hasil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


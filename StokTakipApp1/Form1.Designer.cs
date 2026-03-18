namespace StokTakipApp1
{
    partial class Form1
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
            btnStok = new Button();
            btnCari = new Button();
            btnSatis = new Button();
            SuspendLayout();
            // 
            // btnStok
            // 
            btnStok.Location = new Point(60, 36);
            btnStok.Name = "btnStok";
            btnStok.Size = new Size(154, 29);
            btnStok.TabIndex = 0;
            btnStok.Text = "📦 Stok Yönetimi";
            btnStok.UseVisualStyleBackColor = true;
            btnStok.Click += btnStok_Click;
            // 
            // btnCari
            // 
            btnCari.Location = new Point(60, 71);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(154, 29);
            btnCari.TabIndex = 1;
            btnCari.Text = "👥 Cari Listesi";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // btnSatis
            // 
            btnSatis.Location = new Point(60, 106);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(154, 29);
            btnSatis.TabIndex = 2;
            btnSatis.Text = "\U0001f6d2 Satış Yap";
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Click += btnSatis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSatis);
            Controls.Add(btnCari);
            Controls.Add(btnStok);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStok;
        private Button btnCari;
        private Button btnSatis;
    }
}

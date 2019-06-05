namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttopla = new System.Windows.Forms.Button();
            this.tbekran = new System.Windows.Forms.TextBox();
            this.btobeb = new System.Windows.Forms.Button();
            this.btesittir = new System.Windows.Forms.Button();
            this.btcikar = new System.Windows.Forms.Button();
            this.btcarp = new System.Windows.Forms.Button();
            this.btbol = new System.Windows.Forms.Button();
            this.btyuzde = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btus = new System.Windows.Forms.Button();
            this.btokek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttopla
            // 
            this.bttopla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttopla.Location = new System.Drawing.Point(95, 118);
            this.bttopla.Name = "bttopla";
            this.bttopla.Size = new System.Drawing.Size(72, 43);
            this.bttopla.TabIndex = 0;
            this.bttopla.Text = "+";
            this.bttopla.UseVisualStyleBackColor = true;
            this.bttopla.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbekran
            // 
            this.tbekran.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbekran.Location = new System.Drawing.Point(95, 61);
            this.tbekran.Name = "tbekran";
            this.tbekran.Size = new System.Drawing.Size(351, 38);
            this.tbekran.TabIndex = 1;
            this.tbekran.Text = "0";
            this.tbekran.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btobeb
            // 
            this.btobeb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btobeb.Location = new System.Drawing.Point(95, 217);
            this.btobeb.Name = "btobeb";
            this.btobeb.Size = new System.Drawing.Size(122, 44);
            this.btobeb.TabIndex = 7;
            this.btobeb.Text = "OBEB";
            this.btobeb.UseVisualStyleBackColor = true;
            this.btobeb.Click += new System.EventHandler(this.btobeb_Click);
            // 
            // btesittir
            // 
            this.btesittir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btesittir.Location = new System.Drawing.Point(388, 168);
            this.btesittir.Name = "btesittir";
            this.btesittir.Size = new System.Drawing.Size(58, 93);
            this.btesittir.TabIndex = 10;
            this.btesittir.Text = "=";
            this.btesittir.UseVisualStyleBackColor = true;
            this.btesittir.Click += new System.EventHandler(this.btesittir_Click);
            // 
            // btcikar
            // 
            this.btcikar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btcikar.Location = new System.Drawing.Point(190, 118);
            this.btcikar.Name = "btcikar";
            this.btcikar.Size = new System.Drawing.Size(72, 43);
            this.btcikar.TabIndex = 12;
            this.btcikar.Text = "-";
            this.btcikar.UseVisualStyleBackColor = true;
            this.btcikar.Click += new System.EventHandler(this.btcikar_Click);
            // 
            // btcarp
            // 
            this.btcarp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btcarp.Location = new System.Drawing.Point(95, 168);
            this.btcarp.Name = "btcarp";
            this.btcarp.Size = new System.Drawing.Size(72, 43);
            this.btcarp.TabIndex = 14;
            this.btcarp.Text = "x";
            this.btcarp.UseVisualStyleBackColor = true;
            this.btcarp.Click += new System.EventHandler(this.btcarp_Click);
            // 
            // btbol
            // 
            this.btbol.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btbol.Location = new System.Drawing.Point(190, 168);
            this.btbol.Name = "btbol";
            this.btbol.Size = new System.Drawing.Size(72, 43);
            this.btbol.TabIndex = 15;
            this.btbol.Text = "/";
            this.btbol.UseVisualStyleBackColor = true;
            this.btbol.Click += new System.EventHandler(this.btbol_Click);
            // 
            // btyuzde
            // 
            this.btyuzde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btyuzde.Location = new System.Drawing.Point(289, 168);
            this.btyuzde.Name = "btyuzde";
            this.btyuzde.Size = new System.Drawing.Size(72, 43);
            this.btyuzde.TabIndex = 16;
            this.btyuzde.Text = "%";
            this.btyuzde.UseVisualStyleBackColor = true;
            this.btyuzde.Click += new System.EventHandler(this.btyuzde_Click);
            // 
            // btc
            // 
            this.btc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btc.Location = new System.Drawing.Point(388, 118);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(58, 43);
            this.btc.TabIndex = 18;
            this.btc.Text = "C";
            this.btc.UseVisualStyleBackColor = true;
            this.btc.Click += new System.EventHandler(this.btc_Click);
            // 
            // btus
            // 
            this.btus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btus.Location = new System.Drawing.Point(289, 118);
            this.btus.Name = "btus";
            this.btus.Size = new System.Drawing.Size(72, 43);
            this.btus.TabIndex = 19;
            this.btus.Text = "*";
            this.btus.UseVisualStyleBackColor = true;
            this.btus.Click += new System.EventHandler(this.btus_Click);
            // 
            // btokek
            // 
            this.btokek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btokek.Location = new System.Drawing.Point(239, 217);
            this.btokek.Name = "btokek";
            this.btokek.Size = new System.Drawing.Size(122, 44);
            this.btokek.TabIndex = 20;
            this.btokek.Text = "OKEK";
            this.btokek.UseVisualStyleBackColor = true;
            this.btokek.Click += new System.EventHandler(this.btokek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 358);
            this.Controls.Add(this.btokek);
            this.Controls.Add(this.btus);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btyuzde);
            this.Controls.Add(this.btbol);
            this.Controls.Add(this.btcarp);
            this.Controls.Add(this.btcikar);
            this.Controls.Add(this.btesittir);
            this.Controls.Add(this.btobeb);
            this.Controls.Add(this.tbekran);
            this.Controls.Add(this.bttopla);
            this.Name = "Form1";
            this.Text = "HesapMakinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttopla;
        private System.Windows.Forms.TextBox tbekran;
        private System.Windows.Forms.Button btobeb;
        private System.Windows.Forms.Button btesittir;
        private System.Windows.Forms.Button btcikar;
        private System.Windows.Forms.Button btcarp;
        private System.Windows.Forms.Button btbol;
        private System.Windows.Forms.Button btyuzde;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btus;
        private System.Windows.Forms.Button btokek;
    }
}


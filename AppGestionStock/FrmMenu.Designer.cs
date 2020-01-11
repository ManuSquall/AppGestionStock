namespace AppGestionStock
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.btnCategorie = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCategorie.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCategorie.FlatAppearance.BorderSize = 5;
            this.btnCategorie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCategorie.Location = new System.Drawing.Point(117, 99);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(173, 37);
            this.btnCategorie.TabIndex = 0;
            this.btnCategorie.Text = "Categorie";
            this.btnCategorie.UseVisualStyleBackColor = false;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.Color.SlateBlue;
            this.btnProduit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduit.FlatAppearance.BorderSize = 5;
            this.btnProduit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduit.Location = new System.Drawing.Point(529, 99);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(173, 37);
            this.btnProduit.TabIndex = 1;
            this.btnProduit.Text = "Produit";
            this.btnProduit.UseVisualStyleBackColor = false;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "APPROVISIONNEMENT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 274);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProduit);
            this.Controls.Add(this.btnCategorie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
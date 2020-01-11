namespace AppGestionStock
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suivantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precedentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourToolStripMenuItem,
            this.suivantToolStripMenuItem,
            this.precedentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retourToolStripMenuItem
            // 
            this.retourToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retourToolStripMenuItem.Image")));
            this.retourToolStripMenuItem.Name = "retourToolStripMenuItem";
            this.retourToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.retourToolStripMenuItem.Click += new System.EventHandler(this.retourToolStripMenuItem_Click);
            // 
            // suivantToolStripMenuItem
            // 
            this.suivantToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suivantToolStripMenuItem.Image")));
            this.suivantToolStripMenuItem.Name = "suivantToolStripMenuItem";
            this.suivantToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            this.suivantToolStripMenuItem.Click += new System.EventHandler(this.suivantToolStripMenuItem_Click);
            // 
            // precedentToolStripMenuItem
            // 
            this.precedentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("precedentToolStripMenuItem.Image")));
            this.precedentToolStripMenuItem.Name = "precedentToolStripMenuItem";
            this.precedentToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AppGestionStock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suivantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precedentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


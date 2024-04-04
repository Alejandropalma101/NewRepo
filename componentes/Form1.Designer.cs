namespace componentes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.musica = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn = new System.Windows.Forms.Button();
            this.navegador = new AxSHDocVw.AxWebBrowser();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegador)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF1
            // 
            this.PDF1.Enabled = true;
            this.PDF1.Location = new System.Drawing.Point(283, 14);
            this.PDF1.Name = "PDF1";
            this.PDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF1.OcxState")));
            this.PDF1.Size = new System.Drawing.Size(251, 168);
            this.PDF1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirPDFToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.archivoToolStripMenuItem.Text = "lector de archivos ";
            // 
            // abrirPDFToolStripMenuItem
            // 
            this.abrirPDFToolStripMenuItem.Name = "abrirPDFToolStripMenuItem";
            this.abrirPDFToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.abrirPDFToolStripMenuItem.Text = "Abrir PDF";
            this.abrirPDFToolStripMenuItem.Click += new System.EventHandler(this.abrirPDFToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Buscador de archivos para abrir PDF";
            // 
            // musica
            // 
            this.musica.Enabled = true;
            this.musica.Location = new System.Drawing.Point(0, 27);
            this.musica.Name = "musica";
            this.musica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musica.OcxState")));
            this.musica.Size = new System.Drawing.Size(253, 140);
            this.musica.TabIndex = 2;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(0, 192);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 32);
            this.btn.TabIndex = 3;
            this.btn.Text = "video";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // navegador
            // 
            this.navegador.Enabled = true;
            this.navegador.Location = new System.Drawing.Point(565, 26);
            this.navegador.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("navegador.OcxState")));
            this.navegador.Size = new System.Drawing.Size(209, 139);
            this.navegador.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(578, 171);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(183, 20);
            this.txt1.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(641, 218);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(83, 25);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "navegador";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.navegador);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.musica);
            this.Controls.Add(this.PDF1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PDF1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navegador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF PDF1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxWMPLib.AxWindowsMediaPlayer musica;
        private System.Windows.Forms.Button btn;
        private AxSHDocVw.AxWebBrowser navegador;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
    }
}


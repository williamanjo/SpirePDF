namespace SpirePDF
{
    partial class SpirePDF
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpirePDF));
            this.label1 = new System.Windows.Forms.Label();
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.SaveAs = new System.Windows.Forms.ToolStripButton();
            this.CurrentPage = new System.Windows.Forms.ToolStripTextBox();
            this.pageHandle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mergePdfsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reordenarPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BackColor = System.Drawing.SystemColors.Control;
            this.pdfViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.Yellow;
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = false;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 3);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(780, 558);
            this.pdfViewer1.TabIndex = 4;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfViewer1.PageNumberChanged += new Spire.PdfViewer.PageNumberChangedEventHandler(this.PageChanged_Event);
            this.pdfViewer1.DocumentOpened += new Spire.PdfViewer.DocumentOpenedEventHandler(this.PdfViewer1_Open);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pdfViewer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(780, 556);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 1);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(780, 581);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveAs,
            this.CurrentPage,
            this.pageHandle,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(230, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // OpenFile
            // 
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("OpenFile.Image")));
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(23, 22);
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveAs
            // 
            this.SaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAs.Image = ((System.Drawing.Image)(resources.GetObject("SaveAs.Image")));
            this.SaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAs.Name = "SaveAs";
            this.SaveAs.Size = new System.Drawing.Size(23, 22);
            this.SaveAs.Text = "SaveAs";
            this.SaveAs.Click += new System.EventHandler(this.SaveAs_Click);
            // 
            // CurrentPage
            // 
            this.CurrentPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrentPage.MaxLength = 327;
            this.CurrentPage.Name = "CurrentPage";
            this.CurrentPage.Size = new System.Drawing.Size(50, 25);
            this.CurrentPage.Text = "0";
            this.CurrentPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrentPage.Leave += new System.EventHandler(this.PageChanged_EventEnter);
            this.CurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPage_KeyPress);
            // 
            // pageHandle
            // 
            this.pageHandle.Name = "pageHandle";
            this.pageHandle.Size = new System.Drawing.Size(29, 22);
            this.pageHandle.Text = "de 0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergePdfsToolStripMenuItem,
            this.reordenarPdfToolStripMenuItem,
            this.extractPagesToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(85, 22);
            this.toolStripDropDownButton1.Text = "Ferramentas";
            // 
            // mergePdfsToolStripMenuItem
            // 
            this.mergePdfsToolStripMenuItem.Name = "mergePdfsToolStripMenuItem";
            this.mergePdfsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mergePdfsToolStripMenuItem.Text = "MergePdf\'s";
            this.mergePdfsToolStripMenuItem.Click += new System.EventHandler(this.MergePdfsToolStripMenuItem_Click);
            // 
            // reordenarPdfToolStripMenuItem
            // 
            this.reordenarPdfToolStripMenuItem.Name = "reordenarPdfToolStripMenuItem";
            this.reordenarPdfToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.reordenarPdfToolStripMenuItem.Text = "OrderPdfPages";
            // 
            // extractPagesToolStripMenuItem
            // 
            this.extractPagesToolStripMenuItem.Name = "extractPagesToolStripMenuItem";
            this.extractPagesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.extractPagesToolStripMenuItem.Text = "ExtractPages";
            // 
            // SpirePDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 587);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.label1);
            this.Name = "SpirePDF";
            this.Text = "SpirePDF";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpirePDF_FormClosed);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PdfViewer1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveAs;
        private System.Windows.Forms.ToolStripTextBox CurrentPage;
        private System.Windows.Forms.ToolStripLabel pageHandle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton OpenFile;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem mergePdfsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reordenarPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractPagesToolStripMenuItem;
        public Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
    }
}


namespace SpirePDF
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            this.pdfViewerStream = new Spire.PdfViewer.Forms.PdfViewer();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenFiles = new System.Windows.Forms.ToolStripButton();
            this.SaveAsMerge = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewer1.IgnoreCase = false;
            this.pdfViewer1.IsToolBarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(36, 21);
            this.pdfViewer1.MultiPagesThreshold = 60;
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(566, 457);
            this.pdfViewer1.TabIndex = 1;
            this.pdfViewer1.Text = "pdfViewer1";
            this.pdfViewer1.Threshold = 60;
            this.pdfViewer1.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // pdfViewerStream
            // 
            this.pdfViewerStream.FindTextHighLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(153)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.pdfViewerStream.IgnoreCase = false;
            this.pdfViewerStream.IsToolBarVisible = false;
            this.pdfViewerStream.Location = new System.Drawing.Point(0, 2);
            this.pdfViewerStream.MultiPagesThreshold = 60;
            this.pdfViewerStream.Name = "pdfViewerStream";
            this.pdfViewerStream.Size = new System.Drawing.Size(390, 154);
            this.pdfViewerStream.TabIndex = 2;
            this.pdfViewerStream.Text = "pdfViewerStream";
            this.pdfViewerStream.Threshold = 60;
            this.pdfViewerStream.ViewerBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pdfViewerStream);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(392, 160);
            this.toolStripContainer1.Location = new System.Drawing.Point(-1, 3);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(392, 185);
            this.toolStripContainer1.TabIndex = 3;
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
            this.OpenFiles,
            this.SaveAsMerge});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(58, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // OpenFiles
            // 
            this.OpenFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFiles.Image = ((System.Drawing.Image)(resources.GetObject("OpenFiles.Image")));
            this.OpenFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFiles.Name = "OpenFiles";
            this.OpenFiles.Size = new System.Drawing.Size(23, 22);
            this.OpenFiles.Text = "OpenFiles";
            this.OpenFiles.ToolTipText = "OpenFiles";
            this.OpenFiles.Click += new System.EventHandler(this.OpenFiles_Click);
            // 
            // SaveAsMerge
            // 
            this.SaveAsMerge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsMerge.Enabled = false;
            this.SaveAsMerge.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsMerge.Image")));
            this.SaveAsMerge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsMerge.Name = "SaveAsMerge";
            this.SaveAsMerge.Size = new System.Drawing.Size(23, 22);
            this.SaveAsMerge.Text = "SaveAsMerge";
            this.SaveAsMerge.Click += new System.EventHandler(this.SaveAsMerge_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 191);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form2";
            this.Text = "MergePdf\'s";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
        private Spire.PdfViewer.Forms.PdfViewer pdfViewerStream;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SaveAsMerge;
        private System.Windows.Forms.ToolStripButton OpenFiles;
    }
}
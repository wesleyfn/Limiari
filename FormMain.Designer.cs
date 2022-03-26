
namespace Limiari
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.colorScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleGray = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdges = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeRobert = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.quant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sttsStrip = new System.Windows.Forms.StatusStrip();
            this.lblNameString = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgressNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.barProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSizeNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.boxPicture = new System.Windows.Forms.PictureBox();
            this.treeImagens = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.scaleNegative = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.sttsStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen,
            this.toolStripMenuItem1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(180, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(180, 22);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuProcessing
            // 
            this.menuProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorScaleToolStripMenuItem,
            this.menuEdges,
            this.scaleNegative,
            this.quant});
            this.menuProcessing.Name = "menuProcessing";
            this.menuProcessing.Size = new System.Drawing.Size(76, 20);
            this.menuProcessing.Text = "&Processing";
            // 
            // colorScaleToolStripMenuItem
            // 
            this.colorScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleGray});
            this.colorScaleToolStripMenuItem.Name = "colorScaleToolStripMenuItem";
            this.colorScaleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorScaleToolStripMenuItem.Text = "&Color Scales";
            // 
            // scaleGray
            // 
            this.scaleGray.Name = "scaleGray";
            this.scaleGray.Size = new System.Drawing.Size(180, 22);
            this.scaleGray.Text = "&Gray";
            this.scaleGray.Click += new System.EventHandler(this.menuGray_Click);
            // 
            // menuEdges
            // 
            this.menuEdges.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgeRobert,
            this.edgeSobel});
            this.menuEdges.Name = "menuEdges";
            this.menuEdges.Size = new System.Drawing.Size(180, 22);
            this.menuEdges.Text = "&Edge Detectors";
            // 
            // edgeRobert
            // 
            this.edgeRobert.Name = "edgeRobert";
            this.edgeRobert.Size = new System.Drawing.Size(180, 22);
            this.edgeRobert.Text = "&Robert Cross";
            this.edgeRobert.Click += new System.EventHandler(this.edgeRobert_Click);
            // 
            // edgeSobel
            // 
            this.edgeSobel.Name = "edgeSobel";
            this.edgeSobel.Size = new System.Drawing.Size(180, 22);
            this.edgeSobel.Text = "&Sobel";
            this.edgeSobel.Click += new System.EventHandler(this.edgeSobel_Click);
            // 
            // quant
            // 
            this.quant.Name = "quant";
            this.quant.Size = new System.Drawing.Size(180, 22);
            this.quant.Text = "&Quantize";
            this.quant.Click += new System.EventHandler(this.quant_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.toolStripMenuItem2,
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manualToolStripMenuItem.Text = "&Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(180, 22);
            this.menuAbout.Text = "&About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuProcessing,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sttsStrip
            // 
            this.sttsStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sttsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNameString,
            this.lblProgressNum,
            this.barProgress,
            this.lblSizeNum});
            this.sttsStrip.Location = new System.Drawing.Point(0, 426);
            this.sttsStrip.Name = "sttsStrip";
            this.sttsStrip.Size = new System.Drawing.Size(727, 22);
            this.sttsStrip.SizingGrip = false;
            this.sttsStrip.TabIndex = 2;
            this.sttsStrip.Text = "statusStrip1";
            // 
            // lblNameString
            // 
            this.lblNameString.Name = "lblNameString";
            this.lblNameString.Size = new System.Drawing.Size(487, 17);
            this.lblNameString.Spring = true;
            this.lblNameString.Text = "Name:";
            this.lblNameString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProgressNum
            // 
            this.lblProgressNum.Name = "lblProgressNum";
            this.lblProgressNum.Size = new System.Drawing.Size(34, 17);
            this.lblProgressNum.Text = "Sel: 0";
            this.lblProgressNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // barProgress
            // 
            this.barProgress.Name = "barProgress";
            this.barProgress.Size = new System.Drawing.Size(150, 16);
            // 
            // lblSizeNum
            // 
            this.lblSizeNum.Name = "lblSizeNum";
            this.lblSizeNum.Size = new System.Drawing.Size(39, 17);
            this.lblSizeNum.Text = "Size: 0";
            this.lblSizeNum.Click += new System.EventHandler(this.lblSizeNum_Click);
            // 
            // boxPicture
            // 
            this.boxPicture.BackColor = System.Drawing.SystemColors.Control;
            this.boxPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPicture.InitialImage = null;
            this.boxPicture.Location = new System.Drawing.Point(0, 0);
            this.boxPicture.Margin = new System.Windows.Forms.Padding(0);
            this.boxPicture.Name = "boxPicture";
            this.boxPicture.Size = new System.Drawing.Size(544, 402);
            this.boxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxPicture.TabIndex = 5;
            this.boxPicture.TabStop = false;
            // 
            // treeImagens
            // 
            this.treeImagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeImagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeImagens.CheckBoxes = true;
            this.treeImagens.Indent = 15;
            this.treeImagens.ItemHeight = 20;
            this.treeImagens.Location = new System.Drawing.Point(0, 24);
            this.treeImagens.Margin = new System.Windows.Forms.Padding(0);
            this.treeImagens.MinimumSize = new System.Drawing.Size(162, 0);
            this.treeImagens.Name = "treeImagens";
            this.treeImagens.Size = new System.Drawing.Size(180, 402);
            this.treeImagens.TabIndex = 0;
            this.treeImagens.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeImagens_AfterCheck);
            this.treeImagens.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeImagens_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.boxPicture);
            this.panel1.Location = new System.Drawing.Point(183, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 402);
            this.panel1.TabIndex = 6;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // scaleNegative
            // 
            this.scaleNegative.Name = "scaleNegative";
            this.scaleNegative.Size = new System.Drawing.Size(180, 22);
            this.scaleNegative.Text = "&Negative";
            this.scaleNegative.Click += new System.EventHandler(this.menuNegative_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(727, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeImagens);
            this.Controls.Add(this.sttsStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Limiari";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sttsStrip.ResumeLayout(false);
            this.sttsStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuProcessing;
        private System.Windows.Forms.ToolStripMenuItem menuEdges;
        private System.Windows.Forms.ToolStripMenuItem edgeSobel;
        private System.Windows.Forms.ToolStripMenuItem edgeRobert;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip sttsStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblNameString;
        private System.Windows.Forms.ToolStripProgressBar barProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblSizeNum;
        private System.Windows.Forms.TreeView treeImagens;
        private System.Windows.Forms.PictureBox boxPicture;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressNum;
        private System.Windows.Forms.ToolStripMenuItem colorScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleGray;
        private System.Windows.Forms.ToolStripMenuItem quant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleNegative;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}


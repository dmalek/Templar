namespace Templar.UI
{
    partial class SolutionExplorer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorer));
            this.tvTemplates = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvTemplates
            // 
            this.tvTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTemplates.HideSelection = false;
            this.tvTemplates.ImageIndex = 0;
            this.tvTemplates.ImageList = this.imageList1;
            this.tvTemplates.Indent = 19;
            this.tvTemplates.ItemHeight = 22;
            this.tvTemplates.Location = new System.Drawing.Point(0, 0);
            this.tvTemplates.Name = "tvTemplates";
            this.tvTemplates.SelectedImageIndex = 0;
            this.tvTemplates.ShowLines = false;
            this.tvTemplates.Size = new System.Drawing.Size(323, 676);
            this.tvTemplates.TabIndex = 1;
            this.tvTemplates.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTemplates_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "open_folder_16px.png");
            this.imageList1.Images.SetKeyName(1, "view_details_16px.png");
            // 
            // SolutionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvTemplates);
            this.Name = "SolutionExplorer";
            this.Size = new System.Drawing.Size(323, 676);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView tvTemplates;
        private ImageList imageList1;
    }
}

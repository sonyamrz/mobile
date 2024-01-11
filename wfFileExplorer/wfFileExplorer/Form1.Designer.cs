namespace wfFileExplorer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            buBack = new ToolStripButton();
            buForward = new ToolStripButton();
            buUp = new ToolStripButton();
            edDir = new ToolStripTextBox();
            buDirSelect = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            miViewLargeIcon = new ToolStripMenuItem();
            miViewSmallIcon = new ToolStripMenuItem();
            miViewList = new ToolStripMenuItem();
            miViewDetails = new ToolStripMenuItem();
            miViewTile = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            laStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            listView1 = new ListView();
            ilLarge = new ImageList(components);
            ilSmall = new ImageList(components);
            splitter1 = new Splitter();
            treeView2 = new TreeView();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buBack, buForward, buUp, edDir, buDirSelect, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(863, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // buBack
            // 
            buBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buBack.Image = (Image)resources.GetObject("buBack.Image");
            buBack.ImageTransparentColor = Color.Magenta;
            buBack.Name = "buBack";
            buBack.Size = new Size(29, 24);
            buBack.Text = "◀";
            // 
            // buForward
            // 
            buForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buForward.Image = (Image)resources.GetObject("buForward.Image");
            buForward.ImageTransparentColor = Color.Magenta;
            buForward.Name = "buForward";
            buForward.Size = new Size(29, 24);
            buForward.Text = "▶";
            // 
            // buUp
            // 
            buUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buUp.Image = (Image)resources.GetObject("buUp.Image");
            buUp.ImageTransparentColor = Color.Magenta;
            buUp.Name = "buUp";
            buUp.Size = new Size(29, 24);
            buUp.Text = "▲";
            // 
            // edDir
            // 
            edDir.Name = "edDir";
            edDir.Size = new Size(500, 27);
            // 
            // buDirSelect
            // 
            buDirSelect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buDirSelect.Image = (Image)resources.GetObject("buDirSelect.Image");
            buDirSelect.ImageTransparentColor = Color.Magenta;
            buDirSelect.Name = "buDirSelect";
            buDirSelect.Size = new Size(29, 24);
            buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { miViewLargeIcon, miViewSmallIcon, miViewList, miViewDetails, miViewTile });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(49, 24);
            toolStripDropDownButton1.Text = "Вид";
            // 
            // miViewLargeIcon
            // 
            miViewLargeIcon.Name = "miViewLargeIcon";
            miViewLargeIcon.Size = new Size(197, 26);
            miViewLargeIcon.Text = "Крупые значки";
            // 
            // miViewSmallIcon
            // 
            miViewSmallIcon.Name = "miViewSmallIcon";
            miViewSmallIcon.Size = new Size(197, 26);
            miViewSmallIcon.Text = "Мелкие значки";
            // 
            // miViewList
            // 
            miViewList.Name = "miViewList";
            miViewList.Size = new Size(197, 26);
            miViewList.Text = "Список";
            // 
            // miViewDetails
            // 
            miViewDetails.Name = "miViewDetails";
            miViewDetails.Size = new Size(197, 26);
            miViewDetails.Text = "Таблица";
            // 
            // miViewTile
            // 
            miViewTile.Name = "miViewTile";
            miViewTile.Size = new Size(197, 26);
            miViewTile.Text = "Плитки";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { laStatus });
            statusStrip1.Location = new Point(0, 396);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(863, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // laStatus
            // 
            laStatus.Name = "laStatus";
            laStatus.Size = new Size(151, 20);
            laStatus.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(treeView2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 369);
            panel1.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = ilLarge;
            listView1.Location = new Point(155, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(708, 369);
            listView1.SmallImageList = ilSmall;
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = ColorDepth.Depth32Bit;
            ilLarge.ImageStream = (ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = Color.Transparent;
            ilLarge.Images.SetKeyName(0, "folder.png");
            ilLarge.Images.SetKeyName(1, "file.png");
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth32Bit;
            ilSmall.ImageStream = (ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = Color.Transparent;
            ilSmall.Images.SetKeyName(0, "folder.png");
            ilSmall.Images.SetKeyName(1, "file.png");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(151, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 369);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // treeView2
            // 
            treeView2.Dock = DockStyle.Left;
            treeView2.ImageIndex = 0;
            treeView2.ImageList = ilSmall;
            treeView2.Location = new Point(0, 0);
            treeView2.Name = "treeView2";
            treeView2.SelectedImageIndex = 0;
            treeView2.Size = new Size(151, 369);
            treeView2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 422);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "wfFileExplorer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton buBack;
        private ToolStripButton buForward;
        private ToolStripButton buUp;
        private ToolStripTextBox edDir;
        private ToolStripButton buDirSelect;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private TreeView treeView2;
        private Splitter splitter1;
        private ListView listView1;
        private ImageList ilLarge;
        private ImageList ilSmall;
        private ToolStripMenuItem miViewLargeIcon;
        private ToolStripMenuItem miViewSmallIcon;
        private ToolStripMenuItem miViewList;
        private ToolStripMenuItem miViewDetails;
        private ToolStripMenuItem miViewTile;
        private ToolStripStatusLabel laStatus;
    }
}
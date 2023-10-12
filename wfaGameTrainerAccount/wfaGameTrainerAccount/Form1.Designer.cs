namespace wfaGameTrainerAccount
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
            tableLayoutPanel1 = new TableLayoutPanel();
            laWrong = new Label();
            laCorrect = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            buNo = new Button();
            buYes = new Button();
            label3 = new Label();
            laCode = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Snow;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(laWrong, 1, 0);
            tableLayoutPanel1.Controls.Add(laCorrect, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(530, 160);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            laWrong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laWrong.BackColor = Color.Brown;
            laWrong.FlatStyle = FlatStyle.System;
            laWrong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laWrong.Location = new Point(269, 3);
            laWrong.Name = "laWrong";
            laWrong.RightToLeft = RightToLeft.No;
            laWrong.Size = new Size(255, 154);
            laWrong.TabIndex = 1;
            laWrong.Text = "Неверно = 0";
            // 
            // laCorrect
            // 
            laCorrect.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            laCorrect.BackColor = Color.Green;
            laCorrect.FlatStyle = FlatStyle.System;
            laCorrect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            laCorrect.Location = new Point(6, 3);
            laCorrect.Name = "laCorrect";
            laCorrect.RightToLeft = RightToLeft.No;
            laCorrect.Size = new Size(254, 154);
            laCorrect.TabIndex = 0;
            laCorrect.Text = "Верно = 0";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buNo, 1, 0);
            tableLayoutPanel2.Controls.Add(buYes, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 417);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(530, 140);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buNo
            // 
            buNo.Dock = DockStyle.Fill;
            buNo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buNo.ForeColor = Color.Firebrick;
            buNo.Location = new Point(268, 3);
            buNo.Name = "buNo";
            buNo.Size = new Size(259, 134);
            buNo.TabIndex = 1;
            buNo.Text = "Нет";
            buNo.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            buYes.Dock = DockStyle.Fill;
            buYes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            buYes.ForeColor = Color.Green;
            buYes.Location = new Point(3, 3);
            buYes.Name = "buYes";
            buYes.Size = new Size(259, 134);
            buYes.TabIndex = 0;
            buYes.Text = "Да";
            buYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(184, 329);
            label3.Name = "label3";
            label3.Size = new Size(141, 46);
            label3.TabIndex = 2;
            label3.Text = "Верно ?";
            // 
            // laCode
            // 
            laCode.AutoSize = true;
            laCode.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            laCode.Location = new Point(0, 160);
            laCode.Name = "laCode";
            laCode.Size = new Size(209, 54);
            laCode.TabIndex = 3;
            laCode.Text = "10+12=22";
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 557);
            Controls.Add(laCode);
            Controls.Add(label3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label laCorrect;
        private Label laWrong;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buNo;
        private Button buYes;
        private Label label3;
        private Label laCode;
    }
}
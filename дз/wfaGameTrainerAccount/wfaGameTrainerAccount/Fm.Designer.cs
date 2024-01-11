namespace wfaGameTrainerAccount
{
    partial class Fm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.laWrong = new System.Windows.Forms.Label();
            this.laCorrect = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buNo = new System.Windows.Forms.Button();
            this.buSkip = new System.Windows.Forms.Button();
            this.buYes = new System.Windows.Forms.Button();
            this.laCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skipCount = new System.Windows.Forms.Label();
            this.buReset = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.laWrong, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.laCorrect, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 143);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // laWrong
            // 
            this.laWrong.AutoSize = true;
            this.laWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.laWrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laWrong.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laWrong.Location = new System.Drawing.Point(523, 0);
            this.laWrong.Name = "laWrong";
            this.laWrong.Size = new System.Drawing.Size(514, 143);
            this.laWrong.TabIndex = 1;
            this.laWrong.Text = "Неверно = 0";
            this.laWrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laCorrect
            // 
            this.laCorrect.AutoSize = true;
            this.laCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.laCorrect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laCorrect.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.laCorrect.Location = new System.Drawing.Point(3, 0);
            this.laCorrect.Name = "laCorrect";
            this.laCorrect.Size = new System.Drawing.Size(514, 143);
            this.laCorrect.TabIndex = 0;
            this.laCorrect.Text = "Верно = 0";
            this.laCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel2.Controls.Add(this.buNo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buSkip, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buYes, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 429);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1037, 133);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // buNo
            // 
            this.buNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buNo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buNo.Location = new System.Drawing.Point(354, 3);
            this.buNo.Name = "buNo";
            this.buNo.Size = new System.Drawing.Size(345, 127);
            this.buNo.TabIndex = 2;
            this.buNo.Text = "Нет";
            this.buNo.UseVisualStyleBackColor = true;
            // 
            // buSkip
            // 
            this.buSkip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buSkip.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buSkip.ForeColor = System.Drawing.Color.Goldenrod;
            this.buSkip.Location = new System.Drawing.Point(705, 3);
            this.buSkip.Name = "buSkip";
            this.buSkip.Size = new System.Drawing.Size(329, 127);
            this.buSkip.TabIndex = 1;
            this.buSkip.Text = "Пропустить";
            this.buSkip.UseVisualStyleBackColor = true;
            // 
            // buYes
            // 
            this.buYes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buYes.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buYes.Location = new System.Drawing.Point(3, 3);
            this.buYes.Name = "buYes";
            this.buYes.Size = new System.Drawing.Size(345, 127);
            this.buYes.TabIndex = 0;
            this.buYes.Text = "Да";
            this.buYes.UseVisualStyleBackColor = true;
            // 
            // laCode
            // 
            this.laCode.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laCode.Location = new System.Drawing.Point(9, 246);
            this.laCode.Name = "laCode";
            this.laCode.Size = new System.Drawing.Size(1040, 120);
            this.laCode.TabIndex = 2;
            this.laCode.Text = "10+11=21";
            this.laCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(699, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Верно?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skipCount
            // 
            this.skipCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipCount.AutoSize = true;
            this.skipCount.Location = new System.Drawing.Point(717, 405);
            this.skipCount.Name = "skipCount";
            this.skipCount.Size = new System.Drawing.Size(50, 20);
            this.skipCount.TabIndex = 4;
            this.skipCount.Text = "label1";
            // 
            // buReset
            // 
            this.buReset.Location = new System.Drawing.Point(15, 12);
            this.buReset.Name = "buReset";
            this.buReset.Size = new System.Drawing.Size(135, 38);
            this.buReset.TabIndex = 5;
            this.buReset.Text = "Начать заново";
            this.buReset.UseVisualStyleBackColor = true;
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.Location = new System.Drawing.Point(862, 14);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(50, 20);
            this.lvl.TabIndex = 6;
            this.lvl.Text = "label1";
            // 
            // Fm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 574);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.buReset);
            this.Controls.Add(this.skipCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laCode);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Fm";
            this.Text = "wfaGameTrainerAccount";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label laCode;
        private Label label2;
        private Label laWrong;
        private Label laCorrect;
        private Button buSkip;
        private Button buYes;
        private Button buNo;
        private Label skipCount;
        private Button buReset;
        private Label lvl;
    }
}
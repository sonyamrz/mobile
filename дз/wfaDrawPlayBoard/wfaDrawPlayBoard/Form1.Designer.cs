namespace wfaDrawPlayBoard
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
            boardTypeComboBox = new ComboBox();
            drawBoardButton = new Button();
            label = new Label();
            SuspendLayout();
            // 
            // boardTypeComboBox
            // 
            boardTypeComboBox.FormattingEnabled = true;
            boardTypeComboBox.Location = new Point(24, 12);
            boardTypeComboBox.Name = "boardTypeComboBox";
            boardTypeComboBox.Size = new Size(151, 28);
            boardTypeComboBox.TabIndex = 0;
            // 
            // drawBoardButton
            // 
            drawBoardButton.Location = new Point(61, 55);
            drawBoardButton.Name = "drawBoardButton";
            drawBoardButton.Size = new Size(94, 29);
            drawBoardButton.TabIndex = 1;
            drawBoardButton.Text = "button1";
            drawBoardButton.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(236, 18);
            label.Name = "label";
            label.Size = new Size(50, 20);
            label.TabIndex = 2;
            label.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label);
            Controls.Add(drawBoardButton);
            Controls.Add(boardTypeComboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boardTypeComboBox;
        private Button drawBoardButton;
        private Label label;
    }
}
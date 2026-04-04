namespace RollOfTheDiceListBox
{
    partial class RollOfTheDiceListBox
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
            label1 = new Label();
            RollButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            ListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 17);
            label1.Name = "label1";
            label1.Size = new Size(558, 70);
            label1.TabIndex = 0;
            label1.Text = "Roll Of The Dice";
            label1.Click += label1_Click;
            // 
            // RollButton
            // 
            RollButton.Cursor = Cursors.Hand;
            RollButton.Location = new Point(72, 425);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(139, 65);
            RollButton.TabIndex = 1;
            RollButton.Text = "&Roll";
            RollButton.UseVisualStyleBackColor = true;
            RollButton.Click += RollButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.Location = new Point(379, 425);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(139, 65);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Location = new Point(693, 425);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(139, 65);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ListBox
            // 
            ListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListBox.Cursor = Cursors.Hand;
            ListBox.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(72, 99);
            ListBox.MultiColumn = true;
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(760, 284);
            ListBox.TabIndex = 4;
            // 
            // RollOfTheDiceListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 502);
            Controls.Add(ListBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(RollButton);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MinimizeBox = false;
            Name = "RollOfTheDiceListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button RollButton;
        private Button ClearButton;
        private Button ExitButton;
        private ListBox ListBox;
    }
}

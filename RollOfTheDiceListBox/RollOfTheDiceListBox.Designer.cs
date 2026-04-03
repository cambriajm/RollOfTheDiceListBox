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
            listBox1 = new ListBox();
            RollButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
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
            label1.Click += this.label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(72, 90);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(760, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += this.listBox1_SelectedIndexChanged;
            // 
            // RollButton
            // 
            RollButton.Location = new Point(72, 425);
            RollButton.Name = "RollButton";
            RollButton.Size = new Size(139, 65);
            RollButton.TabIndex = 1;
            RollButton.Text = "&Roll";
            RollButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(379, 425);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(139, 65);
            ClearButton.TabIndex = 2;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += this.button2_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(693, 425);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(139, 65);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += this.ExitButton_Click;
            // 
            // RollOfTheDiceListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 502);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(RollButton);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "RollOfTheDiceListBox";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListBox listBox1;
        private Button RollButton;
        private Button ClearButton;
        private Button ExitButton;
    }
}

namespace DataLoggingF26
{
    partial class DataLoggingF26Form
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
            DrawButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            groupBox1 = new GroupBox();
            DisplayPictureBox = new PictureBox();
            TopMenuStrip = new MenuStrip();
            FileTopMenuItem = new ToolStripMenuItem();
            BottomStatusStrip = new StatusStrip();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            TopMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(6, 30);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(134, 68);
            DrawButton.TabIndex = 0;
            DrawButton.Text = "&Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(146, 30);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(134, 68);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(286, 30);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(134, 68);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ExitButton);
            groupBox1.Controls.Add(DrawButton);
            groupBox1.Controls.Add(ClearButton);
            groupBox1.Location = new Point(585, 542);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(427, 128);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.BackColor = Color.Black;
            DisplayPictureBox.Location = new Point(12, 36);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(1000, 500);
            DisplayPictureBox.TabIndex = 4;
            DisplayPictureBox.TabStop = false;
            // 
            // TopMenuStrip
            // 
            TopMenuStrip.ImageScalingSize = new Size(24, 24);
            TopMenuStrip.Items.AddRange(new ToolStripItem[] { FileTopMenuItem });
            TopMenuStrip.Location = new Point(0, 0);
            TopMenuStrip.Name = "TopMenuStrip";
            TopMenuStrip.Size = new Size(1024, 33);
            TopMenuStrip.TabIndex = 5;
            TopMenuStrip.Text = "TopMenuStrip";
            // 
            // FileTopMenuItem
            // 
            FileTopMenuItem.Name = "FileTopMenuItem";
            FileTopMenuItem.Size = new Size(54, 29);
            FileTopMenuItem.Text = "&File";
            // 
            // BottomStatusStrip
            // 
            BottomStatusStrip.ImageScalingSize = new Size(24, 24);
            BottomStatusStrip.Location = new Point(0, 649);
            BottomStatusStrip.Name = "BottomStatusStrip";
            BottomStatusStrip.Size = new Size(1024, 22);
            BottomStatusStrip.TabIndex = 6;
            BottomStatusStrip.Text = "BottomStatusStrip";
            // 
            // DataLoggingF26Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 671);
            Controls.Add(BottomStatusStrip);
            Controls.Add(DisplayPictureBox);
            Controls.Add(groupBox1);
            Controls.Add(TopMenuStrip);
            MainMenuStrip = TopMenuStrip;
            Name = "DataLoggingF26Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Logging";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            TopMenuStrip.ResumeLayout(false);
            TopMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DrawButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox groupBox1;
        private PictureBox DisplayPictureBox;
        private MenuStrip TopMenuStrip;
        private ToolStripMenuItem FileTopMenuItem;
        private StatusStrip BottomStatusStrip;
    }
}

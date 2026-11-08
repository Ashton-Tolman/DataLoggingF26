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
            components = new System.ComponentModel.Container();
            MenuStrip = new MenuStrip();
            FileMenuStrip = new ToolStripMenuItem();
            StartStripMenuItem = new ToolStripMenuItem();
            StopStripMenuItem = new ToolStripMenuItem();
            SaveStripMenuItem = new ToolStripMenuItem();
            ExitStripMenuItem = new ToolStripMenuItem();
            OpenStripMenuItem = new ToolStripMenuItem();
            AboutStripMenuItem = new ToolStripMenuItem();
            GraphicsContextMenu = new ContextMenuStrip(components);
            StartContextMenu = new ToolStripMenuItem();
            StopContextMenu = new ToolStripMenuItem();
            SaveContextMenu = new ToolStripMenuItem();
            OpenContextMenu = new ToolStripMenuItem();
            ExitContextMenu = new ToolStripMenuItem();
            SampleRateComboBox = new ComboBox();
            GraphViewComboBox = new ComboBox();
            SaveButton = new Button();
            StopButton = new Button();
            StartButton = new Button();
            GraphPictureBox = new PictureBox();
            ADCValueLabel = new Label();
            SampleCountLabel = new Label();
            StatusStrip = new StatusStrip();
            PicStatusLabel = new ToolStripStatusLabel();
            SamplingRateStatusLabel = new ToolStripStatusLabel();
            FileStatusLabel = new ToolStripStatusLabel();
            SampleTimer = new System.Windows.Forms.Timer(components);
            ToolTip = new ToolTip(components);
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            ExitButton = new Button();
            MenuStrip.SuspendLayout();
            GraphicsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).BeginInit();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(20, 20);
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuStrip, AboutStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(8, 2, 0, 2);
            MenuStrip.Size = new Size(935, 33);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.DropDownItems.AddRange(new ToolStripItem[] { StartStripMenuItem, StopStripMenuItem, SaveStripMenuItem, ExitStripMenuItem, OpenStripMenuItem });
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(54, 29);
            FileMenuStrip.Text = "File";
            // 
            // StartStripMenuItem
            // 
            StartStripMenuItem.Name = "StartStripMenuItem";
            StartStripMenuItem.Size = new Size(158, 34);
            StartStripMenuItem.Text = "Start";
            // 
            // StopStripMenuItem
            // 
            StopStripMenuItem.Name = "StopStripMenuItem";
            StopStripMenuItem.Size = new Size(158, 34);
            StopStripMenuItem.Text = "Stop";
            // 
            // SaveStripMenuItem
            // 
            SaveStripMenuItem.Name = "SaveStripMenuItem";
            SaveStripMenuItem.Size = new Size(158, 34);
            SaveStripMenuItem.Text = "Save";
            // 
            // ExitStripMenuItem
            // 
            ExitStripMenuItem.Name = "ExitStripMenuItem";
            ExitStripMenuItem.Size = new Size(158, 34);
            ExitStripMenuItem.Text = "Exit";
            // 
            // OpenStripMenuItem
            // 
            OpenStripMenuItem.Name = "OpenStripMenuItem";
            OpenStripMenuItem.Size = new Size(158, 34);
            OpenStripMenuItem.Text = "Open";
            // 
            // AboutStripMenuItem
            // 
            AboutStripMenuItem.Name = "AboutStripMenuItem";
            AboutStripMenuItem.Size = new Size(78, 29);
            AboutStripMenuItem.Text = "About";
            // 
            // GraphicsContextMenu
            // 
            GraphicsContextMenu.ImageScalingSize = new Size(20, 20);
            GraphicsContextMenu.Items.AddRange(new ToolStripItem[] { StartContextMenu, StopContextMenu, SaveContextMenu, OpenContextMenu, ExitContextMenu });
            GraphicsContextMenu.Name = "GraphicsContextMenu";
            GraphicsContextMenu.Size = new Size(129, 164);
            // 
            // StartContextMenu
            // 
            StartContextMenu.Name = "StartContextMenu";
            StartContextMenu.Size = new Size(128, 32);
            StartContextMenu.Text = "Start";
            // 
            // StopContextMenu
            // 
            StopContextMenu.Name = "StopContextMenu";
            StopContextMenu.Size = new Size(128, 32);
            StopContextMenu.Text = "Stop";
            // 
            // SaveContextMenu
            // 
            SaveContextMenu.Name = "SaveContextMenu";
            SaveContextMenu.Size = new Size(128, 32);
            SaveContextMenu.Text = "Save";
            // 
            // OpenContextMenu
            // 
            OpenContextMenu.Name = "OpenContextMenu";
            OpenContextMenu.Size = new Size(128, 32);
            OpenContextMenu.Text = "Open";
            OpenContextMenu.Click += OpenContextMenu_Click;
            // 
            // ExitContextMenu
            // 
            ExitContextMenu.Name = "ExitContextMenu";
            ExitContextMenu.Size = new Size(128, 32);
            ExitContextMenu.Text = "Exit";
            // 
            // SampleRateComboBox
            // 
            SampleRateComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SampleRateComboBox.FormattingEnabled = true;
            SampleRateComboBox.Location = new Point(13, 37);
            SampleRateComboBox.Margin = new Padding(4);
            SampleRateComboBox.Name = "SampleRateComboBox";
            SampleRateComboBox.Size = new Size(188, 33);
            SampleRateComboBox.TabIndex = 5;
            ToolTip.SetToolTip(SampleRateComboBox, "Select sampling rate");
            // 
            // GraphViewComboBox
            // 
            GraphViewComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GraphViewComboBox.FormattingEnabled = true;
            GraphViewComboBox.Location = new Point(13, 79);
            GraphViewComboBox.Margin = new Padding(4);
            GraphViewComboBox.Name = "GraphViewComboBox";
            GraphViewComboBox.Size = new Size(188, 33);
            GraphViewComboBox.TabIndex = 6;
            ToolTip.SetToolTip(GraphViewComboBox, "Select graph view");
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(646, 461);
            SaveButton.Margin = new Padding(4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(131, 64);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Save";
            ToolTip.SetToolTip(SaveButton, "Save collected data");
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // StopButton
            // 
            StopButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StopButton.Location = new Point(507, 461);
            StopButton.Margin = new Padding(4);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(131, 64);
            StopButton.TabIndex = 2;
            StopButton.Text = "Stop";
            ToolTip.SetToolTip(StopButton, "Stop collecting ADC data");
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // StartButton
            // 
            StartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StartButton.Location = new Point(369, 461);
            StartButton.Margin = new Padding(4);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(131, 64);
            StartButton.TabIndex = 1;
            StartButton.Text = "Start";
            ToolTip.SetToolTip(StartButton, "Start collecting ADC data");
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // GraphPictureBox
            // 
            GraphPictureBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GraphPictureBox.BackColor = SystemColors.WindowText;
            GraphPictureBox.Location = new Point(209, 37);
            GraphPictureBox.Margin = new Padding(4);
            GraphPictureBox.Name = "GraphPictureBox";
            GraphPictureBox.Size = new Size(707, 416);
            GraphPictureBox.TabIndex = 7;
            GraphPictureBox.TabStop = false;
            ToolTip.SetToolTip(GraphPictureBox, "Displays recorded ADC values");
            // 
            // ADCValueLabel
            // 
            ADCValueLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADCValueLabel.AutoSize = true;
            ADCValueLabel.Location = new Point(13, 132);
            ADCValueLabel.Margin = new Padding(4, 0, 4, 0);
            ADCValueLabel.Name = "ADCValueLabel";
            ADCValueLabel.Size = new Size(154, 25);
            ADCValueLabel.TabIndex = 7;
            ADCValueLabel.Text = "Lastest ADC Value";
            // 
            // SampleCountLabel
            // 
            SampleCountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SampleCountLabel.AutoSize = true;
            SampleCountLabel.Location = new Point(13, 169);
            SampleCountLabel.Margin = new Padding(4, 0, 4, 0);
            SampleCountLabel.Name = "SampleCountLabel";
            SampleCountLabel.Size = new Size(174, 25);
            SampleCountLabel.TabIndex = 8;
            SampleCountLabel.Text = "Number Of Samples";
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(20, 20);
            StatusStrip.Items.AddRange(new ToolStripItem[] { PicStatusLabel, SamplingRateStatusLabel, FileStatusLabel });
            StatusStrip.Location = new Point(0, 530);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Padding = new Padding(1, 0, 18, 0);
            StatusStrip.Size = new Size(935, 32);
            StatusStrip.TabIndex = 10;
            StatusStrip.Text = "statusStrip1";
            // 
            // PicStatusLabel
            // 
            PicStatusLabel.Name = "PicStatusLabel";
            PicStatusLabel.Size = new Size(143, 25);
            PicStatusLabel.Text = "COM Port Status";
            // 
            // SamplingRateStatusLabel
            // 
            SamplingRateStatusLabel.Name = "SamplingRateStatusLabel";
            SamplingRateStatusLabel.Size = new Size(127, 25);
            SamplingRateStatusLabel.Text = "Sampling Rate";
            // 
            // FileStatusLabel
            // 
            FileStatusLabel.Name = "FileStatusLabel";
            FileStatusLabel.Size = new Size(180, 25);
            FileStatusLabel.Text = "Current Log Filename";
            // 
            // SampleTimer
            // 
            SampleTimer.Tick += SampleTimer_Tick;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.Location = new Point(785, 461);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(131, 64);
            ExitButton.TabIndex = 4;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DataLoggingF26Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 562);
            Controls.Add(ExitButton);
            Controls.Add(StatusStrip);
            Controls.Add(SampleCountLabel);
            Controls.Add(ADCValueLabel);
            Controls.Add(GraphPictureBox);
            Controls.Add(StartButton);
            Controls.Add(StopButton);
            Controls.Add(SaveButton);
            Controls.Add(GraphViewComboBox);
            Controls.Add(SampleRateComboBox);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            Name = "DataLoggingF26Form";
            Text = "DataLoggerForm";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            GraphicsContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GraphPictureBox).EndInit();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip MenuStrip;
        private ContextMenuStrip GraphicsContextMenu;
        private ComboBox SampleRateComboBox;
        private ComboBox GraphViewComboBox;
        private Button SaveButton;
        private Button StopButton;
        private Button StartButton;
        private PictureBox GraphPictureBox;
        private Label ADCValueLabel;
        private Label SampleCountLabel;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel PicStatusLabel;
        private ToolStripStatusLabel SamplingRateStatusLabel;
        private ToolStripStatusLabel FileStatusLabel;
        private System.Windows.Forms.Timer SampleTimer;
        private ToolTip ToolTip;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private Button ExitButton;
        private ToolStripMenuItem FileMenuStrip;
        private ToolStripMenuItem AboutStripMenuItem;
        private ToolStripMenuItem StartContextMenu;
        private ToolStripMenuItem StopContextMenu;
        private ToolStripMenuItem SaveContextMenu;
        private ToolStripMenuItem OpenContextMenu;
        private ToolStripMenuItem ExitContextMenu;
        private ToolStripMenuItem StartStripMenuItem;
        private ToolStripMenuItem StopStripMenuItem;
        private ToolStripMenuItem SaveStripMenuItem;
        private ToolStripMenuItem ExitStripMenuItem;
        private ToolStripMenuItem OpenStripMenuItem;
    }
}

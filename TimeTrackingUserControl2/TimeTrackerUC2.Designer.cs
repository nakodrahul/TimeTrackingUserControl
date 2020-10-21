namespace TimeTrackingUserControl2
{
    partial class TimeTrackerUC2
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
            this.ModeComboBox = new System.Windows.Forms.ComboBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ModeComboBox
            // 
            this.ModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModeComboBox.FormattingEnabled = true;
            this.ModeComboBox.Items.AddRange(new object[] {
            "Draw",
            "BackCheck"});
            this.ModeComboBox.Location = new System.Drawing.Point(61, 27);
            this.ModeComboBox.Name = "ModeComboBox";
            this.ModeComboBox.Size = new System.Drawing.Size(230, 24);
            this.ModeComboBox.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.BackgroundImage = global::TimeTrackingUserControl2.Properties.Resources.StartButton1;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.Location = new System.Drawing.Point(61, 95);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(115, 49);
            this.StartButton.TabIndex = 1;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = global::TimeTrackingUserControl2.Properties.Resources.stopImg;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.Location = new System.Drawing.Point(189, 95);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(111, 49);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // TimeTrackerUC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ModeComboBox);
            this.Name = "TimeTrackerUC2";
            this.Size = new System.Drawing.Size(357, 189);
            this.Load += new System.EventHandler(this.TimeTrackerUC2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ModeComboBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
    }
}

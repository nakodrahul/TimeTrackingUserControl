namespace TestTimeTrackingUserControl
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTrackerUC21 = new TestTimeTrackingUserControl.TimeTrackerUC2();
            this.SuspendLayout();
            // 
            // timeTrackerUC21
            // 
            this.timeTrackerUC21.Location = new System.Drawing.Point(155, 96);
            this.timeTrackerUC21.Name = "timeTrackerUC21";
            this.timeTrackerUC21.Size = new System.Drawing.Size(357, 189);
            this.timeTrackerUC21.TabIndex = 0;
            this.timeTrackerUC21.Load += new System.EventHandler(this.timeTrackerUC21_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeTrackerUC21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TimeTrackerUC2 timeTrackerUC21;
    }
}


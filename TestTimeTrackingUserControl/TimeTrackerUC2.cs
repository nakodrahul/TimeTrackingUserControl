using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackingUserControl2;

namespace TestTimeTrackingUserControl
{/// <summary>
/// This class contains constructor to set some default properties and to initialize class
/// and two methods StartButton_Click() and StopButton_Click() to work accordingly
/// </summary>
    public partial class TimeTrackerUC2 : UserControl
    {
        DateTime startTime;
            

        /// <summary>
        /// Constructor used to initialize variables and set default properties
        /// </summary>
        public TimeTrackerUC2()
        {
            InitializeComponent();
            StopButton.Enabled = false;           
            ModeComboBox.SelectedIndex = 0;
        }

       [Category("Identity")]
       [Description("Sets the value for Elevation ID")]
        public int ElevationId { get; set; }
        
        [Category("Identity")]
        [Description("Sets the value for Fabsheet Id")]
        public int FabSheetId { get; set; }


        /// <summary>
        /// Method checks status of start button and enables or disables stop button and combo box 
        /// wherever required
        /// </summary>
        private void CheckStartStop()
        {
            if (StartButton.Enabled == false)
            {
                StopButton.Enabled = true;
                ModeComboBox.Enabled = false;
            }
            else
            {
                StopButton.Enabled = false;
                ModeComboBox.Enabled = true;
            }
        }

        /// <summary>
        /// Method invokes on clicking start button used to catch the start time,
        /// and set enable property of button on clicking 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            //enabling stop button and disabling start button on clicking start button
            StartButton.Enabled = false;
            
            CheckStartStop();

            //catching start time
            startTime = DateTime.Now;
                                                      
        }
        /// <summary>
        /// this method invokes on cliking stop button to insert given values in database
        /// </summary>
        /// <param name="sender">default parameters</param>
        /// <param name="e">default parameters</param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            //enabling start button and disabling stop button on clicking stop button
            StartButton.Enabled = true;
            
            CheckStartStop();

            TimeTrackingUCClass ttuclassObj = new TimeTrackingUCClass();

            
            string mode = ModeComboBox.Text;
            string userName = Environment.MachineName + "\\" + SystemInformation.UserName;
           DateTime endTime = DateTime.Now;
            TimeSpan span = endTime - startTime;
            double spanDuration = Convert.ToInt64(span.TotalSeconds);

            ttuclassObj.OnStopButton(ElevationId, FabSheetId, mode, startTime, endTime, spanDuration, userName);
        }
        private void TimeTrackerUC2_Load(object sender, EventArgs e)
        {

        }
    }
}

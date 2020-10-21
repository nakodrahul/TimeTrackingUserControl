using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace TimeTrackingUserControl2
{
    public class TimeTrackingUCClass
    {
        string sqlQuery;

        /// <summary>
        /// class contains constructor to initialize variables and two methods fillDataSet()method is to fill dataset 
        /// and another OnStopButton() is to insert data into database
        /// </summary>
        public TimeTrackingUCClass()
        {
            sqlQuery = "INSERT INTO ProjectTime VALUES (@ElevationId,@FabSheetId,@Mode,@StartTime,@EndTime,@Duration,@UserName)";

        }
        private bool ValidateStrings(string mode) 
        {
            if (mode == null)
            {
                return false;
            }
            else
                return true;
        }
        private bool ValidateDate(DateTime startDate)
        {
            if (startDate == null && startDate!=new DateTime())
            {
                return false;
            }
            else
                return true;
        }
        
        private bool ValidateDoubles(Double spanDuration)
        {
            if (spanDuration==0)
            {
                return false;
            }
            else
                return true;
        }
        
        /// <summary>
        /// method invokes at the time when stop button is clicked and values get inserted in db
        /// first it checks for null if any of the passed values is null then it will return 
        /// else inserts passed values in db. 
        /// </summary>
        /// <param name="mode">selected value from combo box</param>
        /// <param name="start">time at which start button getting called</param>
        /// <param name="end">time at which stop button getting called</param>
        /// <param name="span">Duration between start time and end time</param>
        /// <param name="user1">value for user field</param>
        public void OnStopButton(int elevationId,int fabSheetId,string mode, DateTime startTime, DateTime endTime, double spanDuration,string userName)
        {
            
            if (ValidateStrings(mode) == false)
            {
                throw new ArgumentException("{0} value you passed is not appropriate, null value cannot be accepted here",mode);
            }
            else if (ValidateDate(startTime) == false)
            {
                throw new ArgumentException("{0} value you passed is not appropriate, It should not be null or default date", startTime.ToString());
            }
            else if (ValidateDate(endTime) == false)
            {
                throw new ArgumentException("{0} value you passed is not appropriate, It should not be null or default date", endTime.ToString());
            }
            else if (ValidateStrings(userName) == false)
            {
                throw new ArgumentException("User {0} should not be null",userName);
            }
            else if (ValidateDoubles(spanDuration) == false)
            {
                throw new ArgumentException("Duration cannot be zero");
            }
            else 
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.connection);
                SqlCommand command = new SqlCommand(sqlQuery, connection);
           
                command.Parameters.Clear();
                command.Parameters.AddWithValue("ElevationId", elevationId);
                command.Parameters.AddWithValue("FabSheetId", fabSheetId);
                command.Parameters.AddWithValue("Mode", mode);
                command.Parameters.AddWithValue("StartTime", startTime);
                command.Parameters.AddWithValue("EndTime", endTime);
                command.Parameters.AddWithValue("Duration", spanDuration);
                command.Parameters.AddWithValue("UserName", userName);
                try
                {
                    using (connection) 
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    
                    
                }
                catch (Exception e)
                {
                    //throwing back the exception to the calling function
                    throw e;
                }
                finally
                {
                    // closing connection 
                    connection.Close();
                }
            }
                        
        }

    }
}

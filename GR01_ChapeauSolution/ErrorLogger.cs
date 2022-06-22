using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChapeauUI
{
    public class ErrorLogger
    {
        // Unique ErrorLogger
        private static ErrorLogger uniqueInstance; 
    
        // Constructor
        private ErrorLogger() { }

        // Static method that delivers an unique instance
        public static ErrorLogger GetInstance()
        {
            // If an instance doesn't exist
            if (uniqueInstance == null)
            {
                // Create new ErrorLogger
                uniqueInstance = new ErrorLogger();
            }

            // Return the instance
            return uniqueInstance;
        }

        // Save Error with file path return
        public string LogError(Exception ex)
        {
            //Get file path to save to Log.txt
            string writePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string filePath = Path.Combine(writePath, "Log.txt");

            // Write data to Log file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Date of error
                writer.WriteLine(DateTime.Now);
                // Display error
                writer.WriteLine($"An error occured: {ex.Message}");
                // Display technical error
                writer.WriteLine(ex.StackTrace);
                // Spacing
                writer.WriteLine("---------");

                // Close writer
                writer.Close();
            }

            // Return location of saved log
            return filePath;
        }        
    }
}

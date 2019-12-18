using System.Reflection;
using System.IO; 
using System;
using System.Text;

namespace ExceptionHandler
{
    /// <summary>
    /// LogDevice enumeration which provides platform to store log.
    /// </summary>
    public enum LogDevice
    {
        /// <summary>
        /// Appends log to text file.
        /// </summary>
        TextFile,
        /// <summary>
        /// Appends log to database
        /// </summary>
        Database
    }

    /// <summary>
    /// This class is responsible to handle exception thrown by the application. Most of the 
    /// exception are handled through this class except system exception. It handles the exception
    /// and creates the log.
    /// </summary>
    public class ExceptionProvider : IDisposable
    {
        private string logFileName = string.Empty;
        Type dbClassType = null;
        private string dbSaveLogMethodName = string.Empty;

        /// <summary>
        /// Name of the text log file.
        /// </summary>
        public string LogFileName
        {
            get { return logFileName; }
            set { logFileName = value; }
        }

        /// <summary>
        /// The type of class from where you specify save method to store exception
        /// into database. This method is lately binding because we can use different database connection
        /// logic into save method. It is required, if you use LogDevice as Database.
        /// </summary>
        public Type DbClassType
        {
            get { return dbClassType; }
            set { dbClassType = value; }
        }

        /// <summary>
        /// Then name of method which is used to save exception into database. It is required if you, 
        /// use LogDevice as Database. This method must have the Exception object as parameter.
        /// </summary>
        public string DbSaveLogMethodName
        {
            get { return dbSaveLogMethodName; }
            set { dbSaveLogMethodName = value; }
        }

        public ExceptionProvider()
        { }

        public ExceptionProvider(string logFileName)
        {
            this.logFileName = logFileName;
        }

        /// <summary>
        /// This method is used to append log into specified log device.
        /// </summary>
        /// <param name="device">Devicetype i.e.(TextFile, Database)</param>
        /// <param name="ex">Exception object</param>
        public void AppendLog(LogDevice device, Exception ex)
        {
            //Writes the log into database only.
            if (device == LogDevice.Database)
            {
                if (dbClassType == null)
                {
                    throw new ArgumentNullException("Type of class should be mentioned while working with Database device type.");
                }

                ExecuteMethod(dbClassType, dbSaveLogMethodName, new object[] { ex });
            }
            //Writes the log into text file only.
            else if (device == LogDevice.TextFile)
            {
                if (string.IsNullOrEmpty(logFileName))
                {
                    throw new ArgumentNullException("Log file name should be mentioned while working with TextFile device type.");
                }

                SaveLogToTextFile(ex);
            }
        }

        /// <summary>
        /// Executes the method mentioned in the class. It is specially designed to execute
        /// save to database method in the mentioned class.
        /// </summary>
        /// <param name="classType">Type of class where the save method is declared.</param>
        /// <param name="methodName">Name of the method which saves the log into database</param>
        /// <param name="args"></param>
        private void ExecuteMethod(Type classType, string methodName, object[] args)
        {
            //Declaration of the class object which returns the instance of the class where the save 
            //to database method is declared.
            object objClass = null;
            //Declaration of the Method Info which returns the method information from above class.
            MethodInfo mInfo = null;
            try
            {
                //Creates the instance of the class where the save to database is declared.
                objClass = Activator.CreateInstance(classType);
                //Returns the information of the method.
                mInfo = classType.GetMethod(methodName);
                //invokes the specified method and saves the error log to database.
                mInfo.Invoke(objClass, args);
            }
            catch (Exception ex)
            {
                if (mInfo != null)
                {
                    //Appends the log to text file because there is error while inserting into database.
                    AppendLog(LogDevice.TextFile, ex);
                }
            }
            finally
            {
                objClass = null;
                mInfo = null;
            }
        }

        /// <summary>
        /// Creates the error message data and appends to textfile.
        /// </summary>
        /// <param name="ex">Exception object which is thrown</param>
        
        //private void SaveLogToTextFile(Exception exception)
        //{
        //    string primaryMsg = exception.Message;
        //    Error objError = null;
        //    ErrorService objErrorService = new ErrorService();          
        //    Exception ex = exception.InnerException != null ? exception.InnerException : exception;
        //    using (StreamWriter writer = new StreamWriter(logFileName, true))
        //    {
        //        Type type = ex.GetType();                
        //        StringBuilder builder = new StringBuilder();
        //        string errCode = string.Empty;
        //        string errType = string.Empty;
        //        builder.AppendLine("------------------------------------");
        //        builder.AppendLine(string.Format("Timestamp: {0}", DateTime.Now));
        //        builder.AppendLine(string.Format("An exception of type \"{0}\" occured and was caught.", type.FullName));        
        //        builder.AppendLine();
        //        errType = GetExceptionLevel(ex, out errCode);               
        //        if (errCode == String.Empty)
        //        {
        //            errCode = ErrorMap.getValue(ex.Message.ToString(), ErrorMap.listErrorMap());
        //        }
        //        if (errCode == String.Empty)
        //        {
        //            objError = objErrorService.Error_Get(int.Parse(errCode));
        //        }
        //        if (objError != null)
        //        {
        //            builder.AppendLine(string.Format("Type: {0}", GetExceptionType(objError.ErrorType)));
        //            builder.AppendLine(string.Format(objError.ErrorTitle));                    
        //            builder.AppendLine(string.Format(objError.ErrorDesc));                    
        //        }
        //        else
        //        {
        //            builder.AppendLine(string.Format("Type: {0}", errType));                   
        //            builder.AppendLine(string.Format("Error")); 
        //            builder.AppendLine(string.Format(ex.Message));                  
        //        }
        //        builder.AppendLine("------------------------------------");
        //        builder.AppendLine();
        //        writer.WriteLine(builder.ToString());
        //    }
        //}

        private void SaveLogToTextFile(Exception exception)
        {
            string primaryMsg = exception.Message;

            Exception ex = exception.InnerException != null ? exception.InnerException : exception;
            using (StreamWriter writer = new StreamWriter(logFileName, true))
            {
                Type type = ex.GetType();
                StringBuilder builder = new StringBuilder();
                builder.AppendLine("------------------------------------");
                builder.AppendLine(string.Format("Timestamp: {0}", DateTime.Now));
                builder.AppendLine(string.Format("An exception of type \"{0}\" occured and was caught.", type.FullName));
                builder.AppendLine("------------------------------------");
                builder.AppendLine();
                string errCode = string.Empty;
                builder.AppendLine(string.Format("Error Level: {0}", GetExceptionLevel(ex, out errCode)));
                builder.AppendLine(string.Format("Type: {0}", type.AssemblyQualifiedName));
                if (!string.IsNullOrEmpty(errCode))
                {
                    builder.AppendLine(string.Format("Error Code: {0}", errCode));
                }
                //builder.AppendLine(string.Format("Primary Message: {0}", primaryMsg));
                builder.AppendLine(string.Format("Message: {0}", ex.Message));
                builder.AppendLine(string.Format("Source: {0}", ex.Source));
                builder.AppendLine(string.Format("Help Link: {0}", ex.HelpLink));
                builder.AppendLine(string.Format("Target Site: {0}", ex.TargetSite));
                builder.AppendLine(string.Format("Stack Trace: {0}", ex.StackTrace));
                builder.AppendLine();

                writer.WriteLine(builder.ToString());
            }
        }

        /// <summary>
        /// Filteres the error lavel for identifying what type of error is occured.
        /// </summary>
        /// <param name="ex">Exception object which is thrown</param>
        /// <returns></returns>
        private string GetExceptionLevel(Exception ex, out string errorCode)
        {
            errorCode = string.Empty;
            switch (ex.GetType().Name)
            { 
                case "ValidationException":
                    return "Validation Level";
                case "SecurityException":
                    return "Security Level";
                default:
                    return "Application Level";
            }
        }

        public string GetExceptionType(string errorType)
        {
            switch (errorType)
            {
                case "2":                 
                    return "Database Level";
                case "3":
                    return "Validation Level";
                case "4":
                    return "Security Level";
                default:
                    return "Application Level";
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            logFileName = string.Empty;
            dbClassType = null;
        }

        #endregion
    }
}

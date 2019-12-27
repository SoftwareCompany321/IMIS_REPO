using System;
using System.Linq;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Web;
using System.Reflection;
using System.IO;
using App.Web;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http.Headers;

namespace IMIS_CORE.Core
{

    public static partial class Utils
    {

        /// <summary>
        /// extention function that converts object to string
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>string</returns>
        public static string ConvertToString(this object obj)
        {
            if (obj == null || obj == DBNull.Value)
                return "";
            return obj.ToString().Trim();
        }

        /// <summary>
        /// Extention function that converts object to int32
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Int number</returns>
        public static int ToInt32(this object obj)
        {
            int val = 0;
            int.TryParse(obj.ConvertToString(), out val);
            return val;
        }

        public static float ToFloat(this object obj)
        {
            float val = 0;
            float.TryParse(obj.ConvertToString(), out val);
            return val;
        }
        public static bool ToBooleanYN(this object obj)
        {
            bool val = false;
            if (obj.ConvertToString() == "Y")
            {
                val = true;
            };
            return val;
        }

        public static bool ToBoolean(this object obj)
        {
            bool val = false;
            bool.TryParse(obj.ConvertToString(), out val);
            return val;
        }

        /// <summary>
        /// Extention function that converts object to int64
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>Int number</returns>
        public static Int64 ToInt64(this object obj)
        {
            Int64 val = 0;
            Int64.TryParse(obj.ConvertToString(), out val);
            return val;
        }

        /// <summary>
        /// Extention function that finds out if the type is int type
        /// </summary>
        /// <param name="type">Type of object</param>
        /// <returns>True if onverted </returns>
        public static bool IsNumeric(this Type type)
        {
            return (type == typeof(Int16) || type == typeof(Int32) || type == typeof(Int64) || type == typeof(Decimal) || type == typeof(Double));

        }

        public static string DbDateFormat
        {
            get
            {
                return "";// ConfigurationManager.AppSettings["DateFormat"].ToString();
            }
        }
        public static DateTime ToDateTime(this object obj, string format)
        {
            format = format ?? Utils.DbDateFormat;

            DateTimeFormatInfo dtf = new DateTimeFormatInfo();
            dtf.ShortDatePattern = format;
            return Convert.ToDateTime(obj, dtf);
        }

        public static DateTime? ToDateTime(this object obj)
        {
            DateTimeFormatInfo dtf = new DateTimeFormatInfo();
            dtf.ShortDatePattern = Utils.DbDateFormat;
            try
            {
                return Convert.ToDateTime(obj, dtf);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Extention function that check boolean and returns Y or N
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="inMode">True/fales</param>
        /// <returns>String</returns>
        public static string ToSTBoolean(this object obj, Boolean inMode)
        {
            return ((obj.ConvertToString().Trim() != string.Empty) &&
                (obj.ConvertToString().Trim() != "N") ? "Y" : (inMode ? "N" : null));
        }

        /// <summary>
        /// Extention function that check boolean and returns Y or N
        /// </summary>
        /// <param name="obj">Object</param>
        /// <param name="inMode">True/fales</param>
        /// <returns>String</returns>
        public static string ToYNBoolean(this object obj, Boolean inMode)
        {
            return ((obj.ConvertToString().Trim() != string.Empty) &&
                (obj.ConvertToString().Trim().ToLower() != "false") ? "Y" : (inMode ? "N" : null));
        }

        /// <summary>
        /// Converts an object to decimal
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <returns>Returns decimal.</returns>
        public static Decimal? ToDecimal(this object obj)
        {
            if (obj == null || obj == DBNull.Value)
                return null;
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// Converts an object to decimal with povided decimal place
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <param name="decimalPlace">Decimal place</param>
        /// <returns>Returns decimal with povided decimal place.</returns>
        public static Decimal? ToDecimal(this object obj, int decimalPlace)
        {
            if (obj == null || obj == DBNull.Value)
                return null;
            try
            {
                return Math.Round(Convert.ToDecimal(obj), decimalPlace);
            }
            catch
            {
                return null;
            }
        }

        //to get ApplicationPath
        public static string GetApplicationRoot()
        {
            var exePath = Path.GetDirectoryName(System.Reflection
                              .Assembly.GetExecutingAssembly().CodeBase);
            //Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:/+[\S\s]*?(?=/+bin)");
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            var appRoot = appPathMatcher.Match(exePath).Value;
            return appRoot;
        }
        /// <summary>
        /// extention function that Get Unicode toggle words from excel sheet
        /// </summary> 
        /// <returns></returns>
        public static void GetLanguageList()
        {
            DataTable dt = new DataTable();
            dt = getUnicodedataTable();
            if (dt != null)
            {
                AppHttpContext.Current.Session.Set("UnicodeWords", SerializeData(dt)); 
            }
            else
            {
                AppHttpContext.Current.Session.Set("UnicodeWords", null);
            }

        }

        private static DataTable getUnicodedataTable()
        {
            var buildDir = GetApplicationRoot();
            //string filepath = System.IO.Path.GetFullPath(buildDir + @"Unicode/unicodexml.xml");

            string filepath = System.IO.Path.GetFullPath(buildDir + @"\Unicode\unicodexml.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(filepath);
            DataTable dtRes = new DataTable();
            if (ds.Tables[0] != null)
            {

            }
            dtRes = ds.Tables[0];
            return dtRes;
        }
        private static byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
        /// <summary>
        /// Get Label name according to language setting
        /// </summary> 
        ///<param name="LabelName"></param>
        /// <returns>string</returns>
        public static string GetLabel(string labelName)
        {
            //labelName = labelName.ToUpper();
            if (!String.IsNullOrEmpty(labelName))
            {
                
                DataTable dtUnicode = null;
                string sessionLanguage = "English";
                if (AppHttpContext.Current.Session.GetString("LanguageSetting") != null)
                    sessionLanguage = AppHttpContext.Current.Session.GetString("LanguageSetting");
                else
                    AppHttpContext.Current.Session.SetString("LanguageSetting", "English"); 

                Byte[] retValue;
                if (AppHttpContext.Current.Session.TryGetValue("UnicodeWords", out retValue))
                    dtUnicode = (DataTable)ByteArrayToObject(retValue);

                if (sessionLanguage != "English")
                {
                    if (dtUnicode != null)
                    {
                        var drNepaliLabel = dtUnicode.AsEnumerable().Where(s => s.Field<string>("A") == labelName.ToUpper());
                        foreach (var dr in drNepaliLabel)
                        {
                            labelName = (dr["B"] == null) ? labelName : dr["B"].ToString();
                        }
                        //labelName = labelName.Replace("0", "०").Replace("1", "१").Replace("2", "२").Replace("3", "३").Replace("4", "४").Replace("5", "५").Replace("6", "६").Replace("7", "७").Replace("8", "८").Replace("9", "९");
                    }
                }
            }
            return labelName;
        }
        /// <summary>
        /// Get number according to language setting
        /// </summary> 
        ///<param name="number"></param>
        /// <returns>string</returns>
        public static string GetNumber(string number)
        {
            string newVal = "";
            foreach (char c in number)
            {
                newVal += GetLabel(c.ToString());
            }
            if (newVal != "")
                number = newVal;
            return number;
        }

        /// <summary>
        /// Get Label with alternate language of session
        /// </summary>
        /// <param name="LabelName"></param>
        /// <returns>string</returns>
        public static string GetAlternateLabel(string labelName)
        {
           
            DataTable dtUnicode = null;
            labelName = labelName.ToUpper();
            string sessionLanguage = "English";
            if (AppHttpContext.Current.Session.GetString("LanguageSetting") != null)
                sessionLanguage = AppHttpContext.Current.Session.GetString("LanguageSetting");
            else
                AppHttpContext.Current.Session.SetString("LanguageSetting", "English");
             
            Byte[] retValue;
            if (AppHttpContext.Current.Session.TryGetValue("UnicodeWords", out retValue))
                dtUnicode = (DataTable)ByteArrayToObject(retValue);
           if(dtUnicode==null)
            {
                GetLanguageList();
                dtUnicode = getUnicodedataTable();
            } 
            if (sessionLanguage == "English")
            {
                var drNepaliLabel = dtUnicode.AsEnumerable().Where(s => s.Field<string>("A") == labelName);
                foreach (var dr in drNepaliLabel)
                {
                    labelName = (dr["B"] == null) ? labelName : dr["B"].ToString();
                }
            }
            return labelName;
        }

        /// <summary>
        /// Toggle data from database according to session language
        /// </summary>
        /// <param name="ENG"></param>
        /// <param name="LOC"></param>
        /// <returns>string</returns>
        public static string ToggleLanguage(string DESC_ENG, string DESC_LOC)
        {
            string sessionLanguage = "English";
            if (AppHttpContext.Current.Session.GetString("LanguageSetting") != null)
                sessionLanguage = AppHttpContext.Current.Session.GetString("LanguageSetting");
            else
                AppHttpContext.Current.Session.SetString("LanguageSetting", "English");
            if (sessionLanguage == "English")
            {
                return DESC_ENG;
            }
            else
            {
                return DESC_LOC;
            }
        }

        /// <summary>
        /// Change Session Language
        /// </summary> 
        /// <returns>string</returns>
        public static string Changelanguage()
        {
            string strLabel = "";
            string sessionLanguage = "English";
            if (AppHttpContext.Current.Session.GetString("LanguageSetting") != null)
                sessionLanguage = AppHttpContext.Current.Session.GetString("LanguageSetting");
            else
                AppHttpContext.Current.Session.SetString("LanguageSetting", "English");
            if (sessionLanguage == "English")
            {
                strLabel = GetAlternateLabel("In Nepali");

            }
            else
            {
                strLabel = "In English";
            }
            return strLabel;
        }

        public static bool ConvertBoolean(this object obj)
        {
            //string st = "";
            if (obj == null || obj == DBNull.Value)
            {
                return false;
            }
            else
            {
                if (obj.ConvertToString() == "N")
                    return false;
                else if (obj.ConvertToString() == "Y")
                    return true;
            }
            return false;
            //return obj.ToString().Trim();
            //return st; 
        }

        #region Unused Function
        public static string ConvertAsciiToUnicode(string asciiString)
        {
            // Create two different encodings.
            Encoding encAscii = Encoding.ASCII;
            Encoding encUnicode = Encoding.Unicode;

            // Convert the string into a byte[].
            byte[] asciiBytes = encAscii.GetBytes(asciiString);

            // Perform the conversion from one encoding to the other.
            byte[] unicodeBytes = Encoding.Convert(encAscii, encUnicode, asciiBytes);

            // Convert the new byte[] into a char[] and then into a string.
            // This is a slightly different approach to converting to illustrate
            // the use of GetCharCount/GetChars.
            char[] unicodeChars = new char[encUnicode.GetCharCount(unicodeBytes, 0, unicodeBytes.Length)];
            encUnicode.GetChars(unicodeBytes, 0, unicodeBytes.Length, unicodeChars, 0);
            string unicodeString = new string(unicodeChars);

            // Return the new unicode string
            return unicodeString;
        }
        public static string UTF8toASCII(string text)
        {
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            Byte[] encodedBytes = utf8.GetBytes(text);
            Byte[] convertedBytes =
                    Encoding.Convert(Encoding.UTF8, Encoding.ASCII, encodedBytes);
            System.Text.Encoding ascii = System.Text.Encoding.ASCII;

            string str = ascii.GetString(convertedBytes);
            return str;
        }
        public static string ConvertUnicodeToAscii(string unicodeString)
        {
            //string test = "abc pi(\\u0915)";
            // Create two different encodings.
            Encoding encAscii = Encoding.ASCII;
            Encoding encUnicode = Encoding.Unicode;

            // Convert the string into a byte[].
            byte[] unicodeBytes = encUnicode.GetBytes(unicodeString);

            // Perform the conversion from one encoding to the other.
            byte[] asciiBytes = Encoding.Convert(encUnicode, encAscii, unicodeBytes);

            // Convert the new byte[] into a char[] and then into a string.
            // This is a slightly different approach to converting to illustrate
            // the use of GetCharCount/GetChars.
            char[] asciiChars = new char[encAscii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
            encAscii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
            string asciiString = new string(asciiChars);

            // Return the new ascii string
            return asciiString;
        }
        #endregion

        /// <summary>
        /// Convert HTML entity to Unicode character
        /// </summary>
        /// <param name="Html entity"></param> 
        /// <returns>string</returns>
        public static string HTMLToUnicode(string text)
        {

            string[] strTotalword = text.Split(',');
            string unicodeString = "";
            StringBuilder str = new StringBuilder();
            foreach (string strPartial in strTotalword)
            {
                if (strPartial != "")
                {
                    string codePoint = (Convert.ToInt32(strPartial)).ToString("x4");
                    int code = int.Parse(codePoint, System.Globalization.NumberStyles.HexNumber);
                    unicodeString = char.ConvertFromUtf32(code).ToString();
                    str.Append(unicodeString);
                }
            }
            unicodeString = str.ToString();
            return unicodeString;
        }


        ///// <summary>
        ///// Set Url for current page
        ///// </summary>
        ///// <param name="Url Helper"></param> 
        ///// <returns></returns>
        //public static void setUrl(this UrlHelper urlHelper)
        //{
        //    var routeValueDictionary = urlHelper.RequestContext.RouteData.Values;
        //    var rootUrl = urlHelper.Content("~/");
        //    string.Format("{0}{1}/{2}/", rootUrl, routeValueDictionary["controller"], routeValueDictionary["action"]);
        //    if (CommonVariables.currentAction != routeValueDictionary["action"].ToString() || CommonVariables.currentController != routeValueDictionary["controller"].ToString())
        //    {
        //        CommonVariables.currentAction = routeValueDictionary["action"].ToString();
        //        CommonVariables.currentController = routeValueDictionary["controller"].ToString();

        //        CommonVariables.SearchGroupCode = string.Empty;
        //        CommonVariables.SearchLoginName = string.Empty;
        //        CommonVariables.SearchUserName = string.Empty;
        //    }
        //}

        /// <summary>
        /// Encrypt password 
        /// </summary>
        /// <param name="string Message"></param> 
        /// <returns>String</returns>
        public static string EncryptString(string Message)
        {
            string Passphrase = "Secure";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            // Step 3. Setup the encoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            // Step 4. Convert the input string to a byte[]
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            // Step 5. Attempt to encrypt the string
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);

            }
            finally
            {                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            // Step 6. Return the encrypted string as a base64 encoded string
            return Convert.ToBase64String(Results);
        }

        /// <summary>
        /// Decrypt Password
        /// </summary>
        /// <param name="String Message"></param>
        /// <param name="LOC"></param>
        /// <returns>string</returns>
        public static string DecryptString(string Message)
        {
            string Passphrase = "Secure";
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            // Step 1. We hash the passphrase using MD5
            // We use the MD5 hash generator as the result is a 128 bit byte array
            // which is a valid length for the TripleDES encoder we use below
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(Passphrase));
            // Step 2. Create a new TripleDESCryptoServiceProvider object
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            // Step 3. Setup the decoder
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            // Step 4. Convert the input string to a byte[]
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            // Step 5. Attempt to decrypt the string
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                // Clear the TripleDes and Hashprovider services of any sensitive information
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            // Step 6. Return the decrypted string in UTF8 format
            return UTF8.GetString(Results);

        }

        public static bool IsNumeric(this object obj)
        {
            decimal result = 0;
            return decimal.TryParse(obj.ConvertToString(), out result);
        }

        public static bool IsDate(this object obj)
        {
            DateTime dt;
            return DateTime.TryParse(obj.ConvertToString(), out dt);
        }


        /// <summary>
        /// Converts an object to string in formatted form. 
        /// For example: ConvertToString("N2") returns an object to string
        /// with 2 decimal places. It formats an object only if they
        /// are is correct format and convertible to target type.
        /// </summary>
        /// <param name="obj">Object to be converted</param>
        /// <param name="format">Format string i.e. N2, D2, dd/MM/yyyy etc.</param>
        /// <returns>Returns formatted string.</returns>
        public static string ConvertToString(this object obj, string format)
        {
            if (obj == null || obj == DBNull.Value)
                return string.Empty;

            return string.Format("{0:" + format + "}", obj);
        }

        /// <summary>
        /// Fixes the single quotes in the string
        /// </summary>
        /// <param name="obj">String to be fixed</param>
        /// <returns>Returns the fixed string</returns>
        public static string FixQuote(this string obj)
        {
            if (obj == null)
                return string.Empty;

            string fixedName = string.Empty;
            fixedName = obj.Trim().Replace("'", "''");
            return fixedName;
        }

        /// <summary>
        /// Compares two System.String objects, ignoring or honoring their case, and returns true or false that indicates their comparison.
        /// </summary>
        /// <param name="args1">First String object to be compared</param>
        /// <param name="args2">Second String object to be compared with.</param>
        /// <returns>Returns boolean value that indicates the comparison of the objects.</returns>
        public static bool EqualsTo(this string args1, string args2)
        {
            return string.Compare(args1.ConvertToString(), args2.ConvertToString(), true) == 0;
        }

        /// <summary>
        /// Splits string according to the delimiters provided.<para></para>
        /// For example: <para></para>
        /// ("Hello World").SplitString(" ") returns a string array containing two items as "Hello" and "World".<para></para>
        /// ("Yesterday,Today,Tommorow_is_holiday").SplitString(",_") returns a string array containing five items as "Yesterday", "Today", "Tommorow", "is" and "holiday".
        /// </summary>
        /// <param name="obj">String to split</param>
        /// <param name="delimiters">Delimiter used to split the string. This may be one or many.</param>
        /// <returns>Returns string array containing the splitted items.</returns>
        public static string[] SplitString(this string obj, string delimiters)
        {
            char[] delimitersArray = delimiters.ToArray();
            string[] splitted = obj.Split(delimitersArray, StringSplitOptions.RemoveEmptyEntries);
            return splitted;
        }

        /// <summary>
        /// Converts a string to database insertable text. It returns null if string is null, empty or contains only white spaces.
        /// </summary>
        /// <param name="obj">String to be converted</param>
        /// <returns>Returns converted string.</returns>
        public static string ToDbString(this String obj)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                return null;
            }
            try
            {
                return obj.ToString().Trim();
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts words into Title Case i.e first letter of word into Upper Case.
        /// If a word contains "_" character, it splits into words.
        /// </summary>
        /// <param name="str">string to changed into Title Case.</param>
        /// <returns></returns>
        public static string ToTitleCase(this string str)
        {
            string st = string.Empty;
            string[] words = str.Split(new char[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                foreach (string word in words)
                {
                    if (word.Length > 0)
                    {
                        if (string.IsNullOrEmpty(st)) st = string.Concat(st, word.Substring(0, 1).ToUpper(), word.Substring(1).ToLower());
                        else st = string.Concat(st, " ", word.Substring(0, 1).ToUpper(), word.Substring(1).ToLower());
                    }
                }
            }
            return (!string.IsNullOrEmpty(st) ? st : str);
        }

        public static T ToEnum<T>(this string name)
        {
            T en = default(T);
            try
            {
                en = (T)Enum.Parse(typeof(T), name, true);
            }
            catch { }
            return en;
        }


        public static void RemoveEmptyRows(this DataTable table)
        {
            if (table == null) return;

            int cols = table.Columns.Count;
            for (int i = (table.Rows.Count - 1); i >= 0; i--)
            {
                if (IsBlankRow(table, i, cols))
                {
                    table.Rows[i].Delete();
                    table.AcceptChanges();
                }
            }
        }
        static bool IsBlankRow(DataTable table, int index, int columns)
        {
            if (table == null) return true;
            for (int i = 0; i < columns; i++)
            {
                var val = table.Rows[index][i].ConvertToString();
                if (val != null && val != string.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public static string SingleEngDate(string day, string month, string year)
        {
            if (!string.IsNullOrWhiteSpace(day) && !string.IsNullOrWhiteSpace(month) && !string.IsNullOrWhiteSpace(year))
            {
                day = Convert.ToInt32(day).ToString("00");
                month = Convert.ToInt32(month).ToString("00");
                year = Convert.ToInt32(year).ToString("0000");
                return string.Format("{0}-{1}-{2}", day, month, year);
            }
            return string.Empty;
        }


        public static bool CheckIfFileExistsOnServer(string fileName, string servername, string username, string psdwrd)
        {
            var request = (FtpWebRequest)WebRequest.Create(servername + fileName);
            request.Credentials = new NetworkCredential(username, psdwrd);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            try
            {
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                return true;
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    return false;
            }
            return false;
        }

         
    }


}



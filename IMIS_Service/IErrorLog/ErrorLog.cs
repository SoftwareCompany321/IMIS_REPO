using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IMIS_Service.IErrorLog
{
    public interface IErrorLog
    {
        Task<string> ErrorLog();
    }
    public class ErrorLog
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpUtility
{
    public class FtpConfigurationcs
    {
        public int Customer_Id { get; set; }
        public string Ftp_Uri { get; set; }
        public string Ftp_Username { get; set; }
        public string Ftp_Password { get; set; }
        public int Ftp_Port { get; set; }
        public string Ftp_Directory { get; set; }
        public string SubDirectory_name { get; set; }
        public string Ftp_Type { get; set; }
    }
}

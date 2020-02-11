using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpUtility
{
    public class QueuedFilesDetails
    {
        public string FileName { get; set; }
        public long Size { get; set; }
        //public string FileType { get; set; }
        public string isFolder { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public DateTime LastAccessTime { get; set; }
        public string URL { get; set; }

        //public string OnwerGroup { get; set; }
    }
}

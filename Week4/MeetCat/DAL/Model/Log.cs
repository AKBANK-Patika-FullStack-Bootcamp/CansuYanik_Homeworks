using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Log
    {
        public int logId { get; set; }

        public string status { get; set; }

        public string message { get; set; }

        public DateTime time { get; set; }
    }
}

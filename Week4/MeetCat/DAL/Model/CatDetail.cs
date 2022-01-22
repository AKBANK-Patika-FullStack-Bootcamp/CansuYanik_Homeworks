using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CatDetail
    {
        public int catId { get; set; }
        public string userName { get; set; }

        public string breed { get; set; }

        public string gender { get; set; }

        public DateTime birth { get; set; }
    }
}

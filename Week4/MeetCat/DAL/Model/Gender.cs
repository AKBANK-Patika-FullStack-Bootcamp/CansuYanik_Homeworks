using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Gender
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int genderId { get; set; }

        public string gender { get; set; }
    }
}

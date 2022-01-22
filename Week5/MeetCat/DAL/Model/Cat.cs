using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Model{

    public class Cat  /*A cat class*/
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int catId { get; set; }

        public string userName { get; set; }

        public string breed { get; set; }

        [ForeignKey("genderId")]

        public int genderId { get; set; } /*1: male, 2: female*/

        public DateTime birth { get; set; }

    }
}

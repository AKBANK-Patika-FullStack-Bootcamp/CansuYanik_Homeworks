using System;

namespace MeetCatWebApi{

    public class Cat  /*A cat class*/
    {
        public int catId { get; set; }

        public string name { get; set; }

        public string breed { get; set; }

        public int genderId { get; set; } /*1:male, 2: female*/

        public DateTime birth { get; set; }

    }
}

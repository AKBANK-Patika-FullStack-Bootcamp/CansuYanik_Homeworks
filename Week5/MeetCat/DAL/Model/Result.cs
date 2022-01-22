using System;

namespace DAL.Model{

    public class Result  /*A Result class, response format*/
    {
        public int HttpStatusCode { get; set; }
        public string? Message  { get; set; }
    }
}

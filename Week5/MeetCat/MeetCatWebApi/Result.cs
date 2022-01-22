using System;
using Microsoft.AspNetCore.Mvc;

namespace MeetCatWebApi{

    public class Result  /*A Result class, response format*/
    {
        public int HttpStatusCode { get; set; }
        public string? Message  { get; set; }
    }
}

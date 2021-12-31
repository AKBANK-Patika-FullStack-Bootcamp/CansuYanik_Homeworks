using System;
using Microsoft.AspNetCore.Mvc;

namespace MeetCatWebApi{

    public class Result  /*A cat class*/
    {
        public int HttpStatusCode { get; set; }
        public string Message  { get; set; }
    }
}

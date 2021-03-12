using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this classın kendisini kastediyor.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        //Buna overloading deniliyor (aşırı yükleme)
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

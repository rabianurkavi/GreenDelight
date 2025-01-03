﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Results
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public Result(string message) : this(true, message) // Burada Message'a değer atıyoruz.
        {

        }

    }
}

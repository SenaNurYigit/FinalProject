﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    { 
        bool Success { get; } //Burda satece getter olduğu için bu sadece bir şeyi return et demek olur.
        string Message { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)  //Buradaki this sayesinde ben  bu constructor'a success'i de gönderip alttaki constuctorun da çalışmasını sağlıyorum.
        {
            Message= message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message {get; } //getter read only'dir. Read Only'ler constructor'da set edilebilirler. 
    }
}

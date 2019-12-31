using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyService : IMyService
    {
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MyBL : IMyBL
    {
        private readonly IMyService _service;
        private readonly string _connectionstring;
        public MyBL(string connectionString,IMyService service)
        {
            _service = service;
            _connectionstring = connectionString;
        }
        public int GetData()
        {
            return _service.GetDate().Year + _connectionstring.Length;
        }
    }
}

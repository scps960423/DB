using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCore_DatabaseFirst.Models
{
    public class OperaModel
    {
        public int OperaID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Composer { get; set; }

    }
}

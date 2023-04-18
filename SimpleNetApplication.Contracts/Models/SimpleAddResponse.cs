using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Contracts.Models
{
    public class SimpleAddRequest
    {
        public SimpleModel Model { get; set; }
    }

    public class SimpleAddResponse
    {
        public SimpleModel Model { get; set; }
    }
}

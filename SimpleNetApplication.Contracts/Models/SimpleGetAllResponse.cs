using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Contracts.Models
{
    public class SimpleGetAllRequest
    {
    }

    public class SimpleGetAllResponse
    {
        public List<SimpleModel> Models { get; set; }
    }
}

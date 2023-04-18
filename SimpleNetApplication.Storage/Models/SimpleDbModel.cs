using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Storage.Models
{
    public class SimpleDbModel
    {
        public SimpleDbModel()
        {
            SubModels = new List<SimpleSubDbModel>();
        }
        [Key]
        public int Id { get; set; }

        public List<SimpleSubDbModel> SubModels { get; set; }
    }
}

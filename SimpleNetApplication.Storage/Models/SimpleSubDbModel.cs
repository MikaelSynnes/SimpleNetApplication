using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Storage.Models
{
    public class SimpleSubDbModel
    {
        [Key]
        public int Id { get; set; }

        public int DbModelFk { get; set; }
    }
}

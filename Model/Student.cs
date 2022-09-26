using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.BasicDemo.Model {
    public class Student {
        [Key]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long SozNumber { get; set; }
    }
}

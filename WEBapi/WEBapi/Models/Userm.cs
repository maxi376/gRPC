using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEBapi.Models
{
    public class Userm
    {
        [Key]
        public int UsermId { get; set; }
        public string UsermName { get; set; }
        public string UsermRole { get; set; }
        //public ICollection<Userm> Userms { get; set; }
    }
}

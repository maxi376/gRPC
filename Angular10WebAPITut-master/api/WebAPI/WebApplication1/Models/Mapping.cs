using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Mapping
    {
        [Key]
        public int MappingId { get; set; }
        //[Key]//scrie ca identifica unic o linie din tabel
        public int UsermId { get; set; }
        //[Key]//scrie ca identifica unic o linie din tabel
        public int DeviceId { get; set; }
        public DateTime MappingTimestamp { get; set; }
        public int MappingEnergyConsumption { get; set; }
        public ICollection<Mapping> Mappings { get; set; }
    }
}

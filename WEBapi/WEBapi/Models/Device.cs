using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WEBapi.Models
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        //[Key]//scrie ca identifica unic o linie din tabel
        public int UsermId { get; set; }
        public string DeviceDescription { get; set; }
        public string DeviceAddress { get; set; }
        public int DeviceMaxHEnergyConsumption { get; set; }
        //public ICollection<Device> Devices { get; set; }
        
    }
}

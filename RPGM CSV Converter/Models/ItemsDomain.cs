using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGM_CSV_Converter.Models
{
    public class ItemsDomain
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int ItemTypeId { get; set; }
        public int Price { get; set; }
        public bool Consumable { get; set; }
        public int Speed { get; set; }
        public int SuccessRate { get; set; }
        public int Repeat { get; set; }
        public int TPGain { get; set; }
        public string? Note { get; set; }
    }
}

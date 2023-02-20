using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGM_CSV_Converter.Models
{
    public class SkillsDomain
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int MPCost { get; set; }
        public int TPCost { get; set; }
        public int Speed { get; set; }
        public int SuccessRate { get; set; }
        public int Repeat { get; set; }
        public int TPGain { get; set; }
        public string? Message1 { get; set; }
        public string? Message2 { get; set; }
        public string? Note { get; set; }
    }
}

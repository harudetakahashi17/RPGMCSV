using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGM_CSV_Converter.Models
{
    public class ClassesDomain
    {
        public string? Name { get; set; }
        public int ExpBaseValue { get; set; }
        public int ExpExtraValue { get; set; }
        public int ExpAccel1 { get; set; }
        public int ExpAccel2 { get; set; }
        public int MinHP { get; set; }
        public int MaxHP { get; set; }
        public int MinMP { get; set; }
        public int MaxMP { get; set; }
        public int MinAtk { get; set; }
        public int MaxAtk { get; set; }
        public int MinDef { get; set; }
        public int MaxDef { get; set; }
        public int MinMAtk { get; set; }
        public int MaxMAtk { get; set; }
        public int MinMDef { get; set; }
        public int MaxMDef { get; set; }
        public int MinAgi { get; set; }
        public int MaxAgi { get; set; }
        public int MinLuk { get; set; }
        public int MaxLuk { get; set; }
        public string? Note { get; set; }
    }
}

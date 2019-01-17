using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animus.exercise.api
{
    public class ApartmentsDTO
    {
        public int id { get; set; }
        public string abailable { get; set; }
        public string street { get; set; }
        public int plz { get; set; }
        public string place { get; set; }
        public string country { get; set; }
        public string email { get; set; }
    }
}

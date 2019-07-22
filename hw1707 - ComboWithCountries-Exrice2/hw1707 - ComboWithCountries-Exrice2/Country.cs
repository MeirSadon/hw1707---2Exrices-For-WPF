using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1707___ComboWithCountries_Exrice2
{
    class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public string ResourceFlagUrl { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Capital}";
        }
    }
}

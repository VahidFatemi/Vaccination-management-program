using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    [Serializable]
    public class Vaccine
    {
        public Vaccine(string type)
        {
            _name = type;
        }

        public string _name { set; get; }
    }
}

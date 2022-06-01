using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface IVaccineBasesInformation
    {
        Dictionary<string, List<IVaccineBase>> LoadData();
    }
}

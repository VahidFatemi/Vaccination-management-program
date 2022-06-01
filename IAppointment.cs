using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface IAppointment
    {
        string _place { get; set; }
        string _vaccineBaseAddress { get; set; }
        string _vaccineBaseName { get; set; }
        Vaccine _vaccine { get; set; }
        TimeSpan _time { get; set; }
        DateTime _date { get; set; }

        void Creat(string place, string vaccineBaseName, string vaccineBaseAddress, Vaccine typeOfVaccine, TimeSpan time, DateTime date);
    }
}

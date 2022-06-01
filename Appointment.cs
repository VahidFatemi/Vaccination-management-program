using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    [Serializable]
    public class Appointment:IAppointment
    {
        
        public string _place { get; set; }
        public string _vaccineBaseName { get; set; }
        public string _vaccineBaseAddress { get; set; }
        public Vaccine _vaccine { get; set; }
        public TimeSpan _time { get; set; }
        public DateTime _date { get; set; }

        public void Creat (string place, string vaccineBaseName, string vaccineBaseAddress, Vaccine typeOfVaccine, TimeSpan time, DateTime date)
        {
            _place = place;
            _vaccineBaseName = vaccineBaseName;
            _vaccineBaseAddress = vaccineBaseAddress;
            this._vaccine = typeOfVaccine;
            _time = time;
            _date = date;
        }
    }
}

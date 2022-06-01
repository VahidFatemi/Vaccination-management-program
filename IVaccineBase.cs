using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    
    public interface IVaccineBase
    {
        string _name { get; set; }
        string _address { get; set; }
        int _capacity{ get; set; }
        int _coordinatesX { get; set; }
        int _coordinatesY { get; set; }
        
        TimeSpan _startShiftOne { get; set; }
        TimeSpan _endShiftOne { get; set; }
        TimeSpan _startShiftTwo { get; set; }
        TimeSpan _endShiftTwo { get; set; }

        List<TimeSpan> listOfFreeTime { get; set; }
        List<Vaccine> ListOfAvailableVaccines { get; set; }

        void MakeTimeList();
    }
}

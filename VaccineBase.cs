using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    [Serializable]
    class VaccineBase : IVaccineBase
    {
        public string _name { get; set; }
        public string _address { get; set; }
        public int _capacity { get; set; }
        public int _coordinatesX { get; set; }
        public int _coordinatesY { get; set; }
        
        public TimeSpan _startShiftOne { get; set; }
        public TimeSpan _endShiftOne { get; set; }
        public TimeSpan _startShiftTwo { get; set; }
        public TimeSpan _endShiftTwo { get; set; }

        public List<TimeSpan> listOfFreeTime { get; set; }
        public List<Vaccine> ListOfAvailableVaccines { get; set; }

        public VaccineBase(string place, int num, int capacity, int coordinatesX, int coordinatesY, 
            TimeSpan startShiftOne, TimeSpan endShiftOne, List<Vaccine> listOfAvailableVaccines)
        {
            _name = "Payegah shomare " + num + " " + place;
            _address = "Address payegah shomare " + num + " " + place;
            _capacity = capacity;
            _coordinatesX = coordinatesX;
            _coordinatesY = coordinatesY;
            _startShiftOne = startShiftOne;
            _endShiftOne = endShiftOne;
            _startShiftTwo = new TimeSpan();
            _endShiftTwo = new TimeSpan();
            ListOfAvailableVaccines = listOfAvailableVaccines;

            MakeTimeList();
        }

        public VaccineBase(string place, int num, int capacity, int coordinatesX, int coordinatesY, 
            TimeSpan startShiftOne, TimeSpan endShiftOne, TimeSpan startShiftTwo, TimeSpan endShiftTwo, List<Vaccine> listOfAvailableVaccines)
        {
            _name = "Payegah shomare " + num + " " + place;
            _address = "Address payegah shomare " + num + " " + place;
            _capacity = capacity;
            _coordinatesX = coordinatesX;
            _coordinatesY = coordinatesY;
            _startShiftOne = startShiftOne;
            _endShiftOne = endShiftOne;
            _startShiftTwo = startShiftTwo;
            _endShiftTwo = endShiftTwo;
            ListOfAvailableVaccines = listOfAvailableVaccines;

            MakeTimeList();
        }


        public void MakeTimeList()
        {
            listOfFreeTime = new List<TimeSpan>();

            TimeSpan workingHour = (_endShiftTwo - _startShiftTwo) + (_endShiftOne - _startShiftOne);
            TimeSpan _periodTime = new TimeSpan(workingHour.Ticks / _capacity);

            int remainingCapacity = 0; // zarfiati ke baray shift 2 baghi mimone.
            for (int i = 0; i < _capacity; i++)
            {
                TimeSpan ts2 = new TimeSpan(_startShiftOne.Ticks + (i * _periodTime.Ticks));
                if (ts2 < _endShiftOne)
                {
                    listOfFreeTime.Add(ts2);
                }
                else
                {
                    remainingCapacity = _capacity - i;
                    break;
                }
            }

            //agar zarfiati baray shift 2 baghi bemone:
            for (int i = 0; i < remainingCapacity; i++)
            {
                TimeSpan ts2 = new TimeSpan(_startShiftTwo.Ticks + (i * _periodTime.Ticks));
                listOfFreeTime.Add(ts2);
            }
            
        }
    }
}

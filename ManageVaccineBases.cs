using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public class ManageVaccineBases:IManageVaccineBases
    {        

        public Dictionary<string, List<IVaccineBase>> _Place_vaccineBasesDict { get; set; }

        public IVaccineBasesInformation _vaccineBasesInformation { get; set; }
        public string _filePathVaccineBase { get; set; }
        public string _filePathLoginTimes { get; set; }
        public ILoaderSaver _loaderSaver { get; set; }
        public DateTime _today { get; set; }

        public ManageVaccineBases(IVaccineBasesInformation vaccineBasesInformation, string filePathVaccineBase, string filePathLoginTimes, ILoaderSaver loaderSaver)
        {
            _vaccineBasesInformation = vaccineBasesInformation;
            _Place_vaccineBasesDict = new Dictionary<string, List<IVaccineBase>>();
            _filePathVaccineBase = filePathVaccineBase;
            _filePathLoginTimes = filePathLoginTimes;
            _loaderSaver = loaderSaver;

            _today = DateTime.Today;
            if (!File.Exists(_filePathLoginTimes))
            {
                _loaderSaver.SaveNewLoginDateToFile(_filePathLoginTimes ,_today);
                _Place_vaccineBasesDict = _vaccineBasesInformation.LoadData();
            }
            else
            {
                if (_loaderSaver.ReadLastLoginDateFromFile(_filePathLoginTimes) < _today)
                {
                    _loaderSaver.SaveNewLoginDateToFile(_filePathLoginTimes, _today);
                    _Place_vaccineBasesDict = _vaccineBasesInformation.LoadData();
                    _loaderSaver.SaveAllPlace_vaccineBaseToFile(_filePathVaccineBase, _Place_vaccineBasesDict);
                }
                else
                {
                    if (File.Exists(_filePathVaccineBase))
                    {
                        _loaderSaver.SaveNewLoginDateToFile(_filePathLoginTimes, _today);
                        _Place_vaccineBasesDict = _loaderSaver.ReadAllPlace_vaccineBaseFromFile(_filePathVaccineBase);
                    }
                    else
                    {
                        _loaderSaver.SaveNewLoginDateToFile(_filePathLoginTimes, _today);
                        _Place_vaccineBasesDict = _vaccineBasesInformation.LoadData();
                    }                    
                }
            }

        }

        
        public void OccupyTime(string place, string vaccineBaseName, TimeSpan time)
        {
            foreach (var vaccineBase in _Place_vaccineBasesDict[place])
            {
                if (vaccineBase._name == vaccineBaseName)
                {
                    vaccineBase.listOfFreeTime.Remove(time);                    
                }
            }
            _loaderSaver.SaveAllPlace_vaccineBaseToFile(_filePathVaccineBase, _Place_vaccineBasesDict);
        }

        public void AddFreeTime(string place, string vaccineBaseName, TimeSpan time)
        {
            foreach (var vaccineBase in _Place_vaccineBasesDict[place])
            {
                if(vaccineBase._name == vaccineBaseName)
                {
                    vaccineBase.listOfFreeTime.Add(time);
                    vaccineBase.listOfFreeTime.Sort();
                }
            }
            _loaderSaver.SaveAllPlace_vaccineBaseToFile(_filePathVaccineBase, _Place_vaccineBasesDict);
        }
    
        public List<string> ReadPlaces()
        {
            List<string> placeList = new List<string>();
            foreach (string place in _Place_vaccineBasesDict.Keys)
            {
                placeList.Add(place);
            }
            return placeList;
        }

        public List<IVaccineBase> ReadVaccineBasesInPlace(string place)
        {
            return _Place_vaccineBasesDict[place];
        }
    }
}

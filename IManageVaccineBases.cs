using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface IManageVaccineBases
    {        
        Dictionary<string, List<IVaccineBase>> _Place_vaccineBasesDict { get; set; }
        IVaccineBasesInformation _vaccineBasesInformation { get; set; }
        string _filePathVaccineBase { get; set; }
        string _filePathLoginTimes { get; set; }
        ILoaderSaver _loaderSaver { get; set; }
        DateTime _today { get; set; }
                        
        void OccupyTime(string place, string vaccineBaseName, TimeSpan time);
        void AddFreeTime(string place, string vaccineBaseName, TimeSpan time);

        List<string> ReadPlaces();
        List<IVaccineBase> ReadVaccineBasesInPlace(string place);
    }
}

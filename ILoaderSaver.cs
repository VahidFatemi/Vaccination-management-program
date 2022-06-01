using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface ILoaderSaver
    {
        
        void SaveNewPerson_appointmentToFile(string path, Person person, IAppointment appointment);
        void SaveAllPerson_appointmentToFile(string path, Dictionary<Person, IAppointment> Person_appointmentDict);
        Dictionary<Person, IAppointment> ReadAllPerson_appointmentFromFile(string path);

        void SaveAllPlace_vaccineBaseToFile(string path, Dictionary<string, List<IVaccineBase>> Place_vaccineBasesDict);
        Dictionary<string, List<IVaccineBase>> ReadAllPlace_vaccineBaseFromFile(string path);

        void SaveNewLoginDateToFile(string path, DateTime dt);
        DateTime ReadLastLoginDateFromFile(string path);
    }
}

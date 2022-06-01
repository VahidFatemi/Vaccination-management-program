using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface ILinkAppointmentToPerson
    {
        Dictionary<Person, IAppointment> person_appointmentDict { get; set; }
        string _filePath { get; set; }
        ILoaderSaver _loaderSaver { get; set; }

        void Add(Person person, IAppointment appointment);
        bool PersonIsExist(long id);
        IAppointment GetAppointmentOfAPerson(long id);
        Person GetPerson(long id);
        IAppointment FindAndRemove(long id);

    }
}

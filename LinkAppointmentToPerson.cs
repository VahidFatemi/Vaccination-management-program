using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public class LinkAppointmentToPerson:ILinkAppointmentToPerson
    {        
        public Dictionary<Person, IAppointment> person_appointmentDict { get; set; }
        public string _filePath { get; set; }
        public ILoaderSaver _loaderSaver { get; set; }

        public LinkAppointmentToPerson(string filePath, ILoaderSaver loaderSaver)
        {
            person_appointmentDict = new Dictionary<Person, IAppointment>();
            _filePath = filePath;
            _loaderSaver = loaderSaver;

            if (File.Exists(_filePath))
            {
                person_appointmentDict = _loaderSaver.ReadAllPerson_appointmentFromFile(_filePath);
            }
        }

        public void Add(Person person, IAppointment appointment)
        {
            person_appointmentDict.Add(person, appointment);
            _loaderSaver.SaveNewPerson_appointmentToFile(_filePath, person, appointment);
        }

        public bool PersonIsExist(long id)
        {
            foreach (var person in person_appointmentDict.Keys)
            {
                if (person.GetId() == id)
                {
                    return true;
                }
            }
            return false;
        }

        public IAppointment GetAppointmentOfAPerson(long id)
        {
            foreach (var person in person_appointmentDict.Keys)
            {
                if (person.GetId() == id)
                {
                    return person_appointmentDict[person];
                }
            }
            return null;
        }

        public Person GetPerson(long id)
        {
            foreach (var person in person_appointmentDict.Keys)
            {
                if (person.GetId() == id)
                {
                    return person;
                }
            }
            return null;
        }

        public IAppointment FindAndRemove(long id)
        {
            bool found = false;
            IAppointment appointment=null;
            //yek person movaghat misazim:
            Person tempPerson = null;

            foreach (var person in person_appointmentDict.Keys)
            {
                if (person.GetId() == id)
                {
                    tempPerson = person;
                    found = true;
                    appointment = person_appointmentDict[person];                    
                }
            }
            if (found)
            {
                person_appointmentDict.Remove(tempPerson);
                _loaderSaver.SaveAllPerson_appointmentToFile(_filePath, person_appointmentDict);
                return appointment;
            }
            else
            {
                return null;
            }
        }
    }
}

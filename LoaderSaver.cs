using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public class LoaderSaver:ILoaderSaver
    {
        
        public void SaveNewPerson_appointmentToFile(string path, Person person, IAppointment appointment)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Dictionary<Person, IAppointment> tempDict = new Dictionary<Person, IAppointment>();
            tempDict.Add(person, appointment);

            foreach( var item in tempDict)
            {
                bFormatter.Serialize(fs, item);
            }
            fs.Close();
        }

        public void SaveAllPerson_appointmentToFile(string path, Dictionary<Person, IAppointment> Person_appointmentDict)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            
            foreach (var item in Person_appointmentDict)
            {
                bFormatter.Serialize(fs, item);
            }
            fs.Close();
        }

        public Dictionary<Person, IAppointment> ReadAllPerson_appointmentFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Dictionary<Person, IAppointment> person_appointmentDict = new Dictionary<Person, IAppointment>();
            while (fs.Position != fs.Length)
            {
                var item= (KeyValuePair<Person, IAppointment>)bFormatter.Deserialize(fs);
                person_appointmentDict.Add(item.Key, item.Value);
            }
            fs.Close();
            return person_appointmentDict;
        }

        
        public void SaveAllPlace_vaccineBaseToFile(string path, Dictionary<string, List<IVaccineBase>> Place_vaccineBasesDict)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();

            foreach (var item in Place_vaccineBasesDict)
            {
                bFormatter.Serialize(fs, item);
            }
            fs.Close();
        }

        public Dictionary<string, List<IVaccineBase>> ReadAllPlace_vaccineBaseFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Dictionary<string, List<IVaccineBase>> Place_vaccineBasesDict = new Dictionary<string, List<IVaccineBase>>();

            while(fs.Position != fs.Length)
            {
                var item = (KeyValuePair<string, List < IVaccineBase >>)bFormatter.Deserialize(fs);
                Place_vaccineBasesDict.Add(item.Key, item.Value);
            }
            fs.Close();
            return Place_vaccineBasesDict;
        }


        public void SaveNewLoginDateToFile(string path, DateTime dt)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(fs, dt);
            fs.Close();
        }

        public DateTime ReadLastLoginDateFromFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bFormatter = new BinaryFormatter();
            List<DateTime> loginTimeList = new List<DateTime>();
            while (fs.Position != fs.Length)
            {
                loginTimeList.Add((DateTime)bFormatter.Deserialize(fs));
                
            }
            fs.Close();
            int count = loginTimeList.Count;
            return loginTimeList[count - 1];
        }

    }
}

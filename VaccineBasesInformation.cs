using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public class VaccineBasesInformation:IVaccineBasesInformation
    {        
        public Dictionary<string, List<IVaccineBase>> LoadData()
        {
            Dictionary<string, List<IVaccineBase>> Place_vaccineBasesDict = new Dictionary<string, List<IVaccineBase>>();

            List<string> placeList = new List<string>() {  "Ardabil" , "Isfahan", "Alborz" , "Ilam", "AzerbaijanEast",
                "AzerbaijanWest", "Bushehr", "Tehran", "ChaharMahaalAndBakhtiari",
                "KhorasanSouth", "KhorasanRazavi", "KhorasanNorth", "Khuzestan", "Zanjan",
                "Semnan", "SistanAndBaluchestan", "Fars", "Qazvin", "Qom", "Kurdistan", "Kerman",
                "Kermanshah", "KohgiluyehAndBoyerAhmad", "Golestan", "Gilan", "Lorestan",
                "Mazandaran", "Markazi", "Hormozgn", "Hamadan", "Yazd"};

            foreach (string place in placeList)
            {                
                List<IVaccineBase> vaccineBaseList = new List<IVaccineBase>();
                
                //Build vaccine base 1:
                List<Vaccine> typeOfVaccines1 = new List<Vaccine>() {
                    new Vaccine("Barekat"), new Vaccine("Sinofarm"), new Vaccine("Astraznka")};

                vaccineBaseList.Add(new VaccineBase(place, 1, 40, 100, 150, new TimeSpan(8, 0, 0), new TimeSpan(20, 0, 0), typeOfVaccines1));

                ////Build vaccine base 2:
                List<Vaccine> typeOfVaccines2 = new List<Vaccine>() {
                    new Vaccine("Barekat"), new Vaccine("Sinofarm")};

                vaccineBaseList.Add(new VaccineBase(place, 2, 30, 200, 300, new TimeSpan(8, 0, 0), new TimeSpan(12, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(20, 0, 0),typeOfVaccines2));

                ////Build vaccine base 3:
                List<Vaccine> typeOfVaccines3 = new List<Vaccine>() {
                    new Vaccine("Barekat"), new Vaccine("Sinofarm")};

                vaccineBaseList.Add(new VaccineBase(place, 3, 20, 50, 300, new TimeSpan(10, 0, 0), new TimeSpan(13, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(18, 0, 0), typeOfVaccines3));

                //Add to list:
                Place_vaccineBasesDict.Add(place, vaccineBaseList);
            }
            return Place_vaccineBasesDict;
        }
    }
}

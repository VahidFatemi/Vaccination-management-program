using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public class ManageRequest
    {
        readonly IUserInterFaceMain _formMain;
        readonly IUserInterFaceRegister _formRegister;
        readonly IManageVaccineBases _manageVaccineBases;
        readonly ILinkAppointmentToPerson _LinkAppointmentToPerson;

        public RequestedAction _action { get; set; }
        private Person _person;
                
        public ManageRequest(IUserInterFaceMain userInterFaceMain, IUserInterFaceRegister userInterFaceRegister, IManageVaccineBases manageVaccineBases, ILinkAppointmentToPerson linkAppointmentToPerson)
        {
            _formMain = userInterFaceMain;
            _formRegister = userInterFaceRegister;
            _manageVaccineBases = manageVaccineBases;
            _LinkAppointmentToPerson = linkAppointmentToPerson;
        }

        public void ProcessRequest( RequestedAction Action)
        {
            _action = Action;
            
            switch (_action)
            {
                case RequestedAction.Register:
                    Register();
                    break;

                case RequestedAction.Show:
                    Show();
                    break;

                case RequestedAction.Edit:
                    Edit();
                    break;

                case RequestedAction.Remove:
                    Remove();
                    break;                
            }            
        }

        private void Register()
        {
            _person = _formMain.GetPerson();

            if (_LinkAppointmentToPerson.PersonIsExist(_person.GetId()))
            {
                string text = "شما با این شماره شناسنامه از قبل ثبت شده اید";
                string title = "ثبت نام";
                _formMain.PrintMessage(text, title);
            }
            else
            {
                _formMain.GoToNextMenu();
            }            
        }


        private void Show()
        {
            long id = _formMain.GetID();
            IAppointment appointment;
            string text="";
            string title="مشاهده نوبت قبلی";

            if (_LinkAppointmentToPerson.PersonIsExist(id))
            {
                appointment = _LinkAppointmentToPerson.GetAppointmentOfAPerson(id);
                text = $"مکان:  {appointment._place}\nنام پایگاه واکسن:  {appointment._vaccineBaseName}\n" +
                    $"آدرس:  {appointment._vaccineBaseAddress}\nتاریخ نوبت شما:  {appointment._date.ToString("yyyy/MM/dd")}" +
                    $"\nزمان نوبت شما:  {appointment._time}\nنوع واکسن انتخابی:  {appointment._vaccine._name}";
            }
            else
            {
                text = "شما ثبت نام نکرده اید";
            }
            _formMain.PrintMessage(text, title);

        }


        private void Edit()
        {
            long id = _formMain.GetID();
            string text = "";
            string title = "اصلاح نوبت";

            if (_LinkAppointmentToPerson.PersonIsExist(id))
            {
                _person = _LinkAppointmentToPerson.GetPerson(id);
                IAppointment appointment = _LinkAppointmentToPerson.FindAndRemove(id);
                _manageVaccineBases.AddFreeTime(appointment._place, appointment._vaccineBaseName, appointment._time);
                _formMain.GoToNextMenu();
                text = "نوبت قبلی شما حذف شد. حال دوباره یک نوبت ثبت کنید";
            }
            else
            {
                text = "شما تا کنون ثبت نام نکرده اید";
            }
            _formMain.PrintMessage(text, title);
        }


        private void Remove()
        {
            long id = _formMain.GetID();
            IAppointment appointment = _LinkAppointmentToPerson.FindAndRemove(id);
            string text = "";
            string title = "حذف نوبت";
            if (appointment == null)
            {
                text = "شما تا کنون ثبت نام نکرده اید";
            }
            else
            {
                _manageVaccineBases.AddFreeTime(appointment._place, appointment._vaccineBaseName, appointment._time);
                text = "نوبت شما با موفقیت حذف شد";
            }
            _formMain.PrintMessage(text, title);

        }


        
        public List<IVaccineBase> ReadVaccineBasesInPlaceFromManager(string place)
        {
            return _manageVaccineBases.ReadVaccineBasesInPlace(place);
        }

        public List<string> ReadPlacesFromManager()
        {
            return _manageVaccineBases.ReadPlaces();
        }

        public void TakeAnAppointment(string place, string vaccineBaseName, string vaccineBaseAddress, Vaccine vaccineName, TimeSpan time, IAppointment appointment)
        {
            _manageVaccineBases.OccupyTime(place, vaccineBaseName, time);
            DateTime date = DateTime.Today.AddDays(1);
            appointment.Creat(place, vaccineBaseName, vaccineBaseAddress, vaccineName, time, date);
            _LinkAppointmentToPerson.Add(_person, appointment);
        }
    }
}

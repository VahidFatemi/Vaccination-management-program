using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface IUserInterFaceRegister
    {
        ManageRequest _manageRequest { get; set; }
        IUserInterFaceMain form_main { get; set; }
        void ShowMenu();
        void RefreshAll();
        void ShowPlaces();
        void SortVaccineBases();
    }
}

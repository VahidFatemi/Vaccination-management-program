using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine__final_project_
{
    public interface IUserInterFaceMain
    {
        void MainMenu();
        Person GetPerson();
        long GetID();
        void PrintMessage(string text, string title);
        void GoToNextMenu();
        bool CheckInput_Register();
        bool CheckInput_Other();
        void ShowMenu();
        void RefreshAll();
    }
}

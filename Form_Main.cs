using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaccine__final_project_
{
    public partial class Form_Main : Form ,IUserInterFaceMain
    {
        public RequestedAction _action { get; set; }        
        private ManageRequest _manageRequest { get; set; }
        private Form_Register _form_Register { get; set; }
        

        public Form_Main()
        {
            InitializeComponent();            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void MainMenu()
        {            
            _manageRequest.ProcessRequest(_action);
        }

        public void ShowMenu()
        {
            this.RefreshAll();
            this.Enabled = true;
            _form_Register.Enabled = false;
            _form_Register.Hide();
            _form_Register.RefreshAll();
        }

        public Person GetPerson()
        {
            long id = Convert.ToInt64(txt_id.Text);
            int age = Convert.ToInt32(numericUpDown_age.Value);
            string gender;
            if (rb_male.Checked == true)
            {
                gender = "Man";
            }
            else
            {
                gender = "Woman";
            }
            Person _person = new Person(id, txt_firstName.Text, txt_lastName.Text, age, gender);
            return _person;
        }

        public long GetID()
        {
            long id = Convert.ToInt64(txt_id.Text);
            return id;
        }

        public void GoToNextMenu()
        {            
            this.Enabled = false;
            _form_Register._manageRequest = _manageRequest;
            _form_Register.form_main = this;
            _form_Register.Enabled = true;
            _form_Register.ShowMenu();            
        }

        public void PrintMessage(string text, string title)
        {
            MessageBox.Show(text, title);
        }

        public void RefreshAll()
        {
            this.txt_firstName.Text = "";
            this.txt_id.Text = "";
            this.txt_lastName.Text = "";
            this.numericUpDown_age.Value = 0;
            this.rb_male.Checked = true;
        }

        public bool CheckInput_Register()
        {
            if (txt_firstName.Text != "" && txt_lastName.Text != "" && txt_id.Text!="")
            {
                long id = Convert.ToInt64(txt_id.Text);
                if (id > 999999999 && id <= 9999999999)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;            
        }

        public bool CheckInput_Other()
        {
            if (txt_id.Text != "")
            {
                long id = Convert.ToInt64(txt_id.Text);
                if (id > 999999999 && id <= 9999999999)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private void HideBackColorItems()
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            label5.BackColor = System.Drawing.Color.Transparent;
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            label8.BackColor = System.Drawing.Color.Transparent;
            label9.BackColor = System.Drawing.Color.Transparent;
            label10.BackColor = System.Drawing.Color.Transparent;
            label11.BackColor = System.Drawing.Color.Transparent;
            rb_famale.BackColor = System.Drawing.Color.Transparent;
            rb_male.BackColor = System.Drawing.Color.Transparent;
            splitContainer1.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            HideBackColorItems();

            string folderName = System.IO.Directory.GetCurrentDirectory();
            string fileNameSuffixVaccineBases = @"VaccineBasesFile.txt";
            string fileNameSuffixPerson_appointment = @"Person_AppointmentFile.txt";
            string fileNameSuffixArrivalTimes = @"ArrivalTimesFile.txt";

            ManageVaccineBases manageVaccineBases = new ManageVaccineBases(new VaccineBasesInformation(), folderName + fileNameSuffixVaccineBases, folderName + fileNameSuffixArrivalTimes, new LoaderSaver());
            
            LinkAppointmentToPerson linkAppointmentToPerson = new LinkAppointmentToPerson(folderName + fileNameSuffixPerson_appointment, new LoaderSaver());

            _form_Register = new Form_Register();
            _manageRequest = new ManageRequest(this, _form_Register, manageVaccineBases,linkAppointmentToPerson);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {            
            if (CheckInput_Register())
            {
                _action = RequestedAction.Register;
                MainMenu();
            }
            else
            {
                MessageBox.Show("اطلاعات را کامل و درست وارد کنید!");
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            if (CheckInput_Other())
            {
                _action = RequestedAction.Show;
                MainMenu();
            }
            else
            {
                MessageBox.Show("شماره شناسنامه خود را درست وارد کنید!");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (CheckInput_Other())
            {
                _action = RequestedAction.Edit;
                MainMenu();
            }
            else
            {
                MessageBox.Show("شماره شناسنامه خود را درست وارد کنید!");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (CheckInput_Other())
            {
                _action = RequestedAction.Remove;
                MainMenu();
            }
            else
            {
                MessageBox.Show("شماره شناسنامه خود را درست وارد کنید!");
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

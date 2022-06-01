using System;
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
    public partial class Form_Register : Form, IUserInterFaceRegister
    {
        public ManageRequest _manageRequest { get; set; }
        public IUserInterFaceMain form_main { get; set; }
        
        public Form_Register()
        {
            InitializeComponent();            
        }
        public void ShowMenu()
        {
            this.Show();
        } 

        public void RefreshAll()
        {
            cmb_place.SelectedItem = null;
            cmb_time.SelectedItem = null;
            cmb_viccineName.SelectedItem = null;
            cmb_vaccineBase.SelectedItem = null;
            ch_checkCoordinates.Checked = false;
            numericUpDown_X.Value = 0;
            numericUpDown_Y.Value = 0;
        }

        private void cmb_place_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                if (ch_checkCoordinates.Checked == true)
                {
                    cmb_vaccineBase.Items.Clear();
                    cmb_viccineName.Items.Clear();
                    cmb_time.Items.Clear();
                    SortVaccineBases();
                }
                else
                {
                    cmb_vaccineBase.Items.Clear();
                    cmb_viccineName.Items.Clear();
                    cmb_time.Items.Clear();

                    string place = cmb_place.SelectedItem.ToString();
                    List<IVaccineBase> vaccineBases = _manageRequest.ReadVaccineBasesInPlaceFromManager(place);
                    foreach (var item in vaccineBases)
                    {
                        cmb_vaccineBase.Items.Add(item._name);
                    }
                }
            }           
        }

        private void cmb_vaccineBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Enabled == true)
            {
                cmb_viccineName.SelectedItem = null;
                cmb_time.SelectedItem = null;
                lbl_Address.Text = "";
                cmb_viccineName.Items.Clear();
                cmb_time.Items.Clear();
                string indexBase = cmb_vaccineBase.SelectedItem.ToString();
                int indexPlace = cmb_place.SelectedIndex;
                string place = cmb_place.SelectedItem.ToString();
                List<IVaccineBase> vaccineBases = _manageRequest.ReadVaccineBasesInPlaceFromManager(place);

                foreach (var vaccineBase in vaccineBases)
                {
                    if (vaccineBase._name == indexBase)
                    {
                        lbl_Address.Text = vaccineBase._address;

                        foreach (var item in vaccineBase.ListOfAvailableVaccines)
                        {
                            cmb_viccineName.Items.Add(item._name);
                        }

                        foreach (var item in vaccineBase.listOfFreeTime)
                        {
                            cmb_time.Items.Add(item);
                        }
                    }
                }
            }           
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            HideBackColorItems();
            ShowPlaces();
        }

        public void ShowPlaces()
        {
            List<string> placesList = _manageRequest.ReadPlacesFromManager();

            foreach(string place in placesList)
            {
                cmb_place.Items.Add(place);
            }
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
            lbl_Address.BackColor = System.Drawing.Color.Transparent;
            ch_checkCoordinates.BackColor = System.Drawing.Color.Transparent;
            
        }

        public double CalculateDistance(int x1, int y1, int x2, int y2)
        {
            double c = Math.Sqrt(((x1 - x2) * (x1 - x2)) + ((y1 - y2) * (y1 - y2)));
            return c;
        }

        public void SortVaccineBases()
        {
            string place = cmb_place.SelectedItem.ToString();
            List<IVaccineBase> vaccineBases = _manageRequest.ReadVaccineBasesInPlaceFromManager(place);
            int x = Convert.ToInt32(numericUpDown_X.Value);
            int y = Convert.ToInt32(numericUpDown_Y.Value);
            var sortedVaccineBases = from vaccineBase in vaccineBases
                                     orderby CalculateDistance(vaccineBase._coordinatesX, vaccineBase._coordinatesY, x, y)
                                     select vaccineBase;

            foreach (var item in sortedVaccineBases)
            {
                cmb_vaccineBase.Items.Add(item._name);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(cmb_place.SelectedItem!=null && cmb_vaccineBase.SelectedItem != null && cmb_viccineName.SelectedItem != null && cmb_time.SelectedItem != null)
            {
                string place = cmb_place.SelectedItem.ToString();
                int baseIndex = cmb_place.SelectedIndex;
                string vaccineBaseName = cmb_vaccineBase.SelectedItem.ToString();
                string vaccineBaseAddress = lbl_Address.Text;
                Vaccine typeOfVaccine = new Vaccine(cmb_viccineName.Text);
                TimeSpan time = (TimeSpan)cmb_time.SelectedItem;
                _manageRequest.TakeAnAppointment(place, vaccineBaseName, vaccineBaseAddress, typeOfVaccine, time, new Appointment());
                MessageBox.Show("شما با موفقیت ثبت نام شدید");
                form_main.ShowMenu();
            }

            else
            {
                MessageBox.Show("لطفا ابتدا تمام موارد را پر کنید");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_main.ShowMenu();
        }

        private void rb_checkCoordinates_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_X_ValueChanged(object sender, EventArgs e)
        {
            if (cmb_place.SelectedItem != null)
            {
                cmb_vaccineBase.Items.Clear();
                SortVaccineBases();
            }
        }

        private void ch_checkCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_checkCoordinates.Checked == true)
            {
                numericUpDown_X.Enabled = true;
                numericUpDown_Y.Enabled = true;
                if (cmb_place.SelectedItem != null)
                {
                    cmb_vaccineBase.Items.Clear();
                    SortVaccineBases();
                }

            }
            else
            {
                numericUpDown_X.Enabled = false;
                numericUpDown_Y.Enabled = false;
            }
        }
    }
}

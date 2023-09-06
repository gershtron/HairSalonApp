using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hairdressers
{
    public partial class Terrmin : Form
    {
        private List<Haarstile> LiHarst;
        private List<Location> LiLocat;
        private Database db = new Database();//zugriff zum datenbank


        public Terrmin()
        {
            InitializeComponent();
            HaarstilAnzeigen();
            LocationsAnzeigen();
           

            // Disable the "Weiter" button initially
            WeiterBTN.Enabled = false;

            // Attach an event handler to the ComboBox's SelectedIndexChanged event
            cbHaarstil.SelectedIndexChanged += cbHaarstil_SelectedIndexChanged;      

        }

     

        private void HaarstilAnzeigen()
        {
            LiHarst = db.getHaarstile();

            foreach (Haarstile Harst in LiHarst)
            {

                cbHaarstil.Items.Add(Harst.Hs_name);

            }

        }

        private void LocationsAnzeigen()
        {
            LiLocat = db.getLocation();

            foreach (Location Locat in LiLocat)
            {              
                cbLocations.Items.Add(Locat.Location_name1);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (cbHaarstil.SelectedIndex >= 0) // Check if an option is selected
            {
                // Proceed to the next step
                // Add your code here
            Form1 secondForm = new Form1();
            secondForm.Show();
            this.Hide(); // Hide the current form
                
            }
            else
            {
                MessageBox.Show("Please select an option before proceeding.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginForm lForm = new LoginForm();
            lForm.Show();
            this.Hide(); // Hide the current form


            //Admin AdminForm = new Admin();
            //AdminForm.Show();
            //this.Hide(); // Hide the current form
        }
      
        private void cbHaarstil_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeiterBTN.Enabled = true;        

        }

     
        private void btnENTER_Click(object sender, EventArgs e)
        {

            if (cbLocations.SelectedItem != null)
            {
                string selectedLocationName = cbLocations.SelectedItem.ToString();
                Location selectedLocation = db.GetLocationByName(selectedLocationName); // Assuming you have a method to retrieve a location by name.

                if (selectedLocation != null && selectedLocation.IsOpen1 == "yes")
                {
                    // Proceed to the next step
                    // Add your code here
                    Form1 secondForm = new Form1();
                    secondForm.Show();
                    this.Hide(); // Hide the current form
                }
                else
                {
                    // Location is closed, show a message.
                    MessageBox.Show("Dieser Standort ist derzeit leider geschlossen..");
                }
            }
            else
            {
                MessageBox.Show("Please select a location.");
            }
        }
    }


    



}

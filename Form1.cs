using MySql.Data.MySqlClient;

namespace Hairdressers
{
    public partial class Form1 : Form
    {

        private Database db = new Database();//zugriff zum datenbank
        private List<Kunde> LiKund;
        private List<Mitarbeiter> LiMitarb;
        private List<Haarstile> LiHarst;
       
        private Image MA = null;

        public static object Instance { get; internal set; }

        public Form1()
        {
            InitializeComponent();
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MitarbeiterAnzeigen();
            HaarstilAnzeigen();
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        { 
            groupBox1.Text = e.Start.ToString("MMMM dd, yyyy"); 
        }

        private void MitarbeiterAnzeigen()
        {
            LiMitarb = db.getMitarbeiter();

            foreach (Mitarbeiter Mitarb in LiMitarb)
            {

                cbMitarbeiter.Items.Add(Mitarb.Mitarb_name );

                //tbMAid.Text = Convert.ToString(Mitarb.Mitarb_id);
            }

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            groupBox2.Text = e.Start.ToString("dd,MMMM , yyyy " ) + cbMitarbeiter.Text;
            tbDate.Text = e.Start.ToString("yyyy-MM-dd ");
            MaName.Text = cbMitarbeiter.Text;
            tbStyle.Text = cbHaarstil.Text;

        }

        private void button32_Click(object sender, EventArgs e)//Georgio Name BTN
        {
            MaName.Text = button32.Text;
       
        }
        private void button32_MouseHover(object sender, EventArgs e)
        {
            label18.Visible = true;
            listBox1.Visible = true;
        }

        private void button32_MouseLeave(object sender, EventArgs e)
        {
            label18.Visible = false;
            listBox1.Visible = false;
        }

        private void button34_MouseHover(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void button34_MouseLeave(object sender, EventArgs e)
        {
            label17.Visible = false;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tbDate_TextChanged(object sender, EventArgs e)
        {
           

        }

//CLEAR BUTTON
        private void button36_Click(object sender, EventArgs e)
        {
            MaName.Clear();
            tbStyle.Clear();
            tbKUvname.Clear();
            tbKUnname.Clear();
            tbDate.Clear();
            tbTime.Clear();
            tbETime.Clear();
            cbMitarbeiter.Text = "";

            this.Close();
            
            Form1 newForm = new Form1();          
            newForm.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void cbMitarbeiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMitarbeiter.SelectedIndex >= 0)
            {
                int selectedIndex = cbMitarbeiter.SelectedIndex;

                // Retrieve the corresponding Mitarb object
                var selectedMitarb = LiMitarb[selectedIndex];

                // Display Mitarb_id in the other TextBox
                tbMAid.Text = selectedMitarb.Mitarb_id.ToString();
            }
            else
            {
                // Handle the case when no item is selected
                tbMAid.Text = string.Empty; // Clear the TextBox
            }
        }




  //Groupbox DayTime________________________________________
        private string selectedStartTimeText = "";
        private string selectedEndTimeText = "";
        private void button8_Click(object sender, EventArgs e)// 08:00
        {
            //Button clickedButton = (Button)sender;
            /// Set the Text property of tbtime to the text of the clicked button
            //tbTime.Text = clickedButton.Text;

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }
        private void btn830_Click(object sender, EventArgs e)// 08:30
        {         

            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void btn900_Click(object sender, EventArgs e)// 09:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void btn930_Click(object sender, EventArgs e)// 09:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void btn100_Click(object sender, EventArgs e)// 10:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }
        private void btn10030_Click(object sender, EventArgs e)// 10:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }
        private void button18_Click(object sender, EventArgs e)// 11:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)// 11:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)// 12:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)// 12:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)// 13:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)//13:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button29_Click(object sender, EventArgs e)// 14:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button27_Click(object sender, EventArgs e)// 14:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button25_Click(object sender, EventArgs e) // 15:00
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)// 15:30
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (selectedStartTimeText == "")
                {
                    // If no start time is selected, store the clicked button's text as the start time
                    selectedStartTimeText = clickedButton.Text;
                    tbTime.Text = selectedStartTimeText;
                }
                else if (selectedEndTimeText == "")
                {
                    // If no end time is selected, store the clicked button's text as the end time
                    selectedEndTimeText = clickedButton.Text;
                    tbETime.Text = selectedEndTimeText;
                }
            }


        }



// ---- CHECK IF BOOKING EXISTS--------------------------------------------
        private bool CheckBookingExists(int maId, DateTime date, int startTime)
        {
            bool bookingExists = false;

            // Execute a SQL query to check if a booking exists
            // You should replace 'YourTableName' with the actual name of your booking table
            string query = $"SELECT COUNT(*) FROM buchung WHERE Ma_id = {maId} AND Date = '{date.ToString("yyyy-MM-dd")}' AND Start_time = {startTime}";

            // Execute the query and check the result
            using (MySqlConnection connection = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD='root';DATABASE=Friseur"))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // A booking with the same details exists
                        bookingExists = true;
                    }
                }
            }

            return bookingExists;
        }

 //--------------------------------------------------------------------------------------------------------



//----- BOOKING BTN-----------------------------------------------------------------
        private void button35_Click(object sender, EventArgs e) ///BOOKING BTN
        {
            if (string.IsNullOrEmpty(tbKUvname.Text) || string.IsNullOrEmpty(tbKUnname.Text) ||
                string.IsNullOrEmpty(MaName.Text) || string.IsNullOrEmpty(tbDate.Text) ||
                string.IsNullOrEmpty(tbTime.Text) || string.IsNullOrEmpty(tbETime.Text) ||
                string.IsNullOrEmpty(tbKUtel.Text) || string.IsNullOrEmpty(tbStyle.Text))
            {
                MessageBox.Show("Bitte füllen Sie alle Textfelder aus, bevor Sie die Buchung bestätigen.");
            }
            else
          {
                // All text boxes are filled, proceed with the confirmation logic
                // ...
                // Your booking confirmation logic here
           
            // Get the input values
            int maId = Convert.ToInt32(tbMAid.Text);
            DateTime date = Convert.ToDateTime(tbDate.Text);
            int startTime = Convert.ToInt32(tbTime.Text);

            //REFERENCES FUNCTION: Check if a booking with the same date, time, and employee number exists
            bool bookingExists = CheckBookingExists(maId, date, startTime);

            if (bookingExists)
            {
                // Show a message that the time slot is already booked
                MessageBox.Show("Dieser Zeitraum ist bereits gebucht. Bitte wählen Sie einen anderen aus.");
            }
            else
            {
               
         
            MessageBox.Show("Vielen Dank " + tbKUvname.Text + ", wir werden eine Erinnerungs-SMS an: "
                + tbKUtel.Text+ " eine Stunde vir dem Termin senden.");

            Buchung Buch = new Buchung();
            Kunde Kund = new Kunde();

            Buch.Bu_id = -1;
            Kund.Kunde_id = -1;     
            

            Buch.Start_time = Convert.ToInt32 (tbTime.Text);
            Buch.End_time = Convert.ToInt32(tbETime.Text);         
            Buch.Date = Convert.ToDateTime(tbDate.Text);

            Kund.Kunde_vorname = tbKUvname.Text;
            Kund.Kunde_nachname = tbKUnname.Text;
            Kund.Kunde_telefon = Convert.ToInt32(tbKUtel.Text);

            db.saveKunde(Kund);
            tbKUid.Text = "" + Kund.Kunde_id;

         
            Buch.Mitarbeiter_id = Convert.ToInt32(tbMAid.Text);
            Buch.Kunde_id = Convert.ToInt32(tbKUid.Text);
            Buch.Haarstil_id = Convert.ToInt32(tbHSid.Text);

            db.saveBuchung(Buch);
            tbBUid.Text = "" + Buch.Bu_id;

                Application.Exit();
            }
          }


        }
//----------------------------------------------------------------------------------
        private void label30_Click(object sender, EventArgs e)
        {

        }

//----------------------------------------------------------------------------------
        private void HaarstilAnzeigen()
        {
            LiHarst = db.getHaarstile();

            foreach (Haarstile Harst in LiHarst)
            {

                cbHaarstil.Items.Add(Harst.Hs_name);

            }

        }
        private void cbHaarstil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHaarstil.SelectedIndex >= 0)
            {
                int selectedIndex = cbHaarstil.SelectedIndex;

                // Retrieve the corresponding Mitarb object
                var selectedHarst = LiHarst[selectedIndex];

                // Display Mitarb_id in the other TextBox
                tbHSid.Text = selectedHarst.Hs_id.ToString();
            }
            else
            {
                // Handle the case when no item is selected
                tbHSid.Text = string.Empty; // Clear the TextBox
            }
        }

        private void tbKUvname_TextChanged(object sender, EventArgs e)
        {

        }

//------- ZURUCK BUTTON ----------------------------------------------------
        private void button3_Click(object sender, EventArgs e)
        {            
            Terrmin startPage = new Terrmin();       
            startPage.Show();         
            this.Close();
        }
    }

}
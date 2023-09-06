using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hairdressers
{
    public class Database
    {

        private MySqlConnection con;

        public Database()
        {
            con = new MySqlConnection("SERVER=localhost;UID=root;PASSWORD='root';DATABASE=Friseur");
        }


        //OpenClose Methods
        private void oeffnen()
        {

            con.Open();
        }
        private void schliessen()
        {
            if (con != null)
                con.Close();
        }



        //KUNDE 
        //--GET METHOD 
        public List<Kunde> getKunde()
        {
            List<Kunde> LiKund = new List<Kunde>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM Kunde;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                LiKund.Add(
                    new Kunde(
                       reader.GetInt32(0),
                        reader.GetString(1),
                         reader.GetString(2),
                         reader.GetInt32(3)
                         
                        )
                    );
            }
            schliessen();
            return LiKund;
        }

        //--SAVE KUNDE METHOD
        public void saveKunde(Kunde Kund)
        {

            oeffnen();

            string s = string.Format
            ("INSERT INTO Kunde VALUES (NULL, '{0}','{1}','{2}' );"
            , Kund.Kunde_vorname, Kund.Kunde_nachname,Kund.Kunde_telefon);


            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();
            Kund.Kunde_id = (int)com.LastInsertedId;

            schliessen();
        }
        //--DELETE KUNDE FROM DATABASE  
        public void delKunde(int Ku_Id)
        {

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "DELETE FROM Kunde WHERE ku_id = " + Ku_Id + ";";
            com.ExecuteNonQuery();

            schliessen();
        }
        //-----------------------------------------------------------------------------------------------


        //HAARSTIL 
        //--GET METHOD 
        public List<Haarstile> getHaarstile()
        {
            List<Haarstile> LiHarst = new List<Haarstile>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM haarstil;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                LiHarst.Add(
                    new Haarstile(
                       reader.GetInt32(0),
                        reader.GetString(1),
                         reader.GetDecimal(2),
                         reader.GetInt32(3)

                        )
                    );
            }
            schliessen();
            return LiHarst;
        }

        


        //--SAVE hs METHOD
        public void saveHaarstile(Haarstile Harst)
        {

            oeffnen();

            string s = string.Format
            ("INSERT INTO Haarstil VALUES (NULL, '{0}','{1}' ,'{2}');"
            , Harst.Hs_name, Harst.Hs_preis.ToString().Replace(',','.'), Harst.Hs_dauer);
            

            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        //--DELETE hs FROM DATABASE  
        public void delHaarstile(int hs_id)
        {

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "DELETE FROM haarstil WHERE hs_id = " + hs_id + ";";
            com.ExecuteNonQuery();

            schliessen();
        }

        //-----------------------------------------------------------------------------------------------

        //MITARBEITER
        //--GET METHOD 
        public List<Mitarbeiter> getMitarbeiter()
        {
            List<Mitarbeiter> LiMitarb = new List<Mitarbeiter>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM mitarbeiter;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                LiMitarb.Add(
                    new Mitarbeiter(
                       reader.GetInt32(0),
                        reader.GetString(1),                     
                         reader.GetInt32(2),
                          reader.GetString(3)


                        )
                    );
            }
            schliessen();
            return LiMitarb;
        }

        //--SAVE hs METHOD
        public void saveMitarbeiter(Mitarbeiter Mitarb)
        {

            oeffnen();

            string s = string.Format
            ("INSERT INTO Mitarbeiter VALUES (NULL, '{0}','{1}','{2}');"
            , Mitarb.Mitarb_name, Mitarb.Hs_id, Mitarb.MaPassword1);


            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();

            schliessen();
        }
        //--DELETE hs FROM DATABASE  
        public void delMitarbeiter(int ma_id)
        {

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "DELETE FROM mitarbeiter WHERE ma_id = " + ma_id + ";";
            com.ExecuteNonQuery();

            schliessen();
        }



        public Mitarbeiter checkMitarbeiter(string mitarb_name, string MaPassword)
        {

            string s = string.Format("select * from mitarbeiter where ma_name = '{0}' and password ='{1}'",
            mitarb_name, MaPassword);

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            MySqlDataReader reader = com.ExecuteReader();

            try
            {
                if 
                    (reader.Read())
                {
                    return new Mitarbeiter(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Passwort oder name falsch", "Fehler" + ex.Message);
            }
            finally
            {
                reader.Close();
                schliessen();
            }
            return null;

        }

        //-----------------------------------------------------------------------------------------------

        //BUCHUNG
        //--GET METHOD 
        public List<Buchung> getBuchung()
        {
            List<Buchung> LiBuch = new List<Buchung>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM buchung;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                LiBuch.Add(
                    new Buchung(
                       reader.GetInt32(0),
                       reader.GetInt32(1),                       
                         reader.GetInt32(2),                     
                             reader.GetDateTime(3),
                              reader.GetInt32(4),
                       reader.GetInt32(5),
                         reader.GetInt32(6)

                        )
                    );
            }
            schliessen();
            return LiBuch;
        }

        //--SAVE BUCHUNG METHOD
        public void saveBuchung(Buchung Buch)
        {

            oeffnen();

            string s = string.Format
            ("INSERT INTO buchung VALUES (NULL, '{0}','{1}','{2}','{3}','{4}','{5}');"
            , Buch.Start_time, Buch.End_time, Buch.Date.ToString("yyyy-MM-dd"), Buch.Mitarbeiter_id
            , Buch.Kunde_id, Buch.Haarstil_id);


            MySqlCommand com = con.CreateCommand();
            com.CommandText = s;
            com.ExecuteNonQuery();
            Buch.Bu_id = (int)com.LastInsertedId;

            schliessen();
        }
        //--DELETE BUCHUNG FROM DATABASE  
        public void delBuchung(int bu_id)
        {

            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "DELETE FROM buchung WHERE bu_id = " + bu_id + ";";
            com.ExecuteNonQuery();

            schliessen();
        }

        //------------------------------------------------------------------------------------
        //LOCATION-------------

        //--GET METHOD 
        public List<Location> getLocation()
        {
            List<Location> LiLocat = new List<Location>();
            oeffnen();

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM location;";
            MySqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                LiLocat.Add(
                    new Location(
                       reader.GetInt32(0),
                       reader.GetString(1),
                         reader.GetString(2)
                           
                        )
                    );
            }
            schliessen();
            return LiLocat;
        }







        public Location GetLocationByName(string locationName)
        {
            Location location = null;

            oeffnen(); // Open the database connection

            MySqlCommand com = con.CreateCommand();
            com.CommandText = "SELECT * FROM location WHERE loc_name = @locName";
            com.Parameters.AddWithValue("@locName", locationName);

            MySqlDataReader reader = com.ExecuteReader();

            if (reader.Read())
            {
                // Assuming your Location class constructor takes three parameters
                location = new Location(
                    reader.GetInt32(0),      // loc_id
                    reader.GetString(1),    // loc_name
                    reader.GetString(2)     // IsOpen (assuming it's a string)
                );
            }

            schliessen(); // Close the database connection

            return location;
        }






















    }
}

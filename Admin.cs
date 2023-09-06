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
    public partial class Admin : Form
    {
        private Database db = new Database();//zugriff zum datenbank
        private List<Mitarbeiter> LiMitarb;
        private List<Haarstile> LiHarst;
        private List<Buchung> LiBuch;
        private List<Kunde> LiKund;
        public Admin()
        {
            InitializeComponent();


        }

        private void Admin_Load(object sender, EventArgs e)
        {
            HaarstilAnzeigen();
            textBox8.Clear();
            textBox9.Clear();
            textBox14.Clear();
            textBox7.Clear();

            MitarbeiterAnzeigen();
            tbMAid.Clear();
            tbMAname.Clear();
            tbHSid.Clear();

            BuchungAnzeigen();
            tbBUid.Clear();
            tbMAidd.Clear();
            tbHSidd.Clear();
            tbKUidd.Clear();
            tbEnd.Clear();
            tbDate.Clear();
            tbStart.Clear();

            KundeAnzeigen();
            tbKUID.Clear();
            tbKUNAME.Clear();
            tbKUNNAME.Clear();
            tbKUTEL.Clear();

        }

        //MITARTBEITER GROUPBOX_________________________


        //ANZEIGEN () 
        /*   private void MitarbAnzeigen()
           {
               LiMitarb = db.getMitarbeiter();

               foreach (Mitarbeiter ma in LiMitarb)
               {
                   //textBoxHerstId.Text = he.Herst_ID1.ToString();
                   // tbHerstName.Text = he.Herst_Name1;


                   //comboBox1.Items.Add(he.Herst_Name1);

                   dataGridView1.Rows.Add(ma.Mitarb_id);


               }

           }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMAid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbMAname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbHSid.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            
        }
        //________________________________HAARSTIL______________________________________________


        //ANZEIGEN () 
        private void HaarstilAnzeigen()
        {
            LiHarst = db.getHaarstile();

            foreach (Haarstile Harst in LiHarst)
            {

                textBox8.Text = Harst.Hs_id.ToString();
                textBox9.Text = Harst.Hs_name;
                textBox14.Text = Harst.Hs_preis.ToString("#0.00");
                textBox7.Text = Harst.Hs_dauer.ToString();

                dataGridView3.Rows.Add(Harst.Hs_id,Harst.Hs_name,Harst.Hs_preis.ToString("#0.00"), Harst.Hs_dauer);

                //comboBox1.Items.Add(Harst.Hs_name);
            }
        }
        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox14.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            
        }
        private void button6_Click(object sender, EventArgs e)//SAVE BUTTON HAARSTIL
        {
            Haarstile Harst = new Haarstile();
            Harst.Hs_id = -1;
            Harst.Hs_name = textBox9.Text;
            Harst.Hs_preis = Convert.ToDecimal(textBox14.Text);
            Harst.Hs_dauer = Convert.ToInt32(textBox7.Text);

            db.saveHaarstile(Harst);

            HaarstilAnzeigen();
            textBox8.Clear();
            textBox9.Clear();
            textBox14.Clear();
            textBox7.Clear();


          

        }
        private void button5_Click(object sender, EventArgs e)//DELETE BTN HAARSTIL
        {
            string hs_Id = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            int which = Convert.ToInt32(hs_Id);

            db.delHaarstile(which);

            HaarstilAnzeigen();

        }

      
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        //MITARBEITER GROUPBOX___________________________________________________

        //ANZEIGEN () 
        private void MitarbeiterAnzeigen()
        {
            LiMitarb = db.getMitarbeiter();

            foreach (Mitarbeiter Mitarb in LiMitarb)
            {

                tbMAid.Text = Mitarb.Mitarb_id.ToString();
                tbMAname.Text = Mitarb.Mitarb_name;
                tbHSid.Text = Mitarb.Hs_id.ToString();
                

                dataGridView1.Rows.Add(Mitarb.Mitarb_id,Mitarb.Mitarb_name, Mitarb.Hs_id);

                //comboBox1.Items.Add(Harst.Hs_name);
            }
        }
        private void MAsaveBTN_Click(object sender, EventArgs e)//SAVE BUTTON MITARBEITER
        {
            Mitarbeiter Mitarb = new Mitarbeiter();
            Mitarb.Mitarb_id = -1;
            Mitarb.Mitarb_name = tbMAname.Text;
            Mitarb.Hs_id = Convert.ToInt32(tbHSid.Text);
            Mitarb.MaPassword1 = tbPassword.Text;



            db.saveMitarbeiter(Mitarb);

        
            tbMAid.Clear();
            tbMAname.Clear();
            tbHSid.Clear();
            tbPassword.Clear();


        }
        private void MAdelBTN_Click(object sender, EventArgs e)//DELETE BUTTON MITARBEITER
        {
            string ma_Id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            int which = Convert.ToInt32(ma_Id);

            db.delMitarbeiter(which);

          MitarbeiterAnzeigen();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }   
        private void lbName_Click(object sender, EventArgs e)
        {
            
        }



        //BUCHUNG GROUPBOX___________________________________________________

        //ANZEIGEN () 

        private void BuchungAnzeigen()
        {
            LiBuch = db.getBuchung();

            foreach (Buchung Buch in LiBuch)
            {

                tbBUid.Text = Buch.Bu_id.ToString();              
                tbMAidd.Text = Buch.Mitarbeiter_id.ToString();
                tbHSidd.Text = Buch.Haarstil_id.ToString();
                tbKUidd.Text = Buch.Kunde_id.ToString();
                tbStart.Text = Buch.Start_time.ToString();
                tbEnd.Text = Buch.End_time.ToString();
                tbDate.Text = Buch.Date.ToString();


                dataGridView4.Rows.Add(Buch.Bu_id,Buch.Mitarbeiter_id,Buch.Haarstil_id,
                    Buch.Kunde_id, Buch.Start_time, Buch.End_time, Buch.Date);

                //comboBox1.Items.Add(Harst.Hs_name);
            }
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbBUid.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            tbMAidd.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            tbHSidd.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            tbKUidd.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            tbStart.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            tbEnd.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
            tbDate.Text = dataGridView4.CurrentRow.Cells[6].Value.ToString();
            
        }


        //____KUNDE______________________________________________


        //ANZEIGEN () 
        private void KundeAnzeigen()
        {
            LiKund = db.getKunde();

            foreach (Kunde Kund in LiKund)
            {

               tbKUID.Text = Kund.Kunde_id.ToString();
                tbKUNAME.Text = Kund.Kunde_vorname;
                tbKUNNAME.Text = Kund.Kunde_nachname;
                tbKUTEL.Text = Kund.Kunde_telefon.ToString();


                dataGridView2.Rows.Add(Kund.Kunde_id,Kund.Kunde_vorname, Kund.Kunde_nachname, Kund.Kunde_telefon);

                
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbKUID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            tbKUNAME.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            tbKUNNAME.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            tbKUTEL.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

       
    }
}

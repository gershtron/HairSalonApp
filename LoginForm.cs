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
    public partial class LoginForm : Form
    {
        private Database db = new Database();

        public Mitarbeiter mitarbeiter = null;
//---------------------------------------------------------------
        public string UserName
        {
            get { return tbMAname.Text; }
        }
//----------------------------------------------------------------
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterBTN_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != " " && tbMAname.Text != " ")
            {

                mitarbeiter = db.checkMitarbeiter(tbMAname.Text, tbPassword.Text);
                if (mitarbeiter == null)

                    MessageBox.Show("Passwort oder name falsch", "Fehler");

                else
                {
                    MessageBox.Show("welcome "+ tbMAname.Text );

                    this.Close();

                    Admin AForm = new Admin();
                    AForm.Show();

                    
                }
            }
            
            else
            {
                MessageBox.Show("Bitte Name und passwort eingeben", "Achtung");
            }
        }

        private void lbShow_Click(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (tbPassword.PasswordChar == '*')
            {
                tbPassword.PasswordChar = '\0'; // Show the password in plain text
            }
            else
            {
                tbPassword.PasswordChar = '*';  // Show stars for the password
            }
        }
    }
}

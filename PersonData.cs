using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Person_Data
{
    public partial class PersonData : Form
    {
        public PersonData()
        {
            InitializeComponent();
        }

        private void labal_titla_Click(object sender, EventArgs e)
        {

        }

        private void PersonData_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }

        /// <summary>
        /// //check by id with add person 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool Check(string id)
        {
            using (StreamReader strreader = new StreamReader("personData.txt"))
            {
                string line;
                while ((line = strreader.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    if (data[0] == id)
                    {
                        return false; // ID already exists
                    }
                }
            }
            return true; // ID does not exist
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDtext.Text.Trim()==""|| Nametext.Text.Trim()==""|| Addresstext.Text.Trim()=="")
                {
                    MessageBox.Show("Pleas Enter All Data.");
                    return;
                }

                if (Check(IDtext.Text.ToString()))
                {

                    StreamWriter strWriter = new StreamWriter("personData.txt", true);
                        strWriter.WriteLine($"{IDtext.Text};{Nametext.Text};{Addresstext.Text}");
                        strWriter.Close();

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = string.Empty;
                        }
                    }
                    MessageBox.Show("Add The New Person.");
                    IDtext.Focus();
                }
                else
                {
                    MessageBox.Show("This person already exists.");
                    IDtext.Focus();
                    IDtext.SelectAll();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private string[] find(string id)
        {
            using (StreamReader strreader = new StreamReader("personData.txt"))
            {
                string line;
                while ((line = strreader.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    if (data[0] == id)
                    {
                        return data; // ID already exists
                    }
                }
            }
            return null ;
        }

        private void btnfFind_Click(object sender, EventArgs e)
        {

            try
            {
                if (IDtext.Text.Trim() == "")
                {
                    MessageBox.Show("Pleas Enter The Id.");
                    IDtext.Focus();
                    return;
                }
                string[] data = find(IDtext.Text.ToString());
                if (data != null)
                {
                    Nametext.Text = data[1];
                    Addresstext.Text = data[2];
                }
                else
                {
                    MessageBox.Show("Not Found This Person.");
                    IDtext.Focus();
                    IDtext.SelectAll();
                    Nametext.Text = string.Empty;
                    Addresstext.Text = string.Empty;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        private void butShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                Form showallform = new Form();
                showallform.Text = "All Data";
                showallform.Size = this.Size;
                showallform.Font = this.Font;
                showallform.ForeColor = this.ForeColor;
                showallform.StartPosition = FormStartPosition.CenterScreen;
                showallform.Icon = this.Icon;

                //textbox
                TextBox textshow = new TextBox();
                textshow.Multiline = true;// hna ana bolh hy ale texbox dh hykon stor kter
                textshow.Dock = DockStyle.Fill;// hna ana bolh an ale texbox hymla ale form kolh 


                StreamReader strreader = new StreamReader("personData.txt");
                string data = strreader.ReadToEnd();
                strreader.Close();
                textshow.Text = data;
                showallform.Controls.Add(textshow);

                showallform.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }


        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
                if(IDtext.Text.Trim()==""|| Nametext.Text.Trim()==""|| Addresstext.Text.Trim()==""||picture.Image==null)
                {
                    MessageBox.Show("Pleas Enter All Data.");
                    return;
                }

                if (Check(IDtext.Text.ToString()))
                {

                    StreamWriter strWriter = new StreamWriter("personData.txt", true);
                        strWriter.WriteLine($"{IDtext.Text};{Nametext.Text};{Addresstext.Text}");
                        strWriter.Close();
                    if (!Directory.Exists("img"))
                        Directory.CreateDirectory("img");
                  
                    picture.Image.Save("img/" + IDtext.Text +".jpg");

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = string.Empty;
                        }
                    }
                    picture.Image = null;
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
                // Check if the ID text box is empty
                if (IDtext.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter The Id.");
                    IDtext.Focus();
                    return;
                }

                // Find the data for the given ID
                string[] data = find(IDtext.Text.Trim());

                if (data != null)
                {
                    // Construct the image file path
                    string imgPath = Path.Combine("img", IDtext.Text +".jpg");
                
                    // Check if the image file exists before loading it
                    if (File.Exists(imgPath))
                    {
                        picture.Image = Image.FromFile(imgPath);
                    }
                    else
                    {
                        MessageBox.Show("Image file not found.");
                        picture.Image = null;
                    }

                    // Populate text fields with found data
                    Nametext.Text = data[1];
                    Addresstext.Text = data[2];
                }
                else
                {
                    // Notify the user that the person was not found
                    MessageBox.Show("Not Found This Person.");
                    IDtext.Focus();
                    IDtext.SelectAll();
                    Nametext.Text = string.Empty;
                    Addresstext.Text = string.Empty;
                    picture.Image = null; // Clear the picture box
                }
            }
            catch (Exception ex)
            {
                // Show the error message
                MessageBox.Show($"An error occurred: {ex.Message}");
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

        private void butSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            of.Filter = "PNG File|*.jpg;*.png;*.gif;*.bmp";
            if (of.ShowDialog() == DialogResult.OK)
            {
                picture.Image=Image.FromFile(of.FileName);
                picture.ImageLocation = of.FileName;
            }
        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void ShowAllWithPhoto_Click(object sender, EventArgs e)
        {



            try
            {
                // Create a new Form
                Form showall = new Form();
                showall.Text = "Show All Data";
                showall.StartPosition = FormStartPosition.CenterScreen;
                showall.Size = new Size(600, 400); // Example size, adjust as needed
                showall.Icon = this.Icon;

                // Create a Panel to host TextBoxes and PictureBoxes with auto-scroll
                Panel panel = new Panel();
                panel.Dock = DockStyle.Fill;
                panel.AutoScroll = true;
                showall.Controls.Add(panel);

                // Create a StreamReader to read from the file
                using (StreamReader str = new StreamReader("personData.txt"))
                {
                    string line;
                    int y = 20; // Starting Y position for TextBoxes and PictureBoxes

                    // Read each line from the file
                    while ((line = str.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');
                        if (data.Length >= 3)
                        {
                            // Create and configure the PictureBox
                            PictureBox pb = new PictureBox();
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            pb.Size = new Size(50, 50); // Adjust size as needed
                            pb.Location = new Point(20, y);

                            try
                            {
                                pb.Image = Image.FromFile(@"img/" + data[0] + ".jpg");
                            }
                            catch (FileNotFoundException)
                            {
                                pb.Image = null; // Or set a default image
                            }

                            // Create and configure the TextBox
                            TextBox tx = new TextBox();
                            tx.Font = this.Font;
                            tx.Multiline = true;
                            tx.ReadOnly = true;
                            tx.Text = "ID: " + data[0] + "\r\nName: " + data[1] + "\r\nAddress: " + data[2];
                            tx.Size = new Size(panel.ClientSize.Width - 100, 50); // Adjust size as per the panel
                            tx.Location = new Point(80, y);

                            // Add PictureBox and TextBox to the Panel
                            panel.Controls.Add(pb);
                            panel.Controls.Add(tx);

                            // Increase Y position for the next set of controls
                            y += 60; // Adjust spacing as needed
                        }
                    }
                }

                // Show the form as a dialog
                showall.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}

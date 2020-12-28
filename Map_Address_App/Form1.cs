using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map_Address_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string street = StreetTextBox.Text;
            string city = CityTextBox.Text;
            string state = StateTextBox.Text;
            string zipcode = ZipCodeTextBox.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?q=");

                //Street
                if (street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }

                //City
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }

                //State
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                }

                //ZipCode
                if (zipcode != string.Empty)
                {
                    queryData.Append(zipcode + "," + "+");
                }

                //This navigates the web browser window to the queryData web address
                WebBrowserWindow.Navigate(queryData.ToString());

            }

            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Eror");
            }
        }
    }
}

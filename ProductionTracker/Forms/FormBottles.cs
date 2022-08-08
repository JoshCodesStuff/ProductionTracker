using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace ProductionTracker.Forms
{
    public partial class FormBottles : Form
    {
        private DBControlMySQL database = new DBControlMySQL();
        private DateTime date; 
        private float startTime, endTime, amount;
        private string product; 

        public FormBottles()
        {
            InitializeComponent();
        }

        private void product_elements_DBGrab()
        {
            database.ExecQuery("select P_NAME from Products");
            if (!String.IsNullOrEmpty(database.exceptions)) { MessageBox.Show(database.exceptions); }

            /* Fill combobox */
            foreach (DataRow R in database.dbdt.Rows)
                productSelectComBox.Items.Add(R["P_NAME"]);
        }

        private void production_stats_DBGrab()
        {
            database.ExecQuery("select * from Bottling_Records");

            dgvData.DataSource = database.dbdt;
        }

        private void bottles_type_DBGrab()
        {
            database.ExecQuery("select NAME from Bottles");

            foreach (DataRow R in database.dbdt.Rows)
                bottlesCbx.Items.Add(R["NAME"]);
        }

        private void startTxtBox_TextChanged(object sender, EventArgs e)
        {
            startTime = float.Parse(startTxtBox.Text);
        }

        private void endTxtBox_TextChanged(object sender, EventArgs e)
        {
            endTime = float.Parse(endTxtBox.Text);
        }

        private void amountTxtBox_TextChanged(object sender, EventArgs e)
        {
            amount = float.Parse(amountTxtBox.Text);
        }

        /* leaving space here for graphs and other measuring displays & tools */

        /* handles sending data to database */

        private void production_stats_DBSend()
        {
            float totalTime = (endTime > 12f) ? (endTime - startTime) : ((endTime + 12f) - startTime);

            float runEff = amount / totalTime;
            float maxEff = 6800 / totalTime;
            float efficiency = runEff / maxEff;

            if (date == null)
            {
                date = datePicker.Value.Date;
                MessageBox.Show("Date = " + date.ToLongDateString());
            }
            try
            {
                string accessQuery = "INSERT INTO Production_Bottling VALUES ("
                + date.ToLongDateString()
                + startTime.ToString()
                + endTime.ToString()
                + productSearchCB.SelectedValue.ToString()
                + amount.ToString()
                + bottlesCbx.SelectedValue.ToString()
                + totalTime.ToString()
                + efficiency.ToString()
                + ")";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Input Error");
                throw;
            }
        }

        private void btnInsertToDB_Click(object sender, EventArgs e)
        {
            production_stats_DBSend();
            production_stats_DBGrab();
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            date = datePicker.Value.Date;
            MessageBox.Show("Date = ", date.ToLongDateString());
        }
        
        /* OnLoad() */
        private void FormBottles_Load(object sender, EventArgs e)
        {
            product_elements_DBGrab();
            bottles_type_DBGrab();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace A_Waddell_Lab_3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        // get the connection string of doom
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\StatesDB.mdf;Integrated Security=True";

        private void stateDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.StateData' table. You can move, or remove it, as needed.
            this.stateDataTableAdapter.Fill(this.statesDBDataSet.StateData);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Details details = new Details(); // declare new instance
            details.ShowDialog(); // open the details form
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            this.stateDataTableAdapter.FillByStateNameSort(this.statesDBDataSet.StateData); // sort by names
        }

        private void btnSortFlower_Click(object sender, EventArgs e)
        {
            this.stateDataTableAdapter.FillBySortFlower(this.statesDBDataSet.StateData); // sort by FLOWER
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            // lets get the state name first
            string selectedState = lBoxNames.SelectedItem.ToString();
            string sqlSearchQuery = "SELECT * FROM dbo.StateData WHERE StateName = @stateName;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSearchQuery, conn))
                {
                    // put this up in the string. its like inserting with control f
                    cmd.Parameters.AddWithValue("@stateName", selectedState);

                    DataTable dt = new DataTable();

                    conn.Open(); // open the connection so it can actually Run The Thing
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // load the new table data up
                        dt.Load(reader);
                    }

                    // assign/put dt into the table so its viewable
                    stateDataDataGridView.DataSource = dt; // in hindsight what in the ?ploo is that name
                }
            }
        }

        private void btnSortCompJob_Click(object sender, EventArgs e)
        {
            this.stateDataTableAdapter.FillBySortCompJobs(this.statesDBDataSet.StateData); // sort by computer job percentage
        }

        private void btnSortBird_Click(object sender, EventArgs e)
        {
            this.stateDataTableAdapter.FillBySortBird(this.statesDBDataSet.StateData); // sort by bird
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }
    }
}

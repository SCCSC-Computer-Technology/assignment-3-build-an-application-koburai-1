using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Waddell_Lab_3
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }

        private void stateDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stateDataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }

        private void Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.StateData' table. You can move, or remove it, as needed.
            this.stateDataTableAdapter.Fill(this.statesDBDataSet.StateData);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        
        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.StreetAddress);
        }

        private void addressesListLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

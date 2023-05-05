using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace WinFormMiniProject
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        
        public PersonEntry()
        {
            InitializeComponent();

            addresses.Add(new AddressModel { StreetAddress ="123 Fake St.", City = "Scranton", State = "PA", ZipCode = "123456"});

            addressesList.DataSource = addresses;
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue);
        }

        
        private void addNewAddresses_Click(object sender, EventArgs e)
        {
            AddressModel newAddress = new AddressModel();
            //Open the address entry form
            AddressEntry entry = new AddressEntry();

            entry.Show();
        }


        public void SaveAddress(AddressModel address)
        {
            address.Add(address);
        }
    }
}

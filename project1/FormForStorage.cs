using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class FormForStorage : Form
    {
        string productList;
        Login_token tokens_info;
        public FormForStorage(Login_token tokens, string json)
        {
            InitializeComponent();
            productList = json;
            tokens_info = tokens;

            JArray pArray = JArray.Parse(productList);

            IList<Product> result = pArray.Select(p => new Product
            {
                id = (string)p["id"],
                store = (string)p["store"],
                qrcode = (string)p["product"]["qrcode"],
                name = (string)p["product"]["name"],
                description = (string)p["product"]["desciption"],
                base_unit = (string)p["product"]["base_unit"],
                price = (string)p["product"]["price"],
                picture_path = (string)p["product"]["picture_path"],
                category = (string)p["product"]["category"],
                quantity = (string)p["quantity"],
                active = (string)p["active"]
            }).ToList();

            int numberOfProducts = result.Count;

            
            for (int index = 0; index < numberOfProducts; ++index)
            {

                ListViewItem item = new ListViewItem();
                // items[0].Tag = result.ElementAt(0);
                productBox.Items.Add(item);

                item.Text = result.ElementAt(index).qrcode;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).name });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).price });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).base_unit });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).category });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).quantity });

            }
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

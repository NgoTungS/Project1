using Newtonsoft.Json;
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
    public partial class ProductTable : Form
    {
        string selected_qrcode;
        string productList;
        Login_token tokens_info;
        IList<Product> temp;


        public ProductTable(Login_token tokens,string json)
        {
            InitializeComponent();
            
            
            productList = json;

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

            temp = result;

            //resultBox.Text = productList;
            tokens_info = tokens;
            intro.Text = "Welcome " + tokens.username;

            // BAT DAU TAI DAY, DE XU LI STRING
            // hien thi san pham
            
            int numberOfProducts = result.Count;

            // DANG CODE O DAY


            //while (numberOfProducts >= 0)
            for (int index = 0; index < numberOfProducts; ++index)
            {

                ListViewItem item = new ListViewItem();
                // items[0].Tag = result.ElementAt(0);
                ProductBox.Items.Add(item);

                item.Text = result.ElementAt(index).qrcode;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).name });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).price });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).base_unit });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).category });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).description });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = result.ElementAt(index).quantity });

            }

        }

       

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Chon 1 san pham
        private void ProductBox_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = ProductBox.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {

                

                selected_qrcode = qrcode_input.Text = item.Text;
                for (int index = 0; index < temp.Count; ++index)
                {
                    if (temp.ElementAt(index).qrcode == selected_qrcode)
                    {
                        string name = temp.ElementAt(index).name;
                        string price = temp.ElementAt(index).price;
                        string quantity = temp.ElementAt(index).quantity;
                        resultBox.Text = "Tên sản phẩm: " + name;
                        resultBox.AppendText(Environment.NewLine);
                        resultBox.AppendText("Giá: " + price);
                        resultBox.AppendText(Environment.NewLine);
                        resultBox.AppendText("Số lượng: " + quantity);

                        break;
                    }
                }

            }
            /*else
            {
                this.listView1.SelectedItems.Clear();
                resultBox.Text = "No Item is Selected";
            }*/
        }

        private void qrcode_input_TextChanged(object sender, EventArgs e)
        {
            selected_qrcode = qrcode_input.Text;
            for (int index = 0; index < temp.Count; ++index)
            {
                if (temp.ElementAt(index).qrcode == selected_qrcode)
                {
                    string name = temp.ElementAt(index).name;
                    string price = temp.ElementAt(index).price;
                    string quantity = temp.ElementAt(index).quantity;
                    resultBox.Text = "Tên sản phẩm: " + name;
                    resultBox.AppendText(Environment.NewLine);
                    resultBox.AppendText("Giá: " + price);
                    resultBox.AppendText(Environment.NewLine);
                    resultBox.AppendText("Số lượng: " + quantity);

                    break;
                }
            }
        }
    }
}

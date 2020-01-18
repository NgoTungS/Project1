using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace project1
{
    public partial class Form1 : Form
    {
        // variables
        Login_token tokens_info = new Login_token();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void pass_input_TextChanged(object sender, EventArgs e)
        {
            tokens_info.pass = pass_input.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // dang nhap va lay access token cho nhung lan truy cap sau
            var client = new RestClient("https://phamthoai-store-management.herokuapp.com/api/token/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\"username\": \"" + tokens_info.username + "\",\"password\": \"" + tokens_info.pass + "\"}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode.ToString() != "OK")
            {
                status.Visible = true;
                status.Text = "Login failed";
            }
            else
            {
                // Neu dang nhap thanh cong, chuyen sang trang hien thi tat ca san pham cua store

                string json = response.Content;
                
                Login_token tokens = JsonConvert.DeserializeObject<Login_token>(json);
                tokens_info.access = tokens.access;
                tokens_info.refresh = tokens.refresh;

                var client1 = new RestClient("https://phamthoai-store-management.herokuapp.com/api/stores/products/");
                client1.Timeout = -1;
                var request1 = new RestRequest(Method.GET);
                request1.AddHeader("Authorization", "Bearer " + tokens.access);
                IRestResponse response1 = client1.Execute(request1);

                if (response1.StatusCode.ToString() != "OK")
                {
                    string error_text = response1.Content;
                    if (response1.StatusCode.ToString() == "Unauthorized")
                    {
                        error_text = "Given token not valid for any token type";
                    }
                    if (response1.StatusCode.ToString() == "BadRequest")
                    {
                        error_text = "You have not permission!";
                    }

                    status.Visible = true;
                    status.Text = "Can't access to the store products, " + error_text;
                }
                else
                {
                    var client2 = new RestClient("https://phamthoai-store-management.herokuapp.com/api/users/check_permissions/");
                    client2.Timeout = -1;
                    var request2 = new RestRequest(Method.GET);
                    request2.AddHeader("Authorization", "Bearer " + tokens_info.access);
                    
                    IRestResponse response2 = client2.Execute(request2);

                    string json2 = response2.Content;
                    PermissionCheck check = JsonConvert.DeserializeObject<PermissionCheck>(json2);
                    

                    string json1 = response1.Content;

                    

                    if (check.import_invoice == "false")
                    {
                        ProductTable pTable = new ProductTable(tokens_info, json1);

                        username_input.Text = pass_input.Text = "";
                        //this.Hide();
                        pTable.ShowDialog();
                        //this.Show();
                        //HTTPresponseBox.Text = response1.Content;
                    }
                    else
                    {
                        FormForStorage pStrorage = new FormForStorage(tokens_info, json1);
                        username_input.Text = pass_input.Text = "";
                        pStrorage.ShowDialog();
                    }



                }


            }


            
        }

        private void username_input_TextChanged(object sender, EventArgs e)
        {
            tokens_info.username = username_input.Text;
            
        }
    }
}

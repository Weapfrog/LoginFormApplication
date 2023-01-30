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
using Login_Form_App.Core;

namespace Login_Form_App
{
    public partial class Form1 : Form
    {
        IDatabaseHelper helper;
        public Form1()
        {
            InitializeComponent();
            Setup();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            IsValidLogin();
        }

        #region Functions
        private void Setup()
        {
            this.helper = new DatabaseHelper();
            IsValidDelete();
            textBoxUsername.MaxLength = 20;
            textBoxPW.MaxLength = 20;
            textBoxProductCategory.MaxLength = 20;
            textBoxProductName.MaxLength = 20;
            textBoxSearch.MaxLength = 20;
        }
        private void Search()
        {
            string value = textBoxSearch.Text;
            var response = helper.Search(value,comboBoxSearch.SelectedIndex);
            MessageBox.Show(response.Message);
            dataGridViewSearch.DataSource = response.db;
        }
        private void GetAll()
        {
            string value = "";
            var response = helper.Search(value,0);
            dataGridViewSearch.DataSource = response.db; 
        }
        private void Login()
        {
            Dictionary<string, dynamic> user = new Dictionary<string, dynamic>();
            user.Add("Username", textBoxUsername.Text);
            user.Add("Password", textBoxPW.Text);
            var response = helper.GetLogin(user);
            if (response.Success == true)
            {
                MessageBox.Show(response.Message);
                textBoxUsername.Clear();
                textBoxPW.Clear();
                tabControl1.SelectedIndex++;
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Add(tabPage2);
                GetAll();
                IsValidProduct();
            }
            else
                MessageBox.Show(response.Message);

        }
        private void Signup()
        {
            if (textBoxUsername.Text != "" && textBoxPW.Text != "")
            {
                Dictionary<string, dynamic> user = new Dictionary<string, dynamic>();
                user.Add("Username", textBoxUsername.Text);
                user.Add("Password", textBoxPW.Text);
                var response = helper.Insert(user);
                MessageBox.Show(response.Message);
            }
            else
            {
                MessageBox.Show("You can't leave username and password spaces blank.");
            }

        }
        private void InsertProduct()
        {
            Dictionary<string, dynamic> product = new Dictionary<string, dynamic>();
            product.Add("ProductName",textBoxProductName.Text);
            product.Add("ProductCategory",textBoxProductCategory.Text);
            var response = helper.InsertProduct(product);
            MessageBox.Show(response.Message);
            GetAll();
        }
        private void Delete()
        {
            int rowindex, columnindex,value;

            foreach (DataGridViewRow item in dataGridViewSearch.SelectedRows)
            {
                rowindex = item.Index;
                columnindex = dataGridViewSearch.SelectedCells[0].ColumnIndex;
                value = Convert.ToInt32(dataGridViewSearch.Rows[rowindex].Cells[columnindex].Value);
                dataGridViewSearch.CurrentCell.Selected = false;
                var response = helper.DeleteSelected(value);
            }
            GetAll();
        }
        private void LogOut()
        {
            tabControl1.TabPages.Add(tabPage1);
            tabControl1.TabPages.Remove(tabPage2);
            comboBoxSearch.SelectedIndex = 0;
            textBoxSearch.Clear();
        }
        private void IsValidLogin()
        {
            if(string.IsNullOrEmpty(textBoxUsername.Text) || string.IsNullOrEmpty(textBoxPW.Text))
            {
                girisYap.Enabled = false;
                saveBtn.Enabled = false;
                
            }
            else
            {
                girisYap.Enabled = true;
                saveBtn.Enabled = true;
            }
            
        }
        private void IsValidProduct()
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text) || string.IsNullOrEmpty(textBoxProductCategory.Text))
            {
                addProductBtn.Enabled = false;
            }
            else
            {
                addProductBtn.Enabled = true;
            }

        }
        private void IsValidDelete()
        {
            if (dataGridViewSearch.SelectedRows.Count < 1)
            {
                deleteBtn.Enabled = false;
            }
            else
            {
                deleteBtn.Enabled = true;
            }
        }

        #endregion

        #region Buttons
        private void girisYap_Click_1(object sender, EventArgs e)
        {
            Login();
        }
        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            Signup();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            addProductBtn.Enabled = false;
            if (textBoxProductName.Text != "" && textBoxProductCategory.Text != "")
            {
                InsertProduct();
                textBoxProductName.Clear();
                textBoxProductCategory.Clear();
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }

        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteBtn.Enabled = false;
            Delete();
        }
        #endregion
   
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            IsValidLogin();
        }
        private void textBoxPW_TextChanged(object sender, EventArgs e)
        {
            IsValidLogin();
        }
        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
            IsValidProduct();
        }
        private void textBoxProductCategory_TextChanged(object sender, EventArgs e)
        {
            IsValidProduct();
        }
        private void dataGridViewSearch_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IsValidDelete();
        }
        private void dataGridViewSearch_Click(object sender, EventArgs e)
        {
            IsValidDelete();
        }
        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                girisYap.PerformClick();
        }
        private void textBoxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                girisYap.PerformClick();
        }
        private void textBoxProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addProductBtn.PerformClick();
        }
        private void textBoxProductCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                addProductBtn.PerformClick();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

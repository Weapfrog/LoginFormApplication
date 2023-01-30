
namespace Login_Form_App
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.userNameLBL = new System.Windows.Forms.Label();
            this.girisYap = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.seperator = new System.Windows.Forms.Label();
            this.searchBy = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productCategory = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.textBoxProductCategory = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.welcomeLBL);
            this.tabPage1.Controls.Add(this.saveBtn);
            this.tabPage1.Controls.Add(this.userNameLBL);
            this.tabPage1.Controls.Add(this.girisYap);
            this.tabPage1.Controls.Add(this.textBoxUsername);
            this.tabPage1.Controls.Add(this.passwordLbl);
            this.tabPage1.Controls.Add(this.textBoxPW);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(911, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LOGIN";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Location = new System.Drawing.Point(428, 84);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(116, 22);
            this.welcomeLBL.TabIndex = 12;
            this.welcomeLBL.Text = "WELCOME!";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(418, 265);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(136, 31);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "SIGN UP";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click_1);
            // 
            // userNameLBL
            // 
            this.userNameLBL.AutoSize = true;
            this.userNameLBL.Location = new System.Drawing.Point(311, 137);
            this.userNameLBL.Name = "userNameLBL";
            this.userNameLBL.Size = new System.Drawing.Size(104, 22);
            this.userNameLBL.TabIndex = 8;
            this.userNameLBL.Text = "Username";
            // 
            // girisYap
            // 
            this.girisYap.Location = new System.Drawing.Point(418, 228);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(136, 31);
            this.girisYap.TabIndex = 10;
            this.girisYap.Text = "LOG IN";
            this.girisYap.UseVisualStyleBackColor = true;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click_1);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(418, 134);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(136, 29);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(311, 184);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(103, 22);
            this.passwordLbl.TabIndex = 9;
            this.passwordLbl.Text = "Password";
            // 
            // textBoxPW
            // 
            this.textBoxPW.Location = new System.Drawing.Point(418, 181);
            this.textBoxPW.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(136, 29);
            this.textBoxPW.TabIndex = 7;
            this.textBoxPW.TextChanged += new System.EventHandler(this.textBoxPW_TextChanged);
            this.textBoxPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPW_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.seperator);
            this.tabPage2.Controls.Add(this.searchBy);
            this.tabPage2.Controls.Add(this.comboBoxSearch);
            this.tabPage2.Controls.Add(this.logoutBtn);
            this.tabPage2.Controls.Add(this.deleteBtn);
            this.tabPage2.Controls.Add(this.productCategory);
            this.tabPage2.Controls.Add(this.productName);
            this.tabPage2.Controls.Add(this.addProductBtn);
            this.tabPage2.Controls.Add(this.textBoxProductCategory);
            this.tabPage2.Controls.Add(this.textBoxProductName);
            this.tabPage2.Controls.Add(this.textBoxSearch);
            this.tabPage2.Controls.Add(this.searchBtn);
            this.tabPage2.Controls.Add(this.dataGridViewSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(911, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DATABASE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.Location = new System.Drawing.Point(-128, 242);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(1594, 22);
            this.seperator.TabIndex = 12;
            this.seperator.Text = "_________________________________________________________________________________" +
    "_______________________________________________________________";
            // 
            // searchBy
            // 
            this.searchBy.AutoSize = true;
            this.searchBy.Location = new System.Drawing.Point(7, 282);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(121, 22);
            this.searchBy.TabIndex = 11;
            this.searchBy.Text = "SEARCH BY";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Items.AddRange(new object[] {
            "Name",
            "Category"});
            this.comboBoxSearch.Location = new System.Drawing.Point(134, 279);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(101, 29);
            this.comboBoxSearch.TabIndex = 10;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(705, 404);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(114, 35);
            this.logoutBtn.TabIndex = 9;
            this.logoutBtn.Text = "LOG OUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(465, 204);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 35);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = true;
            this.productCategory.Location = new System.Drawing.Point(461, 67);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(223, 22);
            this.productCategory.TabIndex = 7;
            this.productCategory.Text = "PRODUCT CATEGORY:";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(461, 25);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(173, 22);
            this.productName.TabIndex = 6;
            this.productName.Text = "PRODUCT NAME:";
            // 
            // addProductBtn
            // 
            this.addProductBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addProductBtn.Location = new System.Drawing.Point(705, 110);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(115, 35);
            this.addProductBtn.TabIndex = 5;
            this.addProductBtn.Text = "ADD";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // textBoxProductCategory
            // 
            this.textBoxProductCategory.Location = new System.Drawing.Point(705, 64);
            this.textBoxProductCategory.Name = "textBoxProductCategory";
            this.textBoxProductCategory.Size = new System.Drawing.Size(114, 29);
            this.textBoxProductCategory.TabIndex = 4;
            this.textBoxProductCategory.TextChanged += new System.EventHandler(this.textBoxProductCategory_TextChanged);
            this.textBoxProductCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProductCategory_KeyDown);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(705, 22);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(114, 29);
            this.textBoxProductName.TabIndex = 3;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            this.textBoxProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProductName_KeyDown);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(135, 314);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 29);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.searchBtn.Location = new System.Drawing.Point(135, 349);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 35);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(439, 239);
            this.dataGridViewSearch.TabIndex = 0;
            this.dataGridViewSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSearch_RowHeaderMouseClick);
            this.dataGridViewSearch.Click += new System.EventHandler(this.dataGridViewSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 526);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "DATABASE SYSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label userNameLBL;
        private System.Windows.Forms.Button girisYap;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label productCategory;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox textBoxProductCategory;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label searchBy;
        private System.Windows.Forms.Label seperator;
    }
}


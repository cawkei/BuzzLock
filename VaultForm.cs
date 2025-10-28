using System;

using System.Data;

using System.Drawing;

using System.Windows.Forms;

using Microsoft.Data.Sqlite;



namespace BuzzLock

{

    public partial class VaultForm : Form
    {
        private DataGridView vaultGrid;
        private Button btnAdd, btnGenerator;
        private TextBox txtSearch;

        public VaultForm()

        {
            InitializeComponent();
            Database.Initialize();
            LoadVaultData();

        }

        private void InitializeComponent()

        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultForm));
            vaultGrid = new DataGridView();
            btnAdd = new Button();
            btnGenerator = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vaultGrid).BeginInit();
            SuspendLayout();
            // 
            // vaultGrid
            // 
            vaultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vaultGrid.BackgroundColor = Color.FromArgb(255, 222, 89);
            vaultGrid.BorderStyle = BorderStyle.None;
            vaultGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Light Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            vaultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            vaultGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            vaultGrid.DefaultCellStyle = dataGridViewCellStyle2;
            vaultGrid.GridColor = Color.FromArgb(255, 128, 0);
            vaultGrid.Location = new Point(49, 116);
            vaultGrid.Name = "vaultGrid";
            vaultGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            vaultGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            vaultGrid.RowHeadersWidth = 60;
            vaultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vaultGrid.Size = new Size(702, 335);
            vaultGrid.TabIndex = 0;
            vaultGrid.CellContentClick += vaultGrid_CellContentClick;
            vaultGrid.CellDoubleClick += VaultGrid_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImageLayout = ImageLayout.Center;
            btnAdd.Location = new Point(776, 313);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 47);
            btnAdd.TabIndex = 1;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnGenerator
            // 
            btnGenerator.BackgroundImageLayout = ImageLayout.Center;
            btnGenerator.Location = new Point(776, 249);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(53, 47);
            btnGenerator.TabIndex = 2;
            btnGenerator.Click += BtnGenerator_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(166, 231, 138);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(354, 73);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(423, 20);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // VaultForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(866, 492);
            Controls.Add(btnAdd);
            Controls.Add(btnGenerator);
            Controls.Add(txtSearch);
            Controls.Add(vaultGrid);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VaultForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuzzLock";
            ((System.ComponentModel.ISupportInitialize)vaultGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddAccountForm())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadVaultData();
                }
            }
        }
        private void BtnGenerator_Click(object sender, EventArgs e)
        {
            GeneratorForm1 generator = new GeneratorForm1();
            generator.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadVaultData(searchTerm);
        }

        public void LoadVaultData(string search = "")
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Id, Account, Username FROM Vault";

                    if (!string.IsNullOrEmpty(search))
                    {
                        query += " WHERE Account LIKE @search OR Username LIKE @search";
                    }

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(search))
                            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            vaultGrid.DataSource = dt;

                            if (vaultGrid.Columns.Contains("Id"))
                                vaultGrid.Columns["Id"].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vault: " + ex.Message, "BuzzLock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VaultGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(vaultGrid.Rows[e.RowIndex].Cells["Id"].Value);
                using (var viewForm = new ViewAccountForm(id))

                {
                    if (viewForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadVaultData();
                    }
                }
            }
        }

        private void vaultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {



        }
    }
}


using System;

using System.Data;

using System.Drawing;

using System.Windows.Forms;

using Microsoft.Data.Sqlite;



namespace BuzzLock

{

    public partial class VaultForm : CustomBorderForm
    {
        private DataGridView vaultGrid;
        private Button btnAdd, btnGenerator;
        private Button btnDelete;
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaultForm));
            vaultGrid = new DataGridView();
            btnAdd = new Button();
            btnGenerator = new Button();
            txtSearch = new TextBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)vaultGrid).BeginInit();
            SuspendLayout();
            // 
            // vaultGrid
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            vaultGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            vaultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            vaultGrid.BackgroundColor = Color.FromArgb(255, 222, 89);
            vaultGrid.BorderStyle = BorderStyle.None;
            vaultGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            vaultGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            vaultGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            vaultGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 222, 89);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            vaultGrid.DefaultCellStyle = dataGridViewCellStyle3;
            vaultGrid.EnableHeadersVisualStyles = false;
            vaultGrid.GridColor = Color.Black;
            vaultGrid.Location = new Point(56, 112);
            vaultGrid.Name = "vaultGrid";
            vaultGrid.ReadOnly = true;
            vaultGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 237, 164);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            vaultGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            vaultGrid.RowHeadersWidth = 60;
            vaultGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vaultGrid.Size = new Size(699, 330);
            vaultGrid.TabIndex = 0;
            vaultGrid.CellContentClick += vaultGrid_CellContentClick;
            vaultGrid.CellDoubleClick += VaultGrid_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(766, 311);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(46, 41);
            btnAdd.TabIndex = 1;
            btnAdd.TabStop = false;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnGenerator
            // 
            btnGenerator.BackColor = Color.Transparent;
            btnGenerator.BackgroundImageLayout = ImageLayout.Stretch;
            btnGenerator.Cursor = Cursors.Hand;
            btnGenerator.FlatAppearance.BorderSize = 0;
            btnGenerator.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGenerator.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGenerator.FlatStyle = FlatStyle.Flat;
            btnGenerator.Location = new Point(766, 243);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(46, 42);
            btnGenerator.TabIndex = 2;
            btnGenerator.TabStop = false;
            btnGenerator.UseVisualStyleBackColor = false;
            btnGenerator.Click += BtnGenerator_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(166, 231, 138);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(345, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(477, 29);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(766, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(46, 43);
            btnDelete.TabIndex = 5;
            btnDelete.TabStop = false;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // VaultForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(884, 492);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnGenerator);
            Controls.Add(txtSearch);
            Controls.Add(vaultGrid);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
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
                using (var conn = new SqliteConnection("Data Source=BuzzLock.db;Mode=ReadWrite"))
                {
                    conn.Open();

                    using (var pragmaCmd = conn.CreateCommand())
                    {
                        pragmaCmd.CommandText = "PRAGMA busy_timeout = 5000;";
                        pragmaCmd.ExecuteNonQuery();
                    }

                    string query = "SELECT Id, Account, Username FROM Vault WHERE UserId = @userId";

                    if (!string.IsNullOrEmpty(search))
                        query += " AND (Account LIKE @search OR Username LIKE @search)";

                    using (var cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);

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
                CustomMessageBox.Show("Error loading vault: " + ex.Message, "BuzzLock");
            }
        }
        private void VaultGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(vaultGrid.Rows[e.RowIndex].Cells["Id"].Value);

                // Show EnterPinForm first
                using (var pinForm = new EnterPinForm())
                {
                    if (pinForm.ShowDialog() == DialogResult.OK)
                    {
                        // Password correct, open ViewAccountForm
                        using (var viewForm = new ViewAccountForm(id))
                        {
                            viewForm.ShowDialog();
                        }

                        // Refresh vault data after closing the view form
                        LoadVaultData();
                    }

                }
            }
        }




        private void vaultGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //dapat mag select row first
            if (vaultGrid.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select an account to delete.", "BuzzLock");
                return;
            }

            //get the selected row and its ID
            int id = Convert.ToInt32(vaultGrid.SelectedRows[0].Cells["Id"].Value);
            string accountName = vaultGrid.SelectedRows[0].Cells["Account"].Value.ToString();

            //ask user for confirmation
            DialogResult confirm = CustomMessageBox.Show(
                $"Are you sure you want to delete '{accountName}'?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqliteConnection("Data Source=BuzzLock.db;Mode=ReadWrite"))
                    {
                        conn.Open();

                        using (var cmd = new SqliteCommand("DELETE FROM Vault WHERE Id = @id AND UserId = @userId", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                CustomMessageBox.Show("Account deleted successfully.", "BuzzLock");
                                LoadVaultData(); //refresh the vault grid
                            }
                            else
                            {
                                CustomMessageBox.Show("Failed to delete the account. Please try again.", "BuzzLock");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show("Error deleting account: " + ex.Message, "BuzzLock");
                }
            }
        }
    }
}


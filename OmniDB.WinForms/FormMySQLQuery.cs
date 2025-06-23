using MySql.Data.MySqlClient;
using System.Data;

namespace OmniDB.WinForms
{
    public partial class FormMySQLQuery : Form
    {
        private MySqlConnection? connection;
        private readonly string connectionString;

        public FormMySQLQuery(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                LoadTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库连接失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadTables()
        {
            try
            {
                DataTable tables = connection.GetSchema("Tables");
                foreach (DataRow row in tables.Rows)
                {
                    string tableName = row["TABLE_NAME"].ToString();
                    var node = new TreeNode(tableName)
                    {
                        Tag = tableName
                    };
                    treeDatabaseObjects.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载表失败: {ex.Message}", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ExecuteQuery(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return;

            try
            {
                using var cmd = new MySqlCommand(query, connection);
                if (query.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                {
                    using var reader = cmd.ExecuteReader();
                    DataTable resultTable = new();
                    resultTable.Load(reader);
                    ShowResult(resultTable);
                }
                else
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    ShowStatus($"操作完成，影响 {rowsAffected} 行");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void ShowResult(DataTable dataTable)
        {
            dgvResults.DataSource = dataTable;
            tabControl.SelectedTab = tabResults;
        }

        private void ShowStatus(string message)
        {
            txtResults.Text = message;
            tabControl.SelectedTab = tabResults;
        }

        private void ShowError(string message)
        {
            txtResults.Text = $"错误: {message}";
            tabControl.SelectedTab = tabResults;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ExecuteQuery(txtSqlInput.Text.Trim());
        }

        private void treeDatabaseObjects_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is string tableName)
            {
                txtSqlInput.Text = $"SELECT * FROM `{tableName}` LIMIT 100";
            }
        }

        private void FormMySQLQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection?.Close();
            connection?.Dispose();
        }
    }
}
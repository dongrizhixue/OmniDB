using MySql.Data.MySqlClient;
using OmniDB.Models;
using System.Text.Json;

namespace OmniDB.WinForms
{
    public partial class FormConnectionSettingsList : Form
    {
        private List<ConnectionSettings>? connectionSettingsList;

        public FormConnectionSettingsList()
        {
            InitializeComponent();
            LoadConnectionSettingsFromFile();
            dgvSettings.AutoGenerateColumns = false;
            dgvSettings.CellDoubleClick += (sender, e) =>
            {
                OnCellClicked(e);
            };
        }

        private void LoadConnectionSettingsFromFile()
        {
            try
            {
                // 获取当前程序集的运行目录

                string filePath = AppConstants.GetConfigFileName();

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    connectionSettingsList = JsonSerializer.Deserialize<List<ConnectionSettings>>(json);
                    dgvSettings.DataSource = connectionSettingsList;
                }
                else
                {
                    MessageBox.Show("配置文件不存在，将使用空列表初始化");
                    connectionSettingsList = [];
                    dgvSettings.DataSource = connectionSettingsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载配置文件时出错: {ex.Message}");
                connectionSettingsList = [];
                dgvSettings.DataSource = connectionSettingsList;
            }
        }


        protected virtual void OnCellClicked(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string connectionStringColumnName = "ColumnConnectionString";
                string connectionTypeColumnName = "ColumnConnectionType"; // 新增的连接类型列名




                try
                {
                    // 获取连接字符串
                    string? connectionString = dgvSettings.Rows[e.RowIndex].Cells[connectionStringColumnName].Value?.ToString();

                    // 获取连接类型
                    string? connectionTypeValue = dgvSettings.Rows[e.RowIndex].Cells[connectionTypeColumnName].Value?.ToString();

                    if (!string.IsNullOrEmpty(connectionString) && !string.IsNullOrEmpty(connectionTypeValue))
                    {
                        // 验证连接类型是否为MySQL
                        if (Enum.TryParse<EnumConnectionDataType>(connectionTypeValue.ToString(), out var connectionType))
                        {
                            if (connectionType == EnumConnectionDataType.MySQL)
                            {
                                if (ValidateMySQLConnectionString(connectionString, out string validationError))
                                {
                                    FormMySQLQuery mysqlForm = new(connectionString);

                                    mysqlForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show(validationError, "连接字符串验证失败",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("该连接类型不是MySQL，无法打开MySQL查询工具",
                                              "类型不匹配", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"无效的连接类型: {connectionTypeValue}",
                                          "类型错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("连接字符串或连接类型为空",
                                      "数据缺失", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"打开数据库工具失败: {ex.Message}",
                                  "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private static bool ValidateMySQLConnectionString(string connectionString, out string errorMessage)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                errorMessage = "连接字符串不能为空";
                return false;
            }

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    // 可选：执行简单查询验证
                    using var cmd = connection.CreateCommand();
                    cmd.CommandText = "SELECT 1;";
                    var result = cmd.ExecuteScalar();
                    bool isResult = int.TryParse(result.ToString(), out int intResult);
                    if (!isResult || intResult != 1)
                    {
                        errorMessage = "连接成功但无法执行简单查询";
                        return false;
                    }
                }
                errorMessage = string.Empty;
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042: // 无法连接到MySQL服务器
                        errorMessage = "无法连接到数据库服务器，请检查网络和配置";
                        break;
                    case 1045: // 登录失败
                        errorMessage = "数据库登录失败：用户名或密码错误";
                        break;
                    default:
                        errorMessage = $"数据库连接错误: {ex.Message}";
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                errorMessage = $"连接字符串验证失败: {ex.Message}";
                return false;
            }
        }
    }
}
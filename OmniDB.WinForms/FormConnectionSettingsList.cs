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
        private void DgvSettings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 用户自定义点击处理逻辑
            OnCellClicked(e);
        }

        protected virtual void OnCellClicked(DataGridViewCellEventArgs e)
        {
            // 虚方法供继承扩展
        }
    }
}
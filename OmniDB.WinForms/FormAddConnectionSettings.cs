using Newtonsoft.Json;
using OmniDB.Models; // 确保这个引用存在
using OmniDB.Models.Tool;
using System.ComponentModel; // 用于支持DescriptionAttribute

namespace OmniDB.WinForms
{
    public partial class FormAddConnectionSettings : Form
    {
        public FormAddConnectionSettings()
        {
            InitializeComponent();
            InitializeConnectionTypes();
        }

        private void InitializeConnectionTypes()
        {
            // 获取数据库类型枚举值
            var databaseTypes = Enum.GetValues<EnumConnectionDataType>()
                                  .Cast<EnumConnectionDataType>()
                                  .ToList();

            // 创建一个包装列表，包含数据库类型及其显示名称
            var displayList = databaseTypes.Select(dt => new
            {
                Value = dt,
                Name = EnumExtensions.GetDescription(dt) // 现在应该可以正确解析了
            }).ToList();

            // 绑定到下拉框
            cmbConnectionType.DataSource = displayList;
            cmbConnectionType.DisplayMember = "Name"; // 显示名称属性
            cmbConnectionType.ValueMember = "Value"; // 使用Value属性作为值成员
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveSettings()
        {
            // 检查连接名称是否为空
            if (string.IsNullOrWhiteSpace(txtConnectionName.Text))
            {
                MessageBox.Show("请输入连接名称");
                return;
            }

            // 获取选中的数据库类型
            var selectedItem = cmbConnectionType.SelectedItem as dynamic;
            var connectionType = selectedItem?.Value ?? EnumConnectionDataType.SQLServer;

            // 创建连接设置
            var settings = new ConnectionSettings
            {
                Name = txtConnectionName.Text,
                ConnectionType = connectionType.ToString(),
                ConnectionString = txtConnectionString.Text
            };

            try
            {
                // 读取现有数据
                var allSettings = new List<ConnectionSettings>();

                if (File.Exists(AppConstants.ConfigFileName))
                {
                    var json = File.ReadAllText(AppConstants.ConfigFileName);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        allSettings = JsonConvert.DeserializeObject<List<ConnectionSettings>>(json) ?? [];
                    }
                }

                // 添加新设置
                allSettings.Add(settings);

                // 保存回文件
                var outputJson = JsonConvert.SerializeObject(allSettings, Formatting.Indented);
                File.WriteAllText(AppConstants.ConfigFileName, outputJson);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存配置文件时出错：{ex.Message}");
            }
        }
    }
}
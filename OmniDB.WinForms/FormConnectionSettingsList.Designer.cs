// FormConnectionSettingsList.Designer.cs
namespace OmniDB.WinForms
{
    partial class FormConnectionSettingsList
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvSettings = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnConnectionType = new DataGridViewTextBoxColumn();
            ColumnConnectionString = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSettings).BeginInit();
            SuspendLayout();
            // 
            // dgvSettings
            // 
            dgvSettings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSettings.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ColumnConnectionType, ColumnConnectionString });
            dgvSettings.Dock = DockStyle.Fill;
            dgvSettings.Location = new Point(0, 0);
            dgvSettings.Margin = new Padding(4);
            dgvSettings.Name = "dgvSettings";
            dgvSettings.ReadOnly = true;
            dgvSettings.Size = new Size(933, 588);
            dgvSettings.TabIndex = 0;
            // 
            // ColumnName
            // 
            ColumnName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnName.DataPropertyName = "Name";
            ColumnName.HeaderText = "连接名称";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 81;
            // 
            // ColumnConnectionType
            // 
            ColumnConnectionType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnConnectionType.DataPropertyName = "ConnectionType";
            ColumnConnectionType.HeaderText = "连接类型";
            ColumnConnectionType.Name = "ColumnConnectionType";
            ColumnConnectionType.ReadOnly = true;
            ColumnConnectionType.Width = 81;
            // 
            // ColumnConnectionString
            // 
            ColumnConnectionString.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnConnectionString.DataPropertyName = "ConnectionString";
            ColumnConnectionString.HeaderText = "连接字符串";
            ColumnConnectionString.Name = "ColumnConnectionString";
            ColumnConnectionString.ReadOnly = true;
            ColumnConnectionString.Width = 93;
            // 
            // FormConnectionSettingsList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 588);
            Controls.Add(dgvSettings);
            Margin = new Padding(4);
            Name = "FormConnectionSettingsList";
            Text = "连接设置列表";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvSettings).EndInit();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnConnectionType;
        private DataGridViewTextBoxColumn ColumnConnectionString;
    }
}
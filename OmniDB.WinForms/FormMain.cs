namespace OmniDB.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            TSMINewConnection.Click += TSMINewConnection_Click;
            TSMIConnectionSettingsList.Click += TSMIConnectionSettingsList_Click;
        }

        private void TSMIConnectionSettingsList_Click(object? sender, EventArgs e)
        {
            FormConnectionSettingsList form = new();
            form.ShowDialog();
        }

        private void TSMINewConnection_Click(object? sender, EventArgs e)
        {
            FormAddConnectionSettings form = new();
            form.ShowDialog();
        }
    }
}

namespace OmniDB.WinForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            TSMINewConnection.Click += TSMINewConnection_Click;
        }



        private void TSMINewConnection_Click(object? sender, EventArgs e)
        {
            FormAddConnectionSettings form = new();
            form.ShowDialog();
        }
    }
}

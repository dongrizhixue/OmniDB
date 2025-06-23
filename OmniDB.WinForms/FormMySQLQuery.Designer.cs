namespace OmniDB.WinForms
{
    partial class FormMySQLQuery
    {
        private TreeView treeDatabaseObjects;
        private RichTextBox txtSqlInput;
        private Button btnExecute;
        private DataGridView dgvResults;
        private RichTextBox txtResults;

        private void InitializeComponent()
        {
            treeDatabaseObjects = new TreeView();
            dgvTableStructure = new DataGridView();
            panel1 = new Panel();
            btnExecute = new Button();
            txtSqlInput = new RichTextBox();
            dgvResults = new DataGridView();
            txtResults = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTableStructure).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // treeDatabaseObjects
            // 
            treeDatabaseObjects.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            treeDatabaseObjects.Location = new Point(12, 12);
            treeDatabaseObjects.Name = "treeDatabaseObjects";
            treeDatabaseObjects.Size = new Size(297, 270);
            treeDatabaseObjects.TabIndex = 0;
            treeDatabaseObjects.AfterSelect += TreeDatabaseObjects_AfterSelect;
            // 
            // dgvTableStructure
            // 
            dgvTableStructure.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvTableStructure.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableStructure.Location = new Point(12, 288);
            dgvTableStructure.Name = "dgvTableStructure";
            dgvTableStructure.Size = new Size(297, 270);
            dgvTableStructure.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnExecute);
            panel1.Controls.Add(txtSqlInput);
            panel1.Controls.Add(dgvResults);
            panel1.Controls.Add(txtResults);
            panel1.Location = new Point(330, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 537);
            panel1.TabIndex = 2;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(0, 0);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 23);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "执行";
            btnExecute.Click += BtnExecute_Click;
            // 
            // txtSqlInput
            // 
            txtSqlInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSqlInput.Location = new Point(0, 29);
            txtSqlInput.Name = "txtSqlInput";
            txtSqlInput.Size = new Size(439, 234);
            txtSqlInput.TabIndex = 0;
            txtSqlInput.Text = "";
            // 
            // dgvResults
            // 
            dgvResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResults.Location = new Point(0, 269);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(439, 164);
            dgvResults.TabIndex = 0;
            // 
            // txtResults
            // 
            txtResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResults.Location = new Point(0, 439);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(439, 95);
            txtResults.TabIndex = 0;
            txtResults.Text = "";
            // 
            // FormMySQLQuery
            // 
            ClientSize = new Size(784, 561);
            Controls.Add(treeDatabaseObjects);
            Controls.Add(dgvTableStructure);
            Controls.Add(panel1);
            Name = "FormMySQLQuery";
            Text = "MySQL查询工具";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormMySQLQuery_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvTableStructure).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }
        private Panel panel1;
        private DataGridView dgvTableStructure;
    }
}
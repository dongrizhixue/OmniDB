namespace OmniDB.WinForms
{
    partial class FormMySQLQuery
    {
        private SplitContainer splitContainer;
        private TreeView treeDatabaseObjects;
        private TabControl tabControl;
        private TabPage tabSqlInput;
        private RichTextBox txtSqlInput;
        private Button btnExecute;
        private TabPage tabResults;
        private DataGridView dgvResults;
        private RichTextBox txtResults;

        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            treeDatabaseObjects = new TreeView();
            tabControl = new TabControl();
            tabSqlInput = new TabPage();
            sqlPanel = new Panel();
            txtSqlInput = new RichTextBox();
            btnExecute = new Button();
            tabResults = new TabPage();
            dgvResults = new DataGridView();
            txtResults = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tabControl.SuspendLayout();
            tabSqlInput.SuspendLayout();
            sqlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeDatabaseObjects);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tabControl);
            splitContainer.Size = new Size(784, 561);
            splitContainer.SplitterDistance = 300;
            splitContainer.TabIndex = 0;
            // 
            // treeDatabaseObjects
            // 
            treeDatabaseObjects.Dock = DockStyle.Fill;
            treeDatabaseObjects.Location = new Point(0, 0);
            treeDatabaseObjects.Name = "treeDatabaseObjects";
            treeDatabaseObjects.Size = new Size(300, 561);
            treeDatabaseObjects.TabIndex = 0;
            treeDatabaseObjects.AfterSelect += treeDatabaseObjects_AfterSelect;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabSqlInput);
            tabControl.Controls.Add(tabResults);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(480, 561);
            tabControl.TabIndex = 0;
            // 
            // tabSqlInput
            // 
            tabSqlInput.Controls.Add(btnExecute);
            tabSqlInput.Controls.Add(sqlPanel);
            tabSqlInput.Location = new Point(4, 26);
            tabSqlInput.Name = "tabSqlInput";
            tabSqlInput.Size = new Size(472, 531);
            tabSqlInput.TabIndex = 0;
            tabSqlInput.Text = "SQL输入";
            // 
            // sqlPanel
            // 
            sqlPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sqlPanel.Controls.Add(txtSqlInput);
            sqlPanel.Location = new Point(0, 29);
            sqlPanel.Name = "sqlPanel";
            sqlPanel.Size = new Size(469, 502);
            sqlPanel.TabIndex = 0;
            // 
            // txtSqlInput
            // 
            txtSqlInput.Dock = DockStyle.Fill;
            txtSqlInput.Location = new Point(0, 0);
            txtSqlInput.Name = "txtSqlInput";
            txtSqlInput.Size = new Size(469, 502);
            txtSqlInput.TabIndex = 0;
            txtSqlInput.Text = "";
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(0, 0);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 23);
            btnExecute.TabIndex = 1;
            btnExecute.Text = "执行";
            btnExecute.Click += btnExecute_Click;
            // 
            // tabResults
            // 
            tabResults.Location = new Point(4, 26);
            tabResults.Name = "tabResults";
            tabResults.Size = new Size(472, 531);
            tabResults.TabIndex = 1;
            tabResults.Text = "结果";
            // 
            // dgvResults
            // 
            dgvResults.Dock = DockStyle.Fill;
            dgvResults.Location = new Point(0, 0);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(240, 150);
            dgvResults.TabIndex = 0;
            // 
            // txtResults
            // 
            txtResults.Dock = DockStyle.Fill;
            txtResults.Location = new Point(0, 0);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(100, 96);
            txtResults.TabIndex = 0;
            txtResults.Text = "";
            // 
            // FormMySQLQuery
            // 
            ClientSize = new Size(784, 561);
            Controls.Add(splitContainer);
            Name = "FormMySQLQuery";
            Text = "MySQL查询工具";
            WindowState = FormWindowState.Maximized;
            FormClosed += FormMySQLQuery_FormClosed;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabSqlInput.ResumeLayout(false);
            sqlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
        }
        private Panel sqlPanel;
    }
}
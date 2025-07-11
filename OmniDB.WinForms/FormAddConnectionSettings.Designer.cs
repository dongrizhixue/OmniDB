namespace OmniDB.WinForms
{
    partial class FormAddConnectionSettings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbConnectionType = new ComboBox();
            txtConnectionString = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtConnectionName = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cmbConnectionType
            // 
            cmbConnectionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConnectionType.FormattingEnabled = true;
            cmbConnectionType.Location = new Point(135, 100);
            cmbConnectionType.Name = "cmbConnectionType";
            cmbConnectionType.Size = new Size(300, 25);
            cmbConnectionType.TabIndex = 0;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(135, 131);
            txtConnectionString.Multiline = true;
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.ScrollBars = ScrollBars.Vertical;
            txtConnectionString.Size = new Size(300, 100);
            txtConnectionString.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 104);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 2;
            label1.Text = "连接类型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 131);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "连接字符串：";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(285, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 4;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(360, 241);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 25);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "取消";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // txtConnectionName
            // 
            txtConnectionName.Location = new Point(135, 71);
            txtConnectionName.Name = "txtConnectionName";
            txtConnectionName.Size = new Size(300, 23);
            txtConnectionName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 74);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 7;
            label3.Text = "连接名称：";
            // 
            // FormAddConnectionSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 336);
            Controls.Add(label3);
            Controls.Add(txtConnectionName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtConnectionString);
            Controls.Add(cmbConnectionType);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAddConnectionSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "新增连接设置";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ComboBox cmbConnectionType;
        private TextBox txtConnectionString;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtConnectionName;
        private Label label3;
    }
}
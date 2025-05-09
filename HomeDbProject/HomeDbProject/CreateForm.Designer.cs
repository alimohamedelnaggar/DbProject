namespace HomeDbProject
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Cancel = new Button();
            Save = new Button();
            NameUser = new Label();
            EmailUser = new Label();
            comboRole = new ComboBox();
            Role = new Label();
            TextUser = new TextBox();
            textEmail = new TextBox();
            CreateEdit = new Label();
            SuspendLayout();
            // 
            // Cancel
            // 
            Cancel.Location = new Point(385, 352);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 0;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            Cancel.Click += Cancel_Click;
            // 
            // Save
            // 
            Save.Location = new Point(188, 352);
            Save.Name = "Save";
            Save.Size = new Size(94, 29);
            Save.TabIndex = 1;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // NameUser
            // 
            NameUser.AutoSize = true;
            NameUser.Location = new Point(100, 88);
            NameUser.Name = "NameUser";
            NameUser.Size = new Size(49, 20);
            NameUser.TabIndex = 2;
            NameUser.Text = "Name";
            // 
            // EmailUser
            // 
            EmailUser.AutoSize = true;
            EmailUser.Location = new Point(100, 146);
            EmailUser.Name = "EmailUser";
            EmailUser.Size = new Size(46, 20);
            EmailUser.TabIndex = 3;
            EmailUser.Text = "Email";
            // 
            // comboRole
            // 
            comboRole.FormattingEnabled = true;
            comboRole.Location = new Point(224, 207);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(151, 28);
            comboRole.TabIndex = 4;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(100, 215);
            Role.Name = "Role";
            Role.Size = new Size(39, 20);
            Role.TabIndex = 5;
            Role.Text = "Role";
            // 
            // TextUser
            // 
            TextUser.Location = new Point(234, 88);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(125, 27);
            TextUser.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(234, 146);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(125, 27);
            textEmail.TabIndex = 7;
            // 
            // CreateEdit
            // 
            CreateEdit.Dock = DockStyle.Top;
            CreateEdit.Location = new Point(0, 0);
            CreateEdit.Name = "CreateEdit";
            CreateEdit.Size = new Size(859, 40);
            CreateEdit.TabIndex = 20;
            CreateEdit.Text = "Create";
            CreateEdit.TextAlign = ContentAlignment.MiddleCenter;
            CreateEdit.Click += label1_Click_2;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 476);
            Controls.Add(CreateEdit);
            Controls.Add(textEmail);
            Controls.Add(TextUser);
            Controls.Add(Role);
            Controls.Add(comboRole);
            Controls.Add(EmailUser);
            Controls.Add(NameUser);
            Controls.Add(Save);
            Controls.Add(Cancel);
            Name = "CreateForm";
            Text = "CreateForm";
            Load += CreateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancel;
        private Button Save;
        private Label NameUser;
        private Label EmailUser;
        private ComboBox comboRole;
        private Label Role;
        private TextBox TextUser;
        private TextBox textEmail;
        private Label CreateEdit;
    }
}
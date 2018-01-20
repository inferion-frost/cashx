namespace WinFormApplication
{
    partial class NewUserForm
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
            this.user_GroupBox = new System.Windows.Forms.GroupBox();
            this.enter_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userEmail_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userFullName_TextBox = new System.Windows.Forms.TextBox();
            this.userPhoneNumber_MaskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.userBirthDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.user_GroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_GroupBox
            // 
            this.user_GroupBox.Controls.Add(this.enter_Button);
            this.user_GroupBox.Controls.Add(this.tableLayoutPanel1);
            this.user_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.user_GroupBox.Name = "user_GroupBox";
            this.user_GroupBox.Size = new System.Drawing.Size(312, 258);
            this.user_GroupBox.TabIndex = 0;
            this.user_GroupBox.TabStop = false;
            this.user_GroupBox.Text = "Добавление нового пользователя";
            // 
            // enter_Button
            // 
            this.enter_Button.Location = new System.Drawing.Point(6, 215);
            this.enter_Button.Name = "enter_Button";
            this.enter_Button.Size = new System.Drawing.Size(300, 37);
            this.enter_Button.TabIndex = 1;
            this.enter_Button.Text = "Вход";
            this.enter_Button.UseVisualStyleBackColor = true;
            this.enter_Button.Click += new System.EventHandler(this.enter_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel1.Controls.Add(this.userEmail_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.userFullName_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.userPhoneNumber_MaskTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.userBirthDate_DateTimePicker, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 180);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userEmail_TextBox
            // 
            this.userEmail_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userEmail_TextBox.Location = new System.Drawing.Point(120, 52);
            this.userEmail_TextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.userEmail_TextBox.Name = "userEmail_TextBox";
            this.userEmail_TextBox.Size = new System.Drawing.Size(177, 22);
            this.userEmail_TextBox.TabIndex = 6;
            this.userEmail_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserEmail_TextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Электронная почта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата рождения";
            // 
            // userFullName_TextBox
            // 
            this.userFullName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userFullName_TextBox.Location = new System.Drawing.Point(120, 7);
            this.userFullName_TextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.userFullName_TextBox.Name = "userFullName_TextBox";
            this.userFullName_TextBox.Size = new System.Drawing.Size(177, 22);
            this.userFullName_TextBox.TabIndex = 5;
            this.userFullName_TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UserFullName_TextBox_Validating);
            // 
            // userPhoneNumber_MaskTextBox
            // 
            this.userPhoneNumber_MaskTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPhoneNumber_MaskTextBox.Location = new System.Drawing.Point(120, 97);
            this.userPhoneNumber_MaskTextBox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.userPhoneNumber_MaskTextBox.Mask = "(999) 000-0000";
            this.userPhoneNumber_MaskTextBox.Name = "userPhoneNumber_MaskTextBox";
            this.userPhoneNumber_MaskTextBox.Size = new System.Drawing.Size(177, 22);
            this.userPhoneNumber_MaskTextBox.TabIndex = 9;
            // 
            // userBirthDate_DateTimePicker
            // 
            this.userBirthDate_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBirthDate_DateTimePicker.Location = new System.Drawing.Point(120, 142);
            this.userBirthDate_DateTimePicker.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.userBirthDate_DateTimePicker.MaxDate = new System.DateTime(2020, 12, 12, 0, 0, 0, 0);
            this.userBirthDate_DateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.userBirthDate_DateTimePicker.Name = "userBirthDate_DateTimePicker";
            this.userBirthDate_DateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.userBirthDate_DateTimePicker.TabIndex = 10;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 282);
            this.Controls.Add(this.user_GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUserForm";
            this.Text = "Новый пользователь";
            this.user_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox user_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userEmail_TextBox;
        private System.Windows.Forms.TextBox userFullName_TextBox;
        private System.Windows.Forms.Button enter_Button;
        private System.Windows.Forms.MaskedTextBox userPhoneNumber_MaskTextBox;
        private System.Windows.Forms.DateTimePicker userBirthDate_DateTimePicker;
    }
}
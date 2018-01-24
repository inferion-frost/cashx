namespace WinFormApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoard_Panel = new System.Windows.Forms.Panel();
            this.transaction_GroupBox = new System.Windows.Forms.GroupBox();
            this.transaction_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.transactionDescription_TextBox = new System.Windows.Forms.TextBox();
            this.transactionSum_TextBox = new System.Windows.Forms.TextBox();
            this.transactionSum_Label = new System.Windows.Forms.Label();
            this.transactionDescription_Label = new System.Windows.Forms.Label();
            this.transactionType_ComboBox = new System.Windows.Forms.ComboBox();
            this.transactionType_Label = new System.Windows.Forms.Label();
            this.transaction_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transactionDateTime_Label = new System.Windows.Forms.Label();
            this.beginTransaction_Button = new System.Windows.Forms.Button();
            this.userPanel_GroupBox = new System.Windows.Forms.GroupBox();
            this.user_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fullName_Label = new System.Windows.Forms.Label();
            this.birthDate_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.balance_Label = new System.Windows.Forms.Label();
            this.fullName_TextBox = new System.Windows.Forms.TextBox();
            this.birthDate_TextBox = new System.Windows.Forms.TextBox();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.balance_TextBox = new System.Windows.Forms.TextBox();
            this.transactions_Panel = new System.Windows.Forms.Panel();
            this.transactions_GroupBox = new System.Windows.Forms.GroupBox();
            this._transactionsNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.transactions_DataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip.SuspendLayout();
            this.dashBoard_Panel.SuspendLayout();
            this.transaction_GroupBox.SuspendLayout();
            this.transaction_LayoutPanel.SuspendLayout();
            this.userPanel_GroupBox.SuspendLayout();
            this.user_LayoutPanel.SuspendLayout();
            this.transactions_Panel.SuspendLayout();
            this.transactions_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._transactionsNavigator)).BeginInit();
            this._transactionsNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactions_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(942, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dashBoard_Panel
            // 
            this.dashBoard_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dashBoard_Panel.Controls.Add(this.transaction_GroupBox);
            this.dashBoard_Panel.Controls.Add(this.userPanel_GroupBox);
            this.dashBoard_Panel.Location = new System.Drawing.Point(12, 27);
            this.dashBoard_Panel.Name = "dashBoard_Panel";
            this.dashBoard_Panel.Size = new System.Drawing.Size(302, 372);
            this.dashBoard_Panel.TabIndex = 2;
            // 
            // transaction_GroupBox
            // 
            this.transaction_GroupBox.Controls.Add(this.transaction_LayoutPanel);
            this.transaction_GroupBox.Location = new System.Drawing.Point(3, 153);
            this.transaction_GroupBox.Name = "transaction_GroupBox";
            this.transaction_GroupBox.Size = new System.Drawing.Size(290, 216);
            this.transaction_GroupBox.TabIndex = 1;
            this.transaction_GroupBox.TabStop = false;
            this.transaction_GroupBox.Text = "Совершить транзакцию";
            // 
            // transaction_LayoutPanel
            // 
            this.transaction_LayoutPanel.ColumnCount = 2;
            this.transaction_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.76056F));
            this.transaction_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.23943F));
            this.transaction_LayoutPanel.Controls.Add(this.transactionDescription_TextBox, 1, 0);
            this.transaction_LayoutPanel.Controls.Add(this.transactionSum_TextBox, 1, 1);
            this.transaction_LayoutPanel.Controls.Add(this.transactionSum_Label, 0, 1);
            this.transaction_LayoutPanel.Controls.Add(this.transactionDescription_Label, 0, 0);
            this.transaction_LayoutPanel.Controls.Add(this.transactionType_ComboBox, 1, 2);
            this.transaction_LayoutPanel.Controls.Add(this.transactionType_Label, 0, 2);
            this.transaction_LayoutPanel.Controls.Add(this.transaction_DateTimePicker, 1, 3);
            this.transaction_LayoutPanel.Controls.Add(this.transactionDateTime_Label, 0, 3);
            this.transaction_LayoutPanel.Controls.Add(this.beginTransaction_Button, 1, 4);
            this.transaction_LayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.transaction_LayoutPanel.Name = "transaction_LayoutPanel";
            this.transaction_LayoutPanel.RowCount = 5;
            this.transaction_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.30434F));
            this.transaction_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.69565F));
            this.transaction_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.transaction_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.transaction_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.transaction_LayoutPanel.Size = new System.Drawing.Size(284, 191);
            this.transaction_LayoutPanel.TabIndex = 0;
            // 
            // transactionDescription_TextBox
            // 
            this.transactionDescription_TextBox.Location = new System.Drawing.Point(78, 3);
            this.transactionDescription_TextBox.Multiline = true;
            this.transactionDescription_TextBox.Name = "transactionDescription_TextBox";
            this.transactionDescription_TextBox.Size = new System.Drawing.Size(203, 58);
            this.transactionDescription_TextBox.TabIndex = 0;
            // 
            // transactionSum_TextBox
            // 
            this.transactionSum_TextBox.Location = new System.Drawing.Point(78, 67);
            this.transactionSum_TextBox.Name = "transactionSum_TextBox";
            this.transactionSum_TextBox.Size = new System.Drawing.Size(203, 20);
            this.transactionSum_TextBox.TabIndex = 3;
            // 
            // transactionSum_Label
            // 
            this.transactionSum_Label.AutoSize = true;
            this.transactionSum_Label.Location = new System.Drawing.Point(3, 69);
            this.transactionSum_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.transactionSum_Label.Name = "transactionSum_Label";
            this.transactionSum_Label.Size = new System.Drawing.Size(41, 13);
            this.transactionSum_Label.TabIndex = 2;
            this.transactionSum_Label.Text = "Сумма";
            // 
            // transactionDescription_Label
            // 
            this.transactionDescription_Label.AutoSize = true;
            this.transactionDescription_Label.Location = new System.Drawing.Point(3, 5);
            this.transactionDescription_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.transactionDescription_Label.Name = "transactionDescription_Label";
            this.transactionDescription_Label.Size = new System.Drawing.Size(66, 26);
            this.transactionDescription_Label.TabIndex = 1;
            this.transactionDescription_Label.Text = "Описание транзакции";
            // 
            // transactionType_ComboBox
            // 
            this.transactionType_ComboBox.FormattingEnabled = true;
            this.transactionType_ComboBox.Location = new System.Drawing.Point(78, 92);
            this.transactionType_ComboBox.Name = "transactionType_ComboBox";
            this.transactionType_ComboBox.Size = new System.Drawing.Size(203, 21);
            this.transactionType_ComboBox.TabIndex = 4;
            // 
            // transactionType_Label
            // 
            this.transactionType_Label.AutoSize = true;
            this.transactionType_Label.Location = new System.Drawing.Point(3, 94);
            this.transactionType_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.transactionType_Label.Name = "transactionType_Label";
            this.transactionType_Label.Size = new System.Drawing.Size(66, 26);
            this.transactionType_Label.TabIndex = 5;
            this.transactionType_Label.Text = "Тип транзакции";
            // 
            // transaction_DateTimePicker
            // 
            this.transaction_DateTimePicker.Location = new System.Drawing.Point(78, 125);
            this.transaction_DateTimePicker.Name = "transaction_DateTimePicker";
            this.transaction_DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.transaction_DateTimePicker.TabIndex = 6;
            // 
            // transactionDateTime_Label
            // 
            this.transactionDateTime_Label.AutoSize = true;
            this.transactionDateTime_Label.Location = new System.Drawing.Point(3, 127);
            this.transactionDateTime_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.transactionDateTime_Label.Name = "transactionDateTime_Label";
            this.transactionDateTime_Label.Size = new System.Drawing.Size(45, 25);
            this.transactionDateTime_Label.TabIndex = 7;
            this.transactionDateTime_Label.Text = "Дата и время";
            // 
            // beginTransaction_Button
            // 
            this.beginTransaction_Button.Location = new System.Drawing.Point(78, 155);
            this.beginTransaction_Button.Name = "beginTransaction_Button";
            this.beginTransaction_Button.Size = new System.Drawing.Size(200, 33);
            this.beginTransaction_Button.TabIndex = 8;
            this.beginTransaction_Button.Text = "Совершить";
            this.beginTransaction_Button.UseVisualStyleBackColor = true;
            this.beginTransaction_Button.Click += new System.EventHandler(this.BeginTransaction_Button_Click);
            // 
            // userPanel_GroupBox
            // 
            this.userPanel_GroupBox.Controls.Add(this.user_LayoutPanel);
            this.userPanel_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.userPanel_GroupBox.Name = "userPanel_GroupBox";
            this.userPanel_GroupBox.Size = new System.Drawing.Size(296, 144);
            this.userPanel_GroupBox.TabIndex = 0;
            this.userPanel_GroupBox.TabStop = false;
            this.userPanel_GroupBox.Text = "Пользователь";
            // 
            // user_LayoutPanel
            // 
            this.user_LayoutPanel.ColumnCount = 2;
            this.user_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.43662F));
            this.user_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.56338F));
            this.user_LayoutPanel.Controls.Add(this.fullName_Label, 0, 0);
            this.user_LayoutPanel.Controls.Add(this.birthDate_Label, 0, 1);
            this.user_LayoutPanel.Controls.Add(this.email_Label, 0, 2);
            this.user_LayoutPanel.Controls.Add(this.balance_Label, 0, 3);
            this.user_LayoutPanel.Controls.Add(this.fullName_TextBox, 1, 0);
            this.user_LayoutPanel.Controls.Add(this.birthDate_TextBox, 1, 1);
            this.user_LayoutPanel.Controls.Add(this.email_TextBox, 1, 2);
            this.user_LayoutPanel.Controls.Add(this.balance_TextBox, 1, 3);
            this.user_LayoutPanel.Location = new System.Drawing.Point(6, 19);
            this.user_LayoutPanel.Name = "user_LayoutPanel";
            this.user_LayoutPanel.RowCount = 4;
            this.user_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.user_LayoutPanel.Size = new System.Drawing.Size(284, 119);
            this.user_LayoutPanel.TabIndex = 0;
            // 
            // fullName_Label
            // 
            this.fullName_Label.AutoSize = true;
            this.fullName_Label.Location = new System.Drawing.Point(3, 5);
            this.fullName_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.fullName_Label.Name = "fullName_Label";
            this.fullName_Label.Size = new System.Drawing.Size(34, 13);
            this.fullName_Label.TabIndex = 0;
            this.fullName_Label.Text = "ФИО";
            // 
            // birthDate_Label
            // 
            this.birthDate_Label.AutoSize = true;
            this.birthDate_Label.Location = new System.Drawing.Point(3, 34);
            this.birthDate_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.birthDate_Label.Name = "birthDate_Label";
            this.birthDate_Label.Size = new System.Drawing.Size(86, 13);
            this.birthDate_Label.TabIndex = 1;
            this.birthDate_Label.Text = "Дата рождения";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Location = new System.Drawing.Point(3, 63);
            this.email_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(37, 13);
            this.email_Label.TabIndex = 2;
            this.email_Label.Text = "Почта";
            // 
            // balance_Label
            // 
            this.balance_Label.AutoSize = true;
            this.balance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_Label.ForeColor = System.Drawing.Color.Black;
            this.balance_Label.Location = new System.Drawing.Point(3, 92);
            this.balance_Label.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.balance_Label.Name = "balance_Label";
            this.balance_Label.Size = new System.Drawing.Size(105, 13);
            this.balance_Label.TabIndex = 3;
            this.balance_Label.Text = "Текущий баланс";
            // 
            // fullName_TextBox
            // 
            this.fullName_TextBox.Location = new System.Drawing.Point(114, 3);
            this.fullName_TextBox.Name = "fullName_TextBox";
            this.fullName_TextBox.ReadOnly = true;
            this.fullName_TextBox.Size = new System.Drawing.Size(167, 20);
            this.fullName_TextBox.TabIndex = 4;
            // 
            // birthDate_TextBox
            // 
            this.birthDate_TextBox.Location = new System.Drawing.Point(114, 32);
            this.birthDate_TextBox.Name = "birthDate_TextBox";
            this.birthDate_TextBox.ReadOnly = true;
            this.birthDate_TextBox.Size = new System.Drawing.Size(167, 20);
            this.birthDate_TextBox.TabIndex = 5;
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(114, 61);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.ReadOnly = true;
            this.email_TextBox.Size = new System.Drawing.Size(167, 20);
            this.email_TextBox.TabIndex = 6;
            // 
            // balance_TextBox
            // 
            this.balance_TextBox.Location = new System.Drawing.Point(114, 90);
            this.balance_TextBox.Name = "balance_TextBox";
            this.balance_TextBox.ReadOnly = true;
            this.balance_TextBox.Size = new System.Drawing.Size(167, 20);
            this.balance_TextBox.TabIndex = 7;
            // 
            // transactions_Panel
            // 
            this.transactions_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactions_Panel.Controls.Add(this.transactions_GroupBox);
            this.transactions_Panel.Location = new System.Drawing.Point(320, 27);
            this.transactions_Panel.Name = "transactions_Panel";
            this.transactions_Panel.Size = new System.Drawing.Size(610, 372);
            this.transactions_Panel.TabIndex = 3;
            // 
            // transactions_GroupBox
            // 
            this.transactions_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactions_GroupBox.Controls.Add(this._transactionsNavigator);
            this.transactions_GroupBox.Controls.Add(this.transactions_DataGridView);
            this.transactions_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.transactions_GroupBox.Name = "transactions_GroupBox";
            this.transactions_GroupBox.Size = new System.Drawing.Size(604, 367);
            this.transactions_GroupBox.TabIndex = 0;
            this.transactions_GroupBox.TabStop = false;
            this.transactions_GroupBox.Text = "Транзакции";
            // 
            // _transactionsNavigator
            // 
            this._transactionsNavigator.AddNewItem = null;
            this._transactionsNavigator.CountItem = this.bindingNavigatorCountItem;
            this._transactionsNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this._transactionsNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._transactionsNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._transactionsNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem});
            this._transactionsNavigator.Location = new System.Drawing.Point(3, 339);
            this._transactionsNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._transactionsNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._transactionsNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._transactionsNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._transactionsNavigator.Name = "_transactionsNavigator";
            this._transactionsNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this._transactionsNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this._transactionsNavigator.Size = new System.Drawing.Size(598, 25);
            this._transactionsNavigator.TabIndex = 1;
            this._transactionsNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // transactions_DataGridView
            // 
            this.transactions_DataGridView.AllowUserToAddRows = false;
            this.transactions_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactions_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactions_DataGridView.Location = new System.Drawing.Point(6, 19);
            this.transactions_DataGridView.Name = "transactions_DataGridView";
            this.transactions_DataGridView.ReadOnly = true;
            this.transactions_DataGridView.Size = new System.Drawing.Size(592, 344);
            this.transactions_DataGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 413);
            this.Controls.Add(this.transactions_Panel);
            this.Controls.Add(this.dashBoard_Panel);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.dashBoard_Panel.ResumeLayout(false);
            this.transaction_GroupBox.ResumeLayout(false);
            this.transaction_LayoutPanel.ResumeLayout(false);
            this.transaction_LayoutPanel.PerformLayout();
            this.userPanel_GroupBox.ResumeLayout(false);
            this.user_LayoutPanel.ResumeLayout(false);
            this.user_LayoutPanel.PerformLayout();
            this.transactions_Panel.ResumeLayout(false);
            this.transactions_GroupBox.ResumeLayout(false);
            this.transactions_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._transactionsNavigator)).EndInit();
            this._transactionsNavigator.ResumeLayout(false);
            this._transactionsNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactions_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel dashBoard_Panel;
        private System.Windows.Forms.GroupBox transaction_GroupBox;
        private System.Windows.Forms.GroupBox userPanel_GroupBox;
        private System.Windows.Forms.Panel transactions_Panel;
        private System.Windows.Forms.GroupBox transactions_GroupBox;
        private System.Windows.Forms.TableLayoutPanel user_LayoutPanel;
        private System.Windows.Forms.Label fullName_Label;
        private System.Windows.Forms.Label birthDate_Label;
        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.Label balance_Label;
        private System.Windows.Forms.TextBox fullName_TextBox;
        private System.Windows.Forms.TextBox birthDate_TextBox;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.TextBox balance_TextBox;
        private System.Windows.Forms.TableLayoutPanel transaction_LayoutPanel;
        private System.Windows.Forms.TextBox transactionDescription_TextBox;
        private System.Windows.Forms.Label transactionDescription_Label;
        private System.Windows.Forms.Label transactionSum_Label;
        private System.Windows.Forms.TextBox transactionSum_TextBox;
        private System.Windows.Forms.ComboBox transactionType_ComboBox;
        private System.Windows.Forms.Label transactionType_Label;
        private System.Windows.Forms.DateTimePicker transaction_DateTimePicker;
        private System.Windows.Forms.Label transactionDateTime_Label;
        private System.Windows.Forms.Button beginTransaction_Button;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.DataGridView transactions_DataGridView;
        private System.Windows.Forms.BindingNavigator _transactionsNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}


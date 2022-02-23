
namespace BankDataBase
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.clients_control = new System.Windows.Forms.TabPage();
            this.button_clients_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_passport = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.update_client = new System.Windows.Forms.Button();
            this.button_bd = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.account_bank_control = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_date_open = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kindDepoist = new System.Windows.Forms.TextBox();
            this.textBox_idClient = new System.Windows.Forms.TextBox();
            this.textBox_idbank = new System.Windows.Forms.TextBox();
            this.button_bankAccount = new System.Windows.Forms.Button();
            this.id_close_account = new System.Windows.Forms.TextBox();
            this.dvgKindDeposit = new System.Windows.Forms.DataGridView();
            this.dbgBankAccounts = new System.Windows.Forms.DataGridView();
            this.operation = new System.Windows.Forms.TabPage();
            this.dvg_operation = new System.Windows.Forms.DataGridView();
            this.dvg_name_operation = new System.Windows.Forms.DataGridView();
            this.text_idoperation = new System.Windows.Forms.TextBox();
            this.text_month = new System.Windows.Forms.TextBox();
            this.text_number_operation = new System.Windows.Forms.TextBox();
            this.text_id_bank = new System.Windows.Forms.TextBox();
            this.text_money = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.moneee = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.clients_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.account_bank_control.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKindDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgBankAccounts)).BeginInit();
            this.operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_operation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_name_operation)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.clients_control);
            this.tabControl1.Controls.Add(this.account_bank_control);
            this.tabControl1.Controls.Add(this.operation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // clients_control
            // 
            this.clients_control.Controls.Add(this.button_clients_add);
            this.clients_control.Controls.Add(this.label4);
            this.clients_control.Controls.Add(this.textbox_passport);
            this.clients_control.Controls.Add(this.textBox_lastname);
            this.clients_control.Controls.Add(this.textBox_name);
            this.clients_control.Controls.Add(this.textBox_id);
            this.clients_control.Controls.Add(this.label3);
            this.clients_control.Controls.Add(this.label2);
            this.clients_control.Controls.Add(this.label1);
            this.clients_control.Controls.Add(this.update_client);
            this.clients_control.Controls.Add(this.button_bd);
            this.clients_control.Controls.Add(this.dgvClients);
            this.clients_control.Location = new System.Drawing.Point(4, 22);
            this.clients_control.Name = "clients_control";
            this.clients_control.Padding = new System.Windows.Forms.Padding(3);
            this.clients_control.Size = new System.Drawing.Size(900, 489);
            this.clients_control.TabIndex = 0;
            this.clients_control.Text = "Клиенты";
            this.clients_control.UseVisualStyleBackColor = true;
            // 
            // button_clients_add
            // 
            this.button_clients_add.Location = new System.Drawing.Point(321, 424);
            this.button_clients_add.Name = "button_clients_add";
            this.button_clients_add.Size = new System.Drawing.Size(430, 35);
            this.button_clients_add.TabIndex = 11;
            this.button_clients_add.Text = "Добавить клиента";
            this.button_clients_add.UseVisualStyleBackColor = true;
            this.button_clients_add.Click += new System.EventHandler(this.button_clients_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Паспорт";
            // 
            // textbox_passport
            // 
            this.textbox_passport.Location = new System.Drawing.Point(651, 398);
            this.textbox_passport.Name = "textbox_passport";
            this.textbox_passport.Size = new System.Drawing.Size(100, 20);
            this.textbox_passport.TabIndex = 9;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Location = new System.Drawing.Point(541, 398);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(100, 20);
            this.textBox_lastname.TabIndex = 8;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(431, 398);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(321, 398);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // update_client
            // 
            this.update_client.Location = new System.Drawing.Point(8, 297);
            this.update_client.Name = "update_client";
            this.update_client.Size = new System.Drawing.Size(152, 35);
            this.update_client.TabIndex = 2;
            this.update_client.Text = "Вставить таблицу";
            this.update_client.UseVisualStyleBackColor = true;
            this.update_client.Click += new System.EventHandler(this.update_client_Click);
            // 
            // button_bd
            // 
            this.button_bd.Location = new System.Drawing.Point(8, 338);
            this.button_bd.Name = "button_bd";
            this.button_bd.Size = new System.Drawing.Size(152, 35);
            this.button_bd.TabIndex = 1;
            this.button_bd.Text = "Проверка";
            this.button_bd.UseVisualStyleBackColor = true;
            this.button_bd.Click += new System.EventHandler(this.button_bd_Click);
            // 
            // dgvClients
            // 
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(8, 6);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.Size = new System.Drawing.Size(776, 282);
            this.dgvClients.TabIndex = 0;
            // 
            // account_bank_control
            // 
            this.account_bank_control.Controls.Add(this.label10);
            this.account_bank_control.Controls.Add(this.dateTimePicker1);
            this.account_bank_control.Controls.Add(this.label9);
            this.account_bank_control.Controls.Add(this.button1);
            this.account_bank_control.Controls.Add(this.panel1);
            this.account_bank_control.Controls.Add(this.id_close_account);
            this.account_bank_control.Controls.Add(this.dvgKindDeposit);
            this.account_bank_control.Controls.Add(this.dbgBankAccounts);
            this.account_bank_control.Location = new System.Drawing.Point(4, 22);
            this.account_bank_control.Name = "account_bank_control";
            this.account_bank_control.Padding = new System.Windows.Forms.Padding(3);
            this.account_bank_control.Size = new System.Drawing.Size(900, 489);
            this.account_bank_control.TabIndex = 1;
            this.account_bank_control.Text = "Банковский счет";
            this.account_bank_control.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(572, 376);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Дата закрытия";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(575, 392);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "ID счета";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 39);
            this.button1.TabIndex = 13;
            this.button1.Text = "Закрыть счет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.textBox_date_open);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_kindDepoist);
            this.panel1.Controls.Add(this.textBox_idClient);
            this.panel1.Controls.Add(this.textBox_idbank);
            this.panel1.Controls.Add(this.button_bankAccount);
            this.panel1.Location = new System.Drawing.Point(564, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 286);
            this.panel1.TabIndex = 12;
            // 
            // textBox_date_open
            // 
            this.textBox_date_open.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBox_date_open.Location = new System.Drawing.Point(11, 173);
            this.textBox_date_open.MinDate = new System.DateTime(1999, 2, 21, 0, 0, 0, 0);
            this.textBox_date_open.Name = "textBox_date_open";
            this.textBox_date_open.Size = new System.Drawing.Size(299, 20);
            this.textBox_date_open.TabIndex = 11;
            this.textBox_date_open.Value = new System.DateTime(2021, 7, 14, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Дата открытия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Вид вклада";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID клиента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID счета";
            // 
            // textBox_kindDepoist
            // 
            this.textBox_kindDepoist.Location = new System.Drawing.Point(11, 122);
            this.textBox_kindDepoist.Name = "textBox_kindDepoist";
            this.textBox_kindDepoist.Size = new System.Drawing.Size(299, 20);
            this.textBox_kindDepoist.TabIndex = 5;
            // 
            // textBox_idClient
            // 
            this.textBox_idClient.Location = new System.Drawing.Point(11, 77);
            this.textBox_idClient.Name = "textBox_idClient";
            this.textBox_idClient.Size = new System.Drawing.Size(299, 20);
            this.textBox_idClient.TabIndex = 4;
            // 
            // textBox_idbank
            // 
            this.textBox_idbank.Location = new System.Drawing.Point(11, 32);
            this.textBox_idbank.Name = "textBox_idbank";
            this.textBox_idbank.Size = new System.Drawing.Size(299, 20);
            this.textBox_idbank.TabIndex = 3;
            // 
            // button_bankAccount
            // 
            this.button_bankAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_bankAccount.Location = new System.Drawing.Point(11, 231);
            this.button_bankAccount.Name = "button_bankAccount";
            this.button_bankAccount.Size = new System.Drawing.Size(299, 39);
            this.button_bankAccount.TabIndex = 2;
            this.button_bankAccount.Text = "Открыть счет";
            this.button_bankAccount.UseVisualStyleBackColor = false;
            this.button_bankAccount.Click += new System.EventHandler(this.button_bankAccount_Click);
            // 
            // id_close_account
            // 
            this.id_close_account.Location = new System.Drawing.Point(575, 342);
            this.id_close_account.Name = "id_close_account";
            this.id_close_account.Size = new System.Drawing.Size(299, 20);
            this.id_close_account.TabIndex = 6;
            // 
            // dvgKindDeposit
            // 
            this.dvgKindDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgKindDeposit.Location = new System.Drawing.Point(8, 309);
            this.dvgKindDeposit.Name = "dvgKindDeposit";
            this.dvgKindDeposit.Size = new System.Drawing.Size(546, 172);
            this.dvgKindDeposit.TabIndex = 1;
            // 
            // dbgBankAccounts
            // 
            this.dbgBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgBankAccounts.Location = new System.Drawing.Point(6, 6);
            this.dbgBankAccounts.Name = "dbgBankAccounts";
            this.dbgBankAccounts.Size = new System.Drawing.Size(548, 279);
            this.dbgBankAccounts.TabIndex = 0;
            // 
            // operation
            // 
            this.operation.Controls.Add(this.button2);
            this.operation.Controls.Add(this.label16);
            this.operation.Controls.Add(this.label15);
            this.operation.Controls.Add(this.label14);
            this.operation.Controls.Add(this.label13);
            this.operation.Controls.Add(this.moneee);
            this.operation.Controls.Add(this.label11);
            this.operation.Controls.Add(this.dateTimePicker2);
            this.operation.Controls.Add(this.text_money);
            this.operation.Controls.Add(this.text_id_bank);
            this.operation.Controls.Add(this.text_number_operation);
            this.operation.Controls.Add(this.text_month);
            this.operation.Controls.Add(this.text_idoperation);
            this.operation.Controls.Add(this.dvg_name_operation);
            this.operation.Controls.Add(this.dvg_operation);
            this.operation.Location = new System.Drawing.Point(4, 22);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(900, 489);
            this.operation.TabIndex = 2;
            this.operation.Text = "Банковские операции";
            this.operation.UseVisualStyleBackColor = true;
            // 
            // dvg_operation
            // 
            this.dvg_operation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_operation.Location = new System.Drawing.Point(8, 3);
            this.dvg_operation.Name = "dvg_operation";
            this.dvg_operation.Size = new System.Drawing.Size(884, 264);
            this.dvg_operation.TabIndex = 0;
            // 
            // dvg_name_operation
            // 
            this.dvg_name_operation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_name_operation.Location = new System.Drawing.Point(8, 340);
            this.dvg_name_operation.Name = "dvg_name_operation";
            this.dvg_name_operation.Size = new System.Drawing.Size(264, 141);
            this.dvg_name_operation.TabIndex = 1;
            // 
            // text_idoperation
            // 
            this.text_idoperation.Location = new System.Drawing.Point(375, 340);
            this.text_idoperation.Name = "text_idoperation";
            this.text_idoperation.Size = new System.Drawing.Size(142, 20);
            this.text_idoperation.TabIndex = 2;
            // 
            // text_month
            // 
            this.text_month.Location = new System.Drawing.Point(711, 340);
            this.text_month.Name = "text_month";
            this.text_month.Size = new System.Drawing.Size(142, 20);
            this.text_month.TabIndex = 3;
            // 
            // text_number_operation
            // 
            this.text_number_operation.Location = new System.Drawing.Point(543, 394);
            this.text_number_operation.Name = "text_number_operation";
            this.text_number_operation.Size = new System.Drawing.Size(142, 20);
            this.text_number_operation.TabIndex = 4;
            // 
            // text_id_bank
            // 
            this.text_id_bank.Location = new System.Drawing.Point(375, 394);
            this.text_id_bank.Name = "text_id_bank";
            this.text_id_bank.Size = new System.Drawing.Size(142, 20);
            this.text_id_bank.TabIndex = 5;
            // 
            // text_money
            // 
            this.text_money.Location = new System.Drawing.Point(543, 340);
            this.text_money.Name = "text_money";
            this.text_money.Size = new System.Drawing.Size(142, 20);
            this.text_money.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(711, 394);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "ID операции";
            // 
            // moneee
            // 
            this.moneee.AutoSize = true;
            this.moneee.Location = new System.Drawing.Point(540, 324);
            this.moneee.Name = "moneee";
            this.moneee.Size = new System.Drawing.Size(45, 13);
            this.moneee.TabIndex = 9;
            this.moneee.Text = "Деньги";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(710, 324);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "На сколько месяцев";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Счет банка. ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(540, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Номер операции. ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(708, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Дата операции";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(477, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank";
            this.tabControl1.ResumeLayout(false);
            this.clients_control.ResumeLayout(false);
            this.clients_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.account_bank_control.ResumeLayout(false);
            this.account_bank_control.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgKindDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbgBankAccounts)).EndInit();
            this.operation.ResumeLayout(false);
            this.operation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_operation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_name_operation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage clients_control;
        private System.Windows.Forms.TabPage account_bank_control;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button button_bd;
        private System.Windows.Forms.Button update_client;
        private System.Windows.Forms.TextBox textbox_passport;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clients_add;
        private System.Windows.Forms.DataGridView dbgBankAccounts;
        private System.Windows.Forms.DataGridView dvgKindDeposit;
        private System.Windows.Forms.Button button_bankAccount;
        private System.Windows.Forms.TabPage operation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_close_account;
        private System.Windows.Forms.TextBox textBox_kindDepoist;
        private System.Windows.Forms.TextBox textBox_idClient;
        private System.Windows.Forms.TextBox textBox_idbank;
        private System.Windows.Forms.DateTimePicker textBox_date_open;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvg_name_operation;
        private System.Windows.Forms.DataGridView dvg_operation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label moneee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox text_money;
        private System.Windows.Forms.TextBox text_id_bank;
        private System.Windows.Forms.TextBox text_number_operation;
        private System.Windows.Forms.TextBox text_month;
        private System.Windows.Forms.TextBox text_idoperation;
        private System.Windows.Forms.Button button2;
    }
}


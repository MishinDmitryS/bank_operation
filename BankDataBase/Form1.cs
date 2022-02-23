using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            clients_on_dgv();
            bank_account_on_dgv();
            kind_deposit_on_dgv();
            name_operations_on_dgv();
            operations_on_dgv();
        }

        private void button_bd_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MessageBox.Show("db connect");
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void update_client_Click(object sender, EventArgs e)
        {
            clients_on_dgv();
        }

        private void clients_on_dgv()
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                string script = "select * from clients";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dgvClients.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void bank_account_on_dgv()
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                string script = "select * from bank_accounts";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dbgBankAccounts.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void kind_deposit_on_dgv()
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                string script = "select * from kind_deposit";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dvgKindDeposit.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void operations_on_dgv()
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                string script = "select * from operations";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dvg_operation.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void name_operations_on_dgv()
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                string script = "select * from name_operations";
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlDataAdapter ms_data = new MySqlDataAdapter(script, connect);
                System.Data.DataTable table = new System.Data.DataTable();
                ms_data.Fill(table);
                dvg_name_operation.DataSource = table;
                mycon.Close();
            }
            catch
            {
                MessageBox.Show("db not connect");
            }
        }

        private void button_clients_add_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `clients` (`client_id`, `name`, `surname`, `passport`) VALUES (@id, @name, @lastname, @passport)", mycon);
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = textBox_id.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox_name.Text;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = textBox_lastname.Text;
                command.Parameters.Add("@passport", MySqlDbType.VarChar).Value = textbox_passport.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Клиент добавлен");
                mycon.Close();
                clients_on_dgv();
            }
            catch
            {
                MessageBox.Show("бд или запрос ошибка");
            }
        }

        private void button_bankAccount_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `bank_accounts`(`bank_account_id`, `data_open`, `kind_deposit_id`, `client_id`) VALUES (@id, @date_op, @kind_dep, @clientid)", mycon);
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = textBox_idbank.Text;
                command.Parameters.Add("@date_op", MySqlDbType.Date).Value = textBox_date_open.Value;
                command.Parameters.Add("@kind_dep", MySqlDbType.Int64).Value = textBox_kindDepoist.Text;
                command.Parameters.Add("@clientid", MySqlDbType.Int64).Value = textBox_idClient.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Cчет добавлен");
                mycon.Close();
                bank_account_on_dgv();
            }
            catch
            {
                MessageBox.Show("бд или запрос ошибка");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlCommand command = new MySqlCommand("UPDATE `bank_accounts` SET `data_close`=@dateclosed WHERE `bank_account_id`= @id;", mycon);
                command.Parameters.Add("@id", MySqlDbType.Int64).Value = id_close_account.Text;
                command.Parameters.Add("@dateclosed", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.ExecuteNonQuery();
                MessageBox.Show("Cчет закрыт");
                mycon.Close();
                bank_account_on_dgv();
            }
            catch 
            {
                MessageBox.Show("бд или запрос ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection mycon;
            string connect = "server=localhost;port=3307;username=root;password=root;database=bank_db";
            try
            {
                mycon = new MySqlConnection(connect);
                mycon.Open();
                MySqlCommand command = new MySqlCommand("INSERT INTO `operations`(`operation_id`, `money`, `months`, `data_operations`, " +
                    "`bank_account_id`, `name_operation_id`) VALUES (@oper_id,@money_oper,@months_oper,@date_oper,@bankid_oper,@name_oper_id)", mycon);
                command.Parameters.Add("@oper_id", MySqlDbType.Int64).Value = text_idoperation.Text;
                command.Parameters.Add("@money_oper", MySqlDbType.Int64).Value = text_money.Text;
                command.Parameters.Add("@months_oper", MySqlDbType.Int64).Value = text_money.Text;
                command.Parameters.Add("@date_oper", MySqlDbType.Date).Value = dateTimePicker2.Value;
                command.Parameters.Add("@bankid_oper", MySqlDbType.Int64).Value = text_id_bank.Text;
                command.Parameters.Add("@name_oper_id", MySqlDbType.Int64).Value = text_number_operation.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Операция создана");
                mycon.Close();
                operations_on_dgv();
            }
            catch
            {
                MessageBox.Show("бд или запрос ошибка");
            }
        }
    }
}

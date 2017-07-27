using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using NCRM.Properties;

namespace NCRM
{
    public partial class Login : Form
    {
        private string _conn;
        private MySqlConnection _connect;

        private string _dept;

        public Login()
        {
            InitializeComponent();
        }


        //ONLOAD: check settings for user&Pass ----------------------//
        private void Login_Load(object sender, EventArgs e)
        {
            if (Settings.Default.userName == string.Empty) return;
            tbUsername.Text = Settings.Default.userName;
            tbPassword.Text = Settings.Default.userPass;
        }


        // HASHCODE -----------------------------------------------//
        public static string HashCode(string str)
        {
            var rethash = "";
            try
            {
                var hash = SHA1.Create();
                var encoder = new ASCIIEncoding();
                var combined = encoder.GetBytes(str);
                hash.ComputeHash(combined);
                rethash = BitConverter.ToString(hash.Hash).Replace("-", "");
                rethash = rethash.ToLower();
            }
            catch (Exception ex)
            {
                var strerr = "Error in HashCode : " + ex.Message;
                Console.WriteLine(strerr);
            }
            return rethash;
        }


        // DB_CONNECTION  -----------------------------------------------//
        private void db_connection()
        {
            try
            {
                _conn = "HIDDENRESOURCE"; 
                _connect = new MySqlConnection(_conn);
                _connect.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                //throw;
            }
        } //db_connection


        // VALIDATE LOGIN -----------------------------------------------//
        private bool validate_login(string user, string pass)
        {
            db_connection();
            var cmd = new MySqlCommand();
            cmd.CommandText =
                "SELECT * FROM HIDDENRESOURCE";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = _connect;

            var login = cmd.ExecuteReader();
            if (login.Read())
            {
                _dept = login.GetString("dept");
                _connect.Close();
                return true;
            }
            _connect.Close();
            return false;
        }



        // BTNLOGIN CLICK -----------------------------------------------//
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if Remember user&Pass Store in settings ------------//
            if (cbRemember.Checked)
            {
                Settings.Default.userName = tbUsername.Text;
                Settings.Default.userPass = tbPassword.Text;
                Settings.Default.Save();
            }


            //Get txt + salt&hash and verify user ------------------//
            var user = tbUsername.Text.ToLower();
            var pass = tbPassword.Text;
            var salt = "HIDDENSALTRESOURCE";
            pass = salt + pass;
            var saltedHash = HashCode(pass);

            //if blank return error --------------------------------//
            if (user == "" || pass == "")
            {
                MessageBox.Show(@"Empty Fields Detected ! Please provide username and password");
                return;
            }

            // proc VALIDATE ---------------------------------------//
            var r = validate_login(user, saltedHash);


            // If True ---------------------------------------------//
            if (r)
            {
                // Set Coordinator Email in UserOn from username ---//
                var coord = user + "@HIDDENRESOURCE";
                var sysUser = new UserOn(coord, _dept);


                // HIDDENRESOURCE OR HIDDENRESOURCE ----------------------//        
                if (_dept == "HIDDENRESOURCE") //HIDDENRESOURCE  //SysUser.GetUserDept()
                {
                    Hide();
                    var lrForm = new ListRequests {SysUser = sysUser};
                    lrForm.Show();
                }
                else if (_dept == "HIDDENRESOURCE")
                {
                    // MessageBox.Show("User is HIDDENRESOURCE");
                    Hide();
                    var vaForm = new ViewApproved {SysUser = sysUser};
                    vaForm.Show();
                }
            }
            else
            {
                MessageBox.Show(@"Incorrect Login Credentials");
            }
        }

//ENDOFLINE
    }
}
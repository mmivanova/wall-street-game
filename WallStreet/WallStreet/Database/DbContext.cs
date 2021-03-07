using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WallStreet.Database
{
    class DbContext
    {
        private MySqlConnection mySqlConnection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;


        public DbContext()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            port = "3307";
            database = "wall-street-game_db_1";
            uid = "root";
            password = "root";
            var connectionString = "SERVER=" + server + "; " + "PORT=" + port +"; "+ "DATABASE=" +
                                   database + "; " + "UID=" + uid + "; " + "PWD=" + password + ";";

            mySqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                mySqlConnection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}

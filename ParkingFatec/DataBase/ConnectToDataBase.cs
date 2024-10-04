using System.Data;
using MySql.Data.MySqlClient;
using ParkingFatec.Body;
using ParkingFatec.View;


namespace ParkingFatec.DataBase
{
    public class ConnectToDataBase
    {
        private static MySqlConnection bdConn = new MySqlConnection("Server=localhost;Database=dbcs;Uid=samuel;Pwd=lucas21"); 
        private static MySqlDataAdapter bdAdapter;
        private static DataSet bdDataSet = new DataSet(); 

        static public MySqlConnection connectToDatase()
        {
            try
            {
                if (bdConn.State != ConnectionState.Open)
                {
                    bdConn.Open();
                }
            }
            catch{}
            
            return bdConn;
        }
        public static void insertUser(User user, CadastroView i)
        {
            try
            {
                if (connectToDatase() != null)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO users(name,email,passwd) VALUES(@username,@email,@password)", connectToDatase());
                    command.Parameters.AddWithValue("@username", user.getName());
                    command.Parameters.AddWithValue("@email", user.getEmail());
                    command.Parameters.AddWithValue("@password", user.getPassword());
                    command.ExecuteScalar();
                    new CadastroViewDialog(i).ShowDialog();
                }
            }
            catch (MySqlException ex) { 
                MessageBox.Show("Erro ao Cadastrar o Usuário","Aviso!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                if(bdConn != null) bdConn.Close();
            }
        }
        public static bool checkUser(string username, string password)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("SELECT COUNT(1) FROM users WHERE email = @users AND passwd = @pass", connectToDatase()))
                {

                    command.Parameters.AddWithValue("@users", username);
                    command.Parameters.AddWithValue("@pass", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                } 

            }
            catch (MySqlException ex) { }

            finally
            {
                if(connectToDatase()!=null) connectToDatase().Close();
            }

            return false;
        }
        public static int checkUser(string username)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand("SELECT id FROM users WHERE email = @users", connectToDatase()))
                {

                    command.Parameters.AddWithValue("@users", username);
                    return Convert.ToInt32(command.ExecuteScalar());
                }

            }
            catch (MySqlException ex) { }

            finally
            {
                if (connectToDatase() != null) connectToDatase().Close();
            }

            return -1;
        }


        public static List<string> getUserName()
        {
            List<string> list = new List<string>();
            try
            {
                if (connectToDatase() != null)
                {
                 MySqlCommand i = new MySqlCommand("SELECT name FROM users WHERE name = 'Samuel'", connectToDatase());
                    MessageBox.Show(Convert.ToString(i.ExecuteScalar()));

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                connectToDatase().Close();
            }
            return list;
        }

    }
}


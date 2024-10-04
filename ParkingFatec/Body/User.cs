namespace ParkingFatec.Body
{
    public class User
    {
        private short _id;
        private string _name;
        private string _email;
        private string _password;
        public string getName() { return _name; }
        public string getEmail() { return _email; }
        public string getPassword() { return _password; }
        public short getId() { return _id; }
        public void setName(string name) { _name = name; }
        public void setEmail(string email) { _email = email; }
        public void setPassword(string password) { _password = password; }
        public void setId(short id) { _id = id; }
    }
}

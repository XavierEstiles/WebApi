namespace WebApi.Models
{
    public class User
    {
        public User(int _id,string _name, string _email, int _mainImage ) 
        { 
            id = _id;
            name = _name;
            email = _email;
            mainImage = _mainImage;
        }
        public User() { }
        public int id { get; set; }
        public string name { get; set; } = "";
        public string email { get; set; } = "";
        public int mainImage { get; set; }
    }
}

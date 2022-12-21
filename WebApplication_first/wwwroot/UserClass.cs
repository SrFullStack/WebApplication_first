namespace WebApplication_first.wwwroot
{
    public class UserClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public int password { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

        public UserClass(int id)
        {
                 this.id=id 
        }
    }
}

namespace WebApp2.Models
{
    public class UserModel
    {

        public int Id { get; set; } 
        public string UserName { get; set; }    
        public string Password { get; set; }
        public string Email { get; set; }
        public string Details { get; set; } 
        public bool RememberMe { get; set; }    

    }
}

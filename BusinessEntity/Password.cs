namespace BusinessEntity
{
    public class Password
    {
        public Password(string sitename, string username, string email, string textpassword)
        {
            SiteName = sitename;
            Username = username;
            Email = email;
            TextPassword = textpassword;
        }

        protected Password() { }

        public int Id { get; set; }
        public string SiteName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string TextPassword { get; set; }
    }
}

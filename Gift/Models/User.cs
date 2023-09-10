namespace Gift.Models
{
    [PrimaryKey(nameof(Id))]
    public class User
    {
        private int Id { get; set; }
        public string UserName { get; private set; } = string.Empty;
		public string Password { get; private set; } = string.Empty;
		public List<User> Homies { get; private set; }
        
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Gift.Models
{
    [PrimaryKey(nameof(Id))]
    public class User
    {
		
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; private set; }

        public string UserName { get; set; } = string.Empty;
		public string Password { get; set; } = string.Empty;
        public IEnumerable<Era> Eras { get; set; }
        public DateTime CreatedAt { get; set; }
	}
}

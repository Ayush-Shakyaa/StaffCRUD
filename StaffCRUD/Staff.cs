using System.ComponentModel.DataAnnotations;

namespace StaffCRUD
{
    public class Staff
    {
        
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }
    
}
}

using System.ComponentModel.DataAnnotations;
using Task.DTOs.Cirtifcation;

namespace Task.DTOs.User
{
    public class UserReadDTO
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        public int CirtficatNum { get; set; }
        public ICollection<CertificationChildReadDTO>? Certifications { get; set; }
    }
}

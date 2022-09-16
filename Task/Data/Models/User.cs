using System.ComponentModel.DataAnnotations;

namespace Task.Data.Models;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public int CirtficatNum { get; set; } 

    public ICollection<Certification>  Certifications{ get; set; } = new HashSet<Certification>();
}

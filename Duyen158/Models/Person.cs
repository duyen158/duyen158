using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Duyen158.Models{
[Table("Person")]

public class Person{
    [Key]
    public String? PersonId { get; set;}
    public string? FullName { get; set;}
    public string? Address { get; set;}
}
}
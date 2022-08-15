using System.ComponentModel.DataAnnotations.Schema;

namespace minimalapicleanarchitecture.Model;

public class Entity : Base
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address1 { get; set; }
    public int? CountryId { get; set; }

}
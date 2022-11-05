using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Newtonsoft.Json;

namespace BlazorValidation.Data;

public class Employee
{
    [Required]
    [DisplayName("First Name")]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; } = "";

    [Required]
    [DisplayName("Last Name")]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; } = "";

    [Required]
    [DisplayName("Email")]
    [DataType(DataType.EmailAddress)]
    [JsonProperty(PropertyName = "email")]
    [EmailAddress]
    public string Email { get; set; } = "";
}

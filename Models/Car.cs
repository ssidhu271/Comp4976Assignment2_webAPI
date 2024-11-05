using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExoticCarsAPI.Models;

public class Car
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<string> Countries { get; set; } = new List<string>();
    public string? Image { get; set; } // Base64-encoded string for image
    [Column(TypeName = "decimal(18,2)")]
    public decimal Cost { get; set; }
}

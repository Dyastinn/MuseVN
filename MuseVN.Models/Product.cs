using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuseVN.Models;
public class Product {
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Developer { get; set; }

    [Required]
    public double Price { get; set;}

    [Required]
    public List<string> GameTags { get; set; }

    [Required]
    public List<string> Platform { get; set; }

    [Required]
    public List<string> SupportedLanguage { get; set; }

    [Required]
    public DateOnly Date { get; set; }


}


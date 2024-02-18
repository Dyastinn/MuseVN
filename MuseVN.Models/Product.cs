using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    public int TagId { get; set; }
    [ForeignKey("TagId")]
    public Tag Tag { get; set; }

    public int PlatformId {  get; set; }
    [ForeignKey("PlatformId")]
    public Platform Platform { get; set; }

    public int SupportedLangId { get; set; }
    [ForeignKey("SupportedLangId")]
    public Language Language { get; set; }


    public DateOnly Date { get; set; }

    public string ImageUrl {  get; set; }

   


}


using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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

    [Required]
    public string Tag { get; set; }

    [Required]
    public string Platform {  get; set; }

    [Required]
    public string Language { get; set; }

    [Required]
    public DateOnly Date { get; set; }

    [ValidateNever]
    public string ImageUrl {  get; set; }

   


}


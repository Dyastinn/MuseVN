﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuseVN.Models; 
public class Language {

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [DisplayName("Category Name")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Display Order")]
    [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
    public int DisplayOrder { get; set; }

}

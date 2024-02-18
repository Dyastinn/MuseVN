using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuseVN.Models; 
public class Language {
    [Key]
    public int Id { get; set; }

    public bool English { get; set; }

    [DisplayName("Simplified Chinese")]
    public bool SimplifiedChinese { get; set; }

    [DisplayName("Traditional Chinese")]
    public bool TraditionalChinese { get; set; }

    public bool Tagalog {  get; set; }

    public bool Spanish { get; set; }

    public bool Japanese { get; set; }

}

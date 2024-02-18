using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.Models;
public class Tag {

    [Required]
    [Key]
    public int Id {  get; set; }
    public bool Action {  get; set; }

    public bool Comedy { get; set; }
    
    public bool Drama { get; set; }
    
    public bool Educational { get; set; }

    public bool Fantasy { get; set; }

    public bool Horror { get; set; }

    public bool Mystery { get; set; }

    public bool Romance { get; set; }

    [DisplayName("Science Fiction")]
    public bool ScienceFiction {  get; set; }

    public bool NSFW { get; set; }

    [DisplayName("Slice of Life")]
    public bool SliceOfLife { get; set; }  

}

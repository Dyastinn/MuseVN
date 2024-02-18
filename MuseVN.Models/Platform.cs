using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseVN.Models; 
public class Platform {
    [Key]
    public int Id { get; set; }

    public bool Linux { get; set; }

    public bool Mac { get; set; }

    public bool Windows { get; set; }
}

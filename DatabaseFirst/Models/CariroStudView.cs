using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

[Keyless]
public partial class CariroStudView
{
    [StringLength(50)]
    public string St_Fname { get; set; }

    public int St_Id { get; set; }

    [StringLength(100)]
    public string St_Address { get; set; }
}

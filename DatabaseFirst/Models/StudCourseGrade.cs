using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

[Keyless]
public partial class StudCourseGrade
{
    public int St_Id { get; set; }

    [StringLength(50)]
    public string St_Fname { get; set; }

    public int Crs_Id { get; set; }

    [StringLength(50)]
    public string Crs_Name { get; set; }

    public int? Grade { get; set; }
}

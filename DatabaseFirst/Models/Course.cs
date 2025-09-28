﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

[Table("Course")]
public partial class Course
{
    [Key]
    public int Crs_Id { get; set; }

    [StringLength(50)]
    public string Crs_Name { get; set; }

    public int? Crs_Duration { get; set; }

    public int? Top_Id { get; set; }

    [InverseProperty("Crs")]
    public virtual ICollection<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();
}

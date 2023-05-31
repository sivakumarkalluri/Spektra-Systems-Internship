using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Table("Course")]
public partial class Course
{
    [Key]
    public int CourseId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CourseName { get; set; }

    public int? TeacherId { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("Courses")]
    public virtual Teacher? Teacher { get; set; }

    [ForeignKey("CourseId")]
    [InverseProperty("Courses")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}

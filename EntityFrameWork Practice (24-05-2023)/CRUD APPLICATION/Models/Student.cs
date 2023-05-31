using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Table("Student")]
public partial class Student
{
    [Key]
    public int StudentId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public int? StandardId { get; set; }

    [ForeignKey("StandardId")]
    [InverseProperty("Students")]
    public virtual Standard? Standard { get; set; }

    [InverseProperty("Student")]
    public virtual StudentAddress? StudentAddress { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Students")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}

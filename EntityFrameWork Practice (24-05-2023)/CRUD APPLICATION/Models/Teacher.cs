using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Table("Teacher")]
public partial class Teacher
{
    [Key]
    public int TeacherId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public int? StandardId { get; set; }

    [InverseProperty("Teacher")]
    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    [ForeignKey("StandardId")]
    [InverseProperty("Teachers")]
    public virtual Standard? Standard { get; set; }
}

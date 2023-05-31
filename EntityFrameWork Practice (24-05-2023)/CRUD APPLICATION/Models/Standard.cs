using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Table("Standard")]
public partial class Standard
{
    [Key]
    public int StandardId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? StandardName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Description { get; set; }

    [InverseProperty("Standard")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [InverseProperty("Standard")]
    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}

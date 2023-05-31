using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Table("StudentAddress")]
public partial class StudentAddress
{
    [Key]
    public int StudentId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentAddress")]
    public virtual Student Student { get; set; } = null!;
}

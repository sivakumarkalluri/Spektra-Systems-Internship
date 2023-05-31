using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentsRanks.Models;

[Table("student_details")]
public partial class StudentDetail
{
    [Key]
    [Column("studentid")]
    public int Studentid { get; set; }

    [Column("name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("age")]
    public int? Age { get; set; }

    [Column("standard")]
    public int? Standard { get; set; }

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }
}

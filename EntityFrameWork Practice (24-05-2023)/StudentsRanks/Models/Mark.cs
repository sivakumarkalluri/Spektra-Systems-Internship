using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace StudentsRanks.Models;

[Keyless]
[Table("marks")]
public partial class Mark
{
    [Column("studentid")]
    public int? Studentid { get; set; }

    [Column("mathsMarks")]
    public int? MathsMarks { get; set; }

    public int? EnglishMarks { get; set; }

    public int? PhysicsMarks { get; set; }

    public int? ScienceMarks { get; set; }

    public int? SocialMarks { get; set; }

    [ForeignKey("Studentid")]
    public virtual StudentDetail? Student { get; set; }
}

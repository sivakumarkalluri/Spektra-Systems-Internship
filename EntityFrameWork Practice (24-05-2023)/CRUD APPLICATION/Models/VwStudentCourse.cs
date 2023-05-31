using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

[Keyless]
public partial class VwStudentCourse
{
    public int StudentId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public int CourseId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CourseName { get; set; }
}

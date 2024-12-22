using System;
using System.Collections.Generic;

namespace DatabaseFirstApproach2.Models;

public partial class Employe
{
    public int Id { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string EmployeeGender { get; set; } = null!;

    public int Age { get; set; }

    public string EmployeeCity { get; set; } = null!;
}

namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;

//  Field      Type         Null  Key  Default  Extra
// +----------+------------+-----+----+--------+---------------+
//  ServerID   int(11)      NO    PRI  NULL     auto_increment
//  FirstName  varchar(25)  NO         NULL
//  LastName   varchar(25)  NO         NULL
//  HireDate   date         NO         NULL
//  TermDate   date         YES        NULL
//  DoB        date         NO         NULL

public class Server
{
    [Key]
    public int       ServerID  { get; set; }

    public string    FirstName { get; set; } = null!;
    public string    LastName  { get; set; } = null!;
    public DateTime  HireDate  { get; set; }
    public DateTime? TermDate  { get; set; }
    public DateTime  DoB       { get; set; }
}

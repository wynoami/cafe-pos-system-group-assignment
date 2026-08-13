namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;

//  Field          Type         Null  Key  Default  Extra
// +--------------+------------+-----+----+--------+---------------+
//  TimeOfDayID    int(11)      NO    PRI  NULL     auto_increment
//  TimeOfDayName  varchar(50)  NO         NULL

public class TimeOfDay
{
    [Key]
    public int TimeOfDayID      { get; set; }
    public string TimeOfDayName { get; set; } = null!;
}

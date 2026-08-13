namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//  Field         Type         Null  Key  Default  Extra
// +-------------+------------+-----+----+--------+---------------+
//  CategoryID    int(11)      NO    PRI  NULL     auto_increment
//  CategoryName  varchar(50)  NO         NULL

public class Category
{
    [Key]
    public int CategoryID      { get; set; }
    public string CategoryName { get; set; } = null!;

    public ICollection<Item?>? Items { get; set; }
}

namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//  Field         Type         Null  Key  Default  Extra
// +-------------+------------+-----+----+--------+---------------+
//  CategoryID    int(11)      NO    PRI  NULL     auto_increment
//  CategoryName  varchar(50)  NO         NULL

public class CategoryModel
{
    [Key]
    public int CategoryID      { get; set; }
    public string CategoryName { get; set; } = null!;
}

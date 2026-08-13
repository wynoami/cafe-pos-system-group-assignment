namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//  Field            Type          Null  Key  Default  Extra
// +----------------+-------------+-----+----+--------+---------------+
//  ItemID           int(11)       NO    PRI  NULL     auto_increment
//  CategoryID       int(11)       NO    MUL  NULL
//  ItemName         varchar(50)   NO         NULL
//  ItemDescription  varchar(255)  NO         NULL

public class ItemModel
{
    [Key]
    public int ItemID { get; set; }

    [ForeignKey("Category")]
    public int CategoryID { get; set; }

    public string ItemName        { get; set; } = null!;
    public string ItemDescription { get; set; } = null!;
}

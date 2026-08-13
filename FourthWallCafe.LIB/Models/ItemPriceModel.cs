using System.ComponentModel.DataAnnotations.Schema;

namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;

//  Field        Type          Null  Key  Default  Extra
// +------------+-------------+-----+----+--------+---------------+
//  ItemPriceID  int(11)       NO    PRI  NULL     auto_increment
//  ItemID       int(11)       NO    MUL  NULL
//  TimeOfDayID  int(11)       NO    MUL  NULL
//  Price        decimal(5,2)  NO         NULL
//  StartDate    date          NO         NULL
//  EndDate      date          YES        NULL

public class ItemPriceModel
{
    [Key]
    public int ItemPriceID { get; set; }

    [ForeignKey("Item")]
    public int ItemID { get; set; }

    [ForeignKey("TimeOfDay")]
    public int TimeOfDayID { get; set; }

    public decimal Price      { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate   { get; set; }
}

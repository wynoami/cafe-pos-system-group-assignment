using System.ComponentModel.DataAnnotations.Schema;

namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;

//  Field        Type          Null  Key  Default  Extra
// +------------+-------------+-----+----+--------+---------------+
//  ItemPriceID  int(11)       NO    PRI  NULL     auto_increment
//  ItemID       int(11)       NO    MUL  NULL
//  TimeOfDayID  int(11)       NO    MUL  NULL
//  Price        decimal(5,2)  NO         NULL
//  StartDate    date          NO         NULL
//  EndDate      date          YES        NULL

public class ItemPrice
{
    [Key]
    public int ItemPriceID { get; set; }

    [ForeignKey("Item")]
    public int ItemID { get; set; }
    public virtual OrderItem? Item { get; set; }

    [ForeignKey("TimeOfDay")]
    public int TimeOfDayID { get; set; }
    public virtual TimeOfDay? TimeOfDay { get; set; }

    public decimal Price      { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate   { get; set; }

    public ICollection<OrderItem?>? OrderEntries { get; set; }
}

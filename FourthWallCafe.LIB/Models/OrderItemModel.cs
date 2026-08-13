using System.ComponentModel.DataAnnotations.Schema;

namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;

//  Field          Type          Null  Key  Default  Extra
// +--------------+-------------+-----+----+--------+---------------+
//  OrderItemID    int(11)       NO    PRI  NULL     auto_increment
//  OrderID        int(11)       NO    MUL  NULL
//  ItemPriceID    int(11)       NO    MUL  NULL
//  Quantity       tinyint(4)    NO         NULL
//  ExtendedPrice  decimal(6,2)  NO         0.00

public class OrderItemModel
{
    [Key]
    public int OrderItemID { get; set; }

    [ForeignKey("CafeOrder")]
    public int OrderID { get; set; }

    [ForeignKey("ItemPrice")]
    public int ItemPriceID { get; set; }

    public int Quantity          { get; set; }
    public decimal ExtendedPrice { get; set; }
}

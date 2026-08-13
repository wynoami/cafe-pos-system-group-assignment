namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//  Field          Type          Null  Key  Default  Extra
// +--------------+-------------+-----+----+--------+---------------+
//  OrderID        int(11)       NO    PRI  NULL     auto_increment
//  ServerID       int(11)       YES   MUL  NULL
//  PaymentTypeID  int(11)       YES   MUL  NULL
//  OrderDate      datetime(6)   NO         NULL
//  SubTotal       decimal(6,2)  YES        NULL
//  Tax            decimal(6,2)  YES        NULL
//  Tip            decimal(6,2)  YES        NULL
//  AmountDue      decimal(6,2)  YES        NULL

public class CafeOrder
{
    [Key]
    public int OrderID { get; set; }

    [ForeignKey("Server")]
    public int ServerID { get; set; }
    public virtual Server? Server { get; set; }

    [ForeignKey("PaymentType")]
    public int PaymentTypeID { get; set; }
    public virtual PaymentType? PaymentType { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal SubTotal   { get; set; }
    public decimal Tax        { get; set; }
    public decimal Tip        { get; set; }
    public decimal AmountDue  { get; set; }

    public ICollection<OrderItem?>? OrderEntries { get; set; }
}

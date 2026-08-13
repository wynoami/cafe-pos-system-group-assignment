namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;

//  Field            Type         Null  Key  Default  Extra
// +----------------+------------+-----+----+--------+---------------+
//  PaymentTypeID    int(11)      NO    PRI  NULL     auto_increment
//  PaymentTypeName  varchar(50)  NO         NULL

public class PaymentTypeModel
{
    [Key]
    public int PaymentTypeID      { get; set; }
    public string PaymentTypeName { get; set; } = null!;
}

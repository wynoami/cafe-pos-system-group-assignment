namespace FourthWallCafe.LIB.Entities;

using System.ComponentModel.DataAnnotations;

//  Field            Type         Null  Key  Default  Extra
// +----------------+------------+-----+----+--------+---------------+
//  PaymentTypeID    int(11)      NO    PRI  NULL     auto_increment
//  PaymentTypeName  varchar(50)  NO         NULL

public class PaymentType
{
    [Key]
    public int PaymentTypeID      { get; set; }
    public string PaymentTypeName { get; set; } = null!;

    // the diagram is wrong here and i am right >:[
    public ICollection<CafeOrder?>? Orders { get; set; }
}

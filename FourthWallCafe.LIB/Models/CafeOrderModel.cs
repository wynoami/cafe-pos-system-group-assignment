namespace FourthWallCafe.LIB.Models;

using System.ComponentModel.DataAnnotations;

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

public class CafeOrderModel
{

}

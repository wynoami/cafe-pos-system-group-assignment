namespace FourthWallCafe.LIB.Interfaces;

using FourthWallCafe.LIB.Enums;

//////// NEEDED FUNCTIONALITY ////////
//
// retrieve active Servers
//
// retrieve all open CafeOrders
//
// retrieve details for a CafeOrder
//     - include assigned Server
//     - include OrderItem's
//     - display OrderDate, SubTotal
//
// create a CafeOrder for an active Server
//     - use the current DateTime
//
// retrieve all Items
// retrieve all OrderItems/Items? associated with an Order
// create (add) OrderItems for an open CafeOrder
//     - include ItemID and Quantity
//
// retrieve available PaymentTypes
// update payment

public interface IRepository<T>
{
    T? CreateItem(string[] Details);
    T? UpdateValues(Option Option, int Id, string[] Values);
    T? RetrieveSingle(Option Option, int Id);

    bool AddItem(T Item);
    bool UpdateItem(T Item);
    bool IfStatus(Option Option, int Id);

    ICollection<T?>? RetrieveSet(Option Option, string Search);
}

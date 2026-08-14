namespace FourthWallCafe.LIB.Interfaces;

using FourthWallCafe.LIB.Utils;

//////// NEEDED FUNCTIONALITY ////////
//
// create a CafeOrder for an active Server
//     - use the current DateTime
//
// retrieve all Items? associated with an Order
//
// create (add) OrderItems for an open CafeOrder
//     - include ItemID and Quantity

public interface IRepository<T>
{
    T? CreateItem(UpdateData Values);
    T? UpdateValues(Option Option, int Id, UpdateData Values);
    T? RetrieveSingle(Option Option, int Id);
    ICollection<T?>? RetrieveSet(Option Option, string Search);

    bool AddItem(T Item);
    bool UpdateItem(T Item);
    bool ValidateItem(Option Option, T Item);
    bool IfStatus(Option Option, int Id);
}

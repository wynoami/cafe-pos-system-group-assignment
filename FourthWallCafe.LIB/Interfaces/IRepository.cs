namespace FourthWallCafe.LIB.Interfaces;

using FourthWallCafe.LIB.Utils;

//////// NEEDED FUNCTIONALITY ////////
//
// create (add) OrderItems for an open CafeOrder
//     - include ItemID and Quantity

public interface IRepository<T>
{
    T? CreateEntity(UpdateData Values);
    T? UpdateValues(Option Option, int Id, UpdateData Values);
    T? RetrieveSingle(Option Option, int Id);
    ICollection<T?>? RetrieveSet(Option Option, string Search);

    bool AddEntity(T Entity);
    bool UpdateEntity(T Entity);
    bool ValidateEntity(Option Option, T Entity);
    bool Status(Option Option, int Id);
}

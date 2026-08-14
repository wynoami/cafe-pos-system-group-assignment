namespace FourthWallCafe.LIB.Interfaces;

using FourthWallCafe.LIB.Utils;

public interface IRepository<T>
{
    // 'int Id' arguments are meant for recorded data
    // 'T Entity' arguments will typically refer to transient data
    // these are just guidelines

    T? CreateEntity(UpdateData Values);
    T? UpdateValues(Option Option, int Id, UpdateData Values);
    T? RetrieveSingle(Option Option, int Id);
    ICollection<T?>? RetrieveSet(Option Option, string Search);

    bool AddEntity(T Entity);
    bool UpdateEntity(T Entity);
    bool ValidateEntity(Option Option, T Entity);
    bool Status(Option Option, int Id);
}

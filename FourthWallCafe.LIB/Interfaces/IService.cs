namespace FourthWallCafe.LIB.Interfaces;

using FourthWallCafe.LIB.Utils;
using FourthWallCafe.LIB.Results;

public interface IService<T>
{
    // Preliminary
    // Create, Read, Update, Delete; POST, PUT, GET, DELETE
    Result<T?> CreateObject(UpdateData Values);
    Result<T?> UpdateValues(Option Option, int Id, UpdateData Values);
    Result<T?> RetrieveSingle(Option Option, int Id);
    Result<List<T?>?> RetrieveSet(Option Option, string Search);

    Result AddObject(T Object);
    Result UpdateObject(T Object);
    Result ValidateObject(Option Option, T Object);
    Result Status(Option Option, int Id);
}

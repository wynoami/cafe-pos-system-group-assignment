namespace FourthWallCafe.LIB.Results;

public class Result (bool O, string M)
{
    public bool Ok { get; } = O;
    public string Message { get; private set; } = M;
}

public class Result<T>(bool O, string M, T? D)
    : Result(O, M)
{
    public T? Data { get; set; } = D;
}

public static class ResultGenerator
{

    public static Result Success()
    {
        return new Result(true, string.Empty);
    }

    public static Result<T> Success<T>(T data)
    {
        return new Result<T>(true, string.Empty, data);
    }

    public static Result Fail(string message)
    {
        return new Result(false, message);
    }

    public static Result<T> Fail<T>(string message)
    {
        return new Result<T>(false, message, default);
    }

}

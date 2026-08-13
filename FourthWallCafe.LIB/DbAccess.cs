namespace FourthWallCafe.LIB;

public static class DbAccess
{
    public static readonly string Credentials = Environment.GetEnvironmentVariable("LOCALDB_CREDENTIALS") ??
        "server=127.0.0.1;" +
        "uid=root;" +
        "pwd=;" +
        "database=FourthWallCafe";
}

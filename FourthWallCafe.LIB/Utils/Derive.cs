namespace FourthWallCafe.LIB.Utils;

public static class Derive
{
    public static int? DeriveInt(this string? Source)
    {
        return int.TryParse(Source, out int Outcome) ? Outcome : null;
    }

    public static decimal? DeriveDecimal(this string? Source)
    {
        return decimal.TryParse(Source, out decimal Outcome) ? Outcome : null;
    }

    public static DateTime? DeriveDate(this string? Source)
    {
        return DateTime.TryParse(Source, out DateTime Outcome) ? Outcome : null;
    }
}

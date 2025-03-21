namespace DevExpert.Marketplace.Shared.Extensions;

public static class IEnumerableExtensions
{
    public static bool IsNullOrEmpty<T>(this IEnumerable<T>? value) => value == null || !value.Any();
}
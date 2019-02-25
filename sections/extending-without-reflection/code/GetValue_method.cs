private object GetValue(string faker, string method)
{
    object value = null;
    switch (faker.ToLowerInvariant())
    {
        case "app":
            value = GetValueForAppFaker(method);
            break;

        case "name":
            value = GetValueForNameFaker(method);
            break;

        case "university":
            value = GetValueForUniversityFaker(method);
            break;

        default:
            throw new FormatException($"Invalid module: {faker}");
    }

    return value ?? throw new FormatException($"Invalid method: {faker}.{method}");
}

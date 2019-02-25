private object GetValueForAppFaker(string method)
{
    switch (method.ToLowerInvariant())
    {
        case "name":
            return _fakerContainer.App.Name();

        case "version":
            return _fakerContainer.App.Version();

        case "author":
            return _fakerContainer.App.Author();

        default:
            return null;
    }
}

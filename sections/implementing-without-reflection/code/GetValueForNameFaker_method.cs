private object GetValueForNameFaker(string method)
{
    switch (method.ToLowerInvariant())
    {
        case "firstname":
            return _fakerContainer.Name.FirstName();

        case "lastname":
            return _fakerContainer.Name.LastName();

        case "name":
            return _fakerContainer.Name.Name();

        case "title":
            return _fakerContainer.Name.Title();

        default:
            return null;
    }
}

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

        case "namewithmiddle":
            return _fakerContainer.Name.NameWithMiddle();

        case "prefix":
            return _fakerContainer.Name.Prefix();

        case "suffix":
            return _fakerContainer.Name.Suffix();

        case "title":
            return _fakerContainer.Name.Title();

        default:
            return null;
    }
}

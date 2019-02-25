private object GetValueForUniversityFaker(string method)
{
    switch (method.ToLowerInvariant())
    {
        case "name":
            return _fakerContainer.University.Name();

        case "prefix":
            return _fakerContainer.University.Prefix();

        case "suffix":
            return _fakerContainer.University.Suffix();

        case "greekorganization":
            return _fakerContainer.University.GreekOrganization();

        case "greekalphabet":
            return _fakerContainer.University.GreekAlphabet();

        default:
            return null;
    }
}

internal interface IFakerContainer
{
    IAddressFaker Address { get; }
    IDateFaker Date { get; }
    INameFaker Name { get; }
    INumberFaker Number { get; }
    IRandomFaker Random { get; }
    ITimeFaker Time { get; }
    IUniversityFaker University { get; }
}
namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IlIndexElement
    {
        /// <summary>
        /// Gets the day.
        /// </summary>
        PositiveInt Value { get; }
    }
}
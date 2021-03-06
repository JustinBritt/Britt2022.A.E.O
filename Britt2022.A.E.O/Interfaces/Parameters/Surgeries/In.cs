namespace Britt2022.A.E.O.Interfaces.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface In
    {
        ImmutableList<InParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);
    }
}
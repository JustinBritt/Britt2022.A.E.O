﻿namespace Britt2020.A.E.O.Interfaces.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface ID
    {
        ImmutableList<IDParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            IωIndexElement ωIndexElement);
    }
}
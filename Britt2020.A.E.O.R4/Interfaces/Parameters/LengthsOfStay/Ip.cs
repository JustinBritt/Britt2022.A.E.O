﻿namespace Britt2020.A.E.O.Interfaces.Parameters.LengthsOfStay
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface Ip
    {
        ImmutableList<IpParameterElement> Value { get; }

        double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement);
    }
}
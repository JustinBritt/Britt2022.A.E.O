﻿namespace Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IfFactory
    {
        If Create(
            ImmutableList<IfParameterElement> value);
    }
}
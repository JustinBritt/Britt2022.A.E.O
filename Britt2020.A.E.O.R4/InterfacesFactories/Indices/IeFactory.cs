﻿namespace Britt2020.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;

    public interface IeFactory
    {
        Ie Create(
            ImmutableList<IeIndexElement> value);
    }
}
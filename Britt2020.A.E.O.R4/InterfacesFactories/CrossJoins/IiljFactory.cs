﻿namespace Britt2020.A.E.O.InterfacesFactories.CrossJoins
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;

    public interface IiljFactory
    {
        Iilj Create(
            ImmutableList<IiljCrossJoinElement> value);
    }
}
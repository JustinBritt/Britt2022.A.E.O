﻿namespace Britt2020.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints8
    {
        ImmutableList<IConstraints8ConstraintElement> Value { get; }
    }
}
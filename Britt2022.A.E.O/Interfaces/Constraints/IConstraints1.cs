﻿namespace Britt2022.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints1
    {
        ImmutableList<IConstraints1ConstraintElement> Value { get; }
    }
}
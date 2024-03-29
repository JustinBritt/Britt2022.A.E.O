﻿namespace Britt2022.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.Constraints;

    public interface IConstraints3Factory
    {
        IConstraints3 Create(
            ImmutableList<IConstraints3ConstraintElement> value);
    }
}
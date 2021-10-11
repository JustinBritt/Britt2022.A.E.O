﻿namespace Britt2020.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface IConstraints3ConstraintElementFactory
    {
        IConstraints3ConstraintElement Create(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            Ii i,
            Ix x);
    }
}
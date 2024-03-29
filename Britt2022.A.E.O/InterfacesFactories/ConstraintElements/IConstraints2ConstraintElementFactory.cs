﻿namespace Britt2022.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface IConstraints2ConstraintElementFactory
    {
        IConstraints2ConstraintElement Create(
            IjIndexElement jIndexElement,
            Iik ik,
            IΩ Ω,
            Ix x);
    }
}
﻿namespace Britt2022.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    public interface IΠFactory
    {
        IΠ Create(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>> value);
    }
}
﻿namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;
    
    public interface IIMinFactory
    {
        IIMin Create(
            RedBlackTree<IωIndexElement, IIMinResultElement> value);
    }
}
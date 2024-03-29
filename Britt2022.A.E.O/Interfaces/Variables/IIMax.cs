﻿namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;

    public interface IIMax
    {
        VariableCollection<IωIndexElement> Value { get; }

        decimal GetElementAt(
            IωIndexElement ωIndexElement);

        Interfaces.Results.ScenarioRecoveryWardCensuses.IIMax GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIMaxResultElementFactory IMaxResultElementFactory,
            IIMaxFactory IMaxFactory,
            Iω ω);
    }
}
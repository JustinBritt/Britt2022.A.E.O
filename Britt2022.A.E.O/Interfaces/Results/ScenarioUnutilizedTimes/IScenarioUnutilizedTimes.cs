﻿namespace Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioUnutilizedTimes
    {
        ImmutableList<IScenarioUnutilizedTimesResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement);

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
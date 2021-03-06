namespace Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IIMax
    {
        ImmutableList<IIMaxResultElement> Value { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}
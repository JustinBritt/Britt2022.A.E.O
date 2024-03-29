﻿namespace Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IHParameterElement
    {
        IiIndexElement iIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}
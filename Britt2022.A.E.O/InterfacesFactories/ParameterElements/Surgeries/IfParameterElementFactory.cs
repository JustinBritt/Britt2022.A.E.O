﻿namespace Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IfParameterElementFactory
    {
        IfParameterElement Create(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            INullableValue<decimal> value);
    }
}
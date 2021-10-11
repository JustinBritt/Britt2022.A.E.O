﻿namespace Britt2020.A.E.O.InterfacesFactories.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IAParameterElementFactory
    {
        IAParameterElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Duration value);
    }
}
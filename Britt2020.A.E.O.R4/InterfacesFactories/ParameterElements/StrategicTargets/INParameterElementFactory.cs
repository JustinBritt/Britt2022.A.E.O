﻿namespace Britt2020.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    public interface INParameterElementFactory
    {
        INParameterElement Create(
            IiIndexElement iIndexElement,
            PositiveInt value);
    }
}
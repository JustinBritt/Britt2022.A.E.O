﻿namespace Britt2020.A.E.O.InterfacesFactories.Parameters.GoalWeights
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.Parameters.GoalWeights;

    public interface Iw2Factory
    {
        Iw2 Create(
            FhirDecimal value);
    }
}
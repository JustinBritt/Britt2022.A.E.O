﻿namespace Britt2020.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;

    public interface Id1PlusFactory
    {
        Id1Plus Create(
            ImmutableList<Id1PlusResultElement> value);
    }
}
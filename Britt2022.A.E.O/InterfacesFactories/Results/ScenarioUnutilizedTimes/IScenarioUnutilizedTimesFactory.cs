﻿namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnutilizedTimes
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesFactory
    {
        IScenarioUnutilizedTimes Create(
            ImmutableList<IScenarioUnutilizedTimesResultElement> value);
    }
}
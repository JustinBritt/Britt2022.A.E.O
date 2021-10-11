﻿namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;

    public interface IIResultElementFactory
    {
        IIResultElement Create(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value);
    }
}
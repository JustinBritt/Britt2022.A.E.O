namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses
{
    using System.Collections.Immutable;
 
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;

    public interface IIMinFactory
    {
        IIMin Create(
            ImmutableList<IIMinResultElement> value);
    }
}
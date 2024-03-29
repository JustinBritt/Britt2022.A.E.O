﻿namespace Britt2022.A.E.O.Interfaces.Exports
{
    using System.Threading.Tasks;

    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.Interfaces.Configurations;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.Interfaces.SolverConfigurations;

    public interface IWGPMExport
    {
        Task<IWGPMOutputContext> Solve(
            IAbstractFactory abstractFactory,
            IWGPMConfiguration WGPMConfiguration,
            IWGPMInputContext WGPMInputContext,
            ISolverConfiguration solverConfiguration);
    }
}
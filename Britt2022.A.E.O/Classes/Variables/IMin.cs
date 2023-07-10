﻿namespace Britt2022.A.E.O.Classes.Variables
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.NGenerics.DataStructures.Trees;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;
    
    internal sealed class IMin : IIMin
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMin(
            VariableCollection<IωIndexElement> value)
        {
            this.Value = value;
        }

        public VariableCollection<IωIndexElement> Value { get; }

        public decimal GetElementAt(
            IωIndexElement ωIndexElement)
        {
            return (decimal)this.Value[ωIndexElement].Value;
        }
        public Interfaces.Results.ScenarioRecoveryWardCensuses.IIMin GetElementsAt(
            IRedBlackTreeFactory redBlackTreeFactory,
            IIMinResultElementFactory IMinResultElementFactory,
            IIMinFactory IMinFactory,
            Iω ω)
        {
            RedBlackTree<IωIndexElement, IIMinResultElement> redBlackTree = redBlackTreeFactory.Create<IωIndexElement, IIMinResultElement>();

            foreach (IωIndexElement ωIndexElement in ω.Value.Values)
            {
                redBlackTree.Add(
                    ωIndexElement,
                    IMinResultElementFactory.Create(
                        ωIndexElement,
                        this.GetElementAt(
                            ωIndexElement)));
            }

            return IMinFactory.Create(
                redBlackTree);
        }
    }
}
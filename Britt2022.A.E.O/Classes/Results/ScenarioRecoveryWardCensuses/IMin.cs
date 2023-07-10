﻿namespace Britt2022.A.E.O.Classes.Results.ScenarioRecoveryWardCensuses
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.ScenarioRecoveryWardCensuses;

    internal sealed class IMin : IIMin
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMin(
            RedBlackTree<IωIndexElement, IIMinResultElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IωIndexElement, IIMinResultElement> Value { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IIMinVisitor<IωIndexElement, IIMinResultElement> IMinVisitor = new Britt2022.A.E.O.Visitors.Results.ScenarioRecoveryWardCensuses.IMinVisitor<IωIndexElement, IIMinResultElement>(
                nullableValueFactory,
                new Britt2022.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees.RedBlackTreeFactory(),
                new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer());

            this.Value.AcceptVisitor(
                IMinVisitor);

            return IMinVisitor.RedBlackTree;
        }
    }
}
﻿namespace Britt2022.A.E.O.Classes.ParameterElements.ScenarioProbabilities
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    internal sealed class ΡParameterElement : IΡParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΡParameterElement(
            IωIndexElement ωIndexElement,
            INullableValue<decimal> value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IωIndexElement ωIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}
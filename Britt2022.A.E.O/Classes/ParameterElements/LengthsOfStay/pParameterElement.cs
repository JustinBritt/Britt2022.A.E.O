﻿namespace Britt2022.A.E.O.Classes.ParameterElements.LengthsOfStay
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    internal sealed class pParameterElement : IpParameterElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public pParameterElement(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement,
            INullableValue<decimal> value)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public IiIndexElement iIndexElement { get; }

        public IlIndexElement lIndexElement { get; }

        public IωIndexElement ωIndexElement { get; }

        public INullableValue<decimal> Value { get; }
    }
}
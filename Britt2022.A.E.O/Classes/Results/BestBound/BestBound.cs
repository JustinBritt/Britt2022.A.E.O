﻿namespace Britt2022.A.E.O.Classes.Results.BestBound
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Results.BestBound;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class BestBound : IBestBound
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BestBound(
            decimal value)
        {
            this.Value = value;
        }

        public decimal Value { get; }

        public INullableValue<decimal> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return nullableValueFactory.Create<decimal>(
                this.Value);
        }
    }
}
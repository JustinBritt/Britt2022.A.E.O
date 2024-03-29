﻿namespace Britt2022.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class iIndexElement : IiIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Organization Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IiIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}
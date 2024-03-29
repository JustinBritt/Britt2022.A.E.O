﻿namespace Britt2022.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            Location value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Location Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IjIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}
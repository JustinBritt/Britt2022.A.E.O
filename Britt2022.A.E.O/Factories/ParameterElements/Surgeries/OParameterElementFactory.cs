﻿namespace Britt2022.A.E.O.Factories.ParameterElements.Surgeries
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.Surgeries;

    internal sealed class OParameterElementFactory : IOParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public OParameterElementFactory()
        {
        }

        public IOParameterElement Create(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            INullableValue<decimal> value)
        {
            IOParameterElement instance = null;

            try
            {
                instance = new OParameterElement(
                    iIndexElement,
                    eIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}
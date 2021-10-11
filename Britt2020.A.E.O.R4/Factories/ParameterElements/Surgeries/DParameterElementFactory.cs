﻿namespace Britt2020.A.E.O.Factories.ParameterElements.Surgeries
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Classes.ParameterElements.Surgeries;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2020.A.E.O.InterfacesFactories.ParameterElements.Surgeries;

    internal sealed class DParameterElementFactory : IDParameterElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DParameterElementFactory()
        {
        }

        public IDParameterElement Create(
            IiIndexElement iIndexElement,
            IeIndexElement eIndexElement,
            IωIndexElement ωIndexElement,
            Duration value)
        {
            IDParameterElement parameterElement = null;

            try
            {
                parameterElement = new DParameterElement(
                    iIndexElement,
                    eIndexElement,
                    ωIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameterElement;
        }
    }
}
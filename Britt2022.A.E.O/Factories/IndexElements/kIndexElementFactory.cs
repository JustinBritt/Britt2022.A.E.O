﻿namespace Britt2022.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.IndexElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class kIndexElementFactory : IkIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElementFactory()
        {
        }

        public IkIndexElement Create(
            int key,
            FhirDateTime value)
        {
            IkIndexElement instance = null;

            try
            {
                instance = new kIndexElement(
                    key,
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
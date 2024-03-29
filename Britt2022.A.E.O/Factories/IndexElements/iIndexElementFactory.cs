﻿namespace Britt2022.A.E.O.Factories.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.IndexElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.IndexElements;

    internal sealed class iIndexElementFactory : IiIndexElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElementFactory()
        {
        }

        public IiIndexElement Create(
            Organization value)
        {
            IiIndexElement instance = null;

            try
            {
                instance = new iIndexElement(
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
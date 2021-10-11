﻿namespace Britt2020.A.E.O.Factories.Parameters.Surgeries
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Classes.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries;

    internal sealed class vFactory : IvFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public vFactory()
        {
        }

        public Iv Create(
            Duration value)
        {
            Iv parameter = null;

            try
            {
                parameter = new v(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
﻿namespace Britt2022.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization.Configuration
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization.Configuration;

    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization.Configuration;

    internal sealed class ConfigurationFactory : IConfigurationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ConfigurationFactory()
        {
        }

        public Configuration Create()
        {
            Configuration instance = null;

            try
            {
                instance = new Configuration();
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
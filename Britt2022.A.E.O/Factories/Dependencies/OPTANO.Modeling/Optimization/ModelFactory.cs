﻿namespace Britt2022.A.E.O.Factories.Dependencies.OPTANO.Modeling.Optimization
{
    using System;

    using log4net;

    using global::OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.InterfacesFactories.Dependencies.OPTANO.Modeling.Optimization;

    internal sealed class ModelFactory : IModelFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ModelFactory()
        {
        }

        public Model Create()
        {
            Model instance = null;

            try
            {
                instance = new Model();
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
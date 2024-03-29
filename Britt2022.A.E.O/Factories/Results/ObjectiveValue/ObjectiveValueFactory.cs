﻿namespace Britt2022.A.E.O.Factories.Results.ObjectiveValue
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.ObjectiveValue;
    using Britt2022.A.E.O.Interfaces.Results.ObjectiveValue;
    using Britt2022.A.E.O.InterfacesFactories.Results.ObjectiveValue;

    internal sealed class ObjectiveValueFactory : IObjectiveValueFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ObjectiveValueFactory()
        {
        }

        public IObjectiveValue Create(
            decimal value)
        {
            IObjectiveValue instance = null;

            try
            {
                instance = new ObjectiveValue(
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
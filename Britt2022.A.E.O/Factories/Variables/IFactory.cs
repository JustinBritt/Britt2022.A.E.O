﻿namespace Britt2022.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Classes.Variables;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.Variables;

    internal sealed class IFactory : IIFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IFactory()
        {
        }

        public II Create(
            VariableCollection<IkIndexElement, IωIndexElement> value)
        {
            II instance = null;

            try
            {
                instance = new I(
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
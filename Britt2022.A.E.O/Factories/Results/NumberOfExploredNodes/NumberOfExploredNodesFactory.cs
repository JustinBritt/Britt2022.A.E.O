﻿namespace Britt2022.A.E.O.Factories.Results.NumberOfExploredNodes
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.NumberOfExploredNodes;
    using Britt2022.A.E.O.Interfaces.Results.NumberOfExploredNodes;
    using Britt2022.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;

    internal sealed class NumberOfExploredNodesFactory : INumberOfExploredNodesFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public NumberOfExploredNodesFactory()
        {
        }

        public INumberOfExploredNodes Create(
            long value)
        {
            INumberOfExploredNodes instance = null;

            try
            {
                instance = new NumberOfExploredNodes(
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
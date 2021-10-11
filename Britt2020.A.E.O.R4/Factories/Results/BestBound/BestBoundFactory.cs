﻿namespace Britt2020.A.E.O.Factories.Results.BestBound
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.Results.BestBound;
    using Britt2020.A.E.O.Interfaces.Results.BestBound;
    using Britt2020.A.E.O.InterfacesFactories.Results.BestBound;

    internal sealed class BestBoundFactory : IBestBoundFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public BestBoundFactory()
        {
        }

        public IBestBound Create(
            decimal value)
        {
            IBestBound result = null;

            try
            {
                result = new BestBound(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}
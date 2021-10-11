﻿namespace Britt2020.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class iωCrossJoinElementFactory : IiωCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iωCrossJoinElementFactory()
        {
        }

        public IiωCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            IiωCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new iωCrossJoinElement(
                    iIndexElement,
                    ωIndexElement);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return crossJoinElement;
        }
    }
}
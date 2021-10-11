﻿namespace Britt2020.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2020.A.E.O.Classes.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.CrossJoinElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class iljCrossJoinElementFactory : IiljCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iljCrossJoinElementFactory()
        {
        }

        public IiljCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IjIndexElement jIndexElement)
        {
            IiljCrossJoinElement crossJoinElement = null;

            try
            {
                crossJoinElement = new iljCrossJoinElement(
                    iIndexElement,
                    lIndexElement,
                    jIndexElement);
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
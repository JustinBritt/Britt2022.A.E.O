﻿namespace Britt2022.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class ijCrossJoinElementFactory : IijCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijCrossJoinElementFactory()
        {
        }

        public IijCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            IijCrossJoinElement instance = null;

            try
            {
                instance = new ijCrossJoinElement(
                    iIndexElement,
                    jIndexElement);
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
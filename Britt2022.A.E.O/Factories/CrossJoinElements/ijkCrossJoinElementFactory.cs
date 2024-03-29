﻿namespace Britt2022.A.E.O.Factories.CrossJoinElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoinElements;

    internal sealed class ijkCrossJoinElementFactory : IijkCrossJoinElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ijkCrossJoinElementFactory()
        {
        }

        public IijkCrossJoinElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement)
        {
            IijkCrossJoinElement instance = null;

            try
            {
                instance = new ijkCrossJoinElement(
                    iIndexElement,
                    jIndexElement,
                    kIndexElement);
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
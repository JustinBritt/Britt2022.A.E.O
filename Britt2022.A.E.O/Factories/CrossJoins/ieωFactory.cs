﻿namespace Britt2022.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoins;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class ieωFactory : IieωFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ieωFactory()
        {
        }

        public Iieω Create(
            ImmutableList<IieωCrossJoinElement> value)
        {
            Iieω instance = null;

            try
            {
                instance = new ieω(
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
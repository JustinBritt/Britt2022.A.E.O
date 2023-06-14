﻿namespace Britt2022.A.E.O.Factories.CrossJoins
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.CrossJoins;
    using Britt2022.A.E.O.Interfaces.CrossJoinElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.InterfacesFactories.CrossJoins;

    internal sealed class ilFactory : IilFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ilFactory()
        {
        }

        public Iil Create(
            ImmutableList<IilCrossJoinElement> value)
        {
            Iil instance = null;

            try
            {
                instance = new il(
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
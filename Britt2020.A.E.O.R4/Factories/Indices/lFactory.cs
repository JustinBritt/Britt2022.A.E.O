﻿namespace Britt2020.A.E.O.Factories.Indices
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Indices;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.InterfacesFactories.Indices;

    internal sealed class lFactory : IlFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lFactory()
        {
        }

        public Il Create(
            ImmutableList<IlIndexElement> value)
        {
            Il index = null;

            try
            {
                index = new l(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return index;
        }
    }
}
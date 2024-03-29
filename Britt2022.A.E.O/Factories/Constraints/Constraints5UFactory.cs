﻿namespace Britt2022.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Constraints;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.Constraints;
    using Britt2022.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints5UFactory : IConstraints5UFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5UFactory()
        {
        }

        public IConstraints5U Create(
            ImmutableList<IConstraints5UConstraintElement> value)
        {
            IConstraints5U instance = null;

            try
            {
                instance = new Constraints5U(
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
﻿namespace Britt2022.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Constraints;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.Constraints;
    using Britt2022.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints1Factory : IConstraints1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1Factory()
        {
        }

        public IConstraints1 Create(
            ImmutableList<IConstraints1ConstraintElement> value)
        {
            IConstraints1 instance = null;

            try
            {
                instance = new Constraints1(
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
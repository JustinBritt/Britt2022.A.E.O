﻿namespace Britt2022.A.E.O.Factories.Constraints
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Constraints;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.Constraints;
    using Britt2022.A.E.O.InterfacesFactories.Constraints;

    internal sealed class Constraints8Factory : IConstraints8Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints8Factory()
        {
        }

        public IConstraints8 Create(
            ImmutableList<IConstraints8ConstraintElement> value)
        {
            IConstraints8 instance = null;

            try
            {
                instance = new Constraints8(
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
﻿namespace Britt2022.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints1ConstraintElementFactory : IConstraints1ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElementFactory()
        {
        }

        public IConstraints1ConstraintElement Create(
            IkIndexElement kIndexElement,
            Iij ij,
            IΠ Π,
            Ix x)
        {
            IConstraints1ConstraintElement instance = null;

            try
            {
                instance = new Constraints1ConstraintElement(
                    kIndexElement,
                    ij,
                    Π,
                    x);
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
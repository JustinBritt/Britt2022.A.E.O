﻿namespace Britt2022.A.E.O.Factories.ConstraintElements
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Variables;
    using Britt2022.A.E.O.InterfacesFactories.ConstraintElements;

    internal sealed class Constraints7ConstraintElementFactory : IConstraints7ConstraintElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints7ConstraintElementFactory()
        {
        }

        public IConstraints7ConstraintElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            IA A,
            In n,
            Iv v,
            Id2Minus d2Minus,
            Ix x)
        {
            IConstraints7ConstraintElement instance = null;

            try
            {
                instance = new Constraints7ConstraintElement(
                    iIndexElement,
                    jIndexElement,
                    kIndexElement,
                    ωIndexElement,
                    A,
                    n,
                    v,
                    d2Minus,
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
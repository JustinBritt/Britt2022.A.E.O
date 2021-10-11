﻿namespace Britt2020.A.E.O.Factories.Variables
{
    using System;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Classes.Variables;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Variables;
    using Britt2020.A.E.O.InterfacesFactories.Variables;

    internal sealed class d2MinusFactory : Id2MinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2MinusFactory()
        {
        }

        public Id2Minus Create(
            VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> value)
        {
            Id2Minus variable = null;

            try
            {
                variable = new d2Minus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return variable;
        }
    }
}
namespace Britt2022.A.E.O.Factories.Parameters.LengthsOfStay
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.LengthsOfStay;

    internal sealed class ΦFactory : IΦFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ΦFactory()
        {
        }

        public IΦ Create(
            ImmutableList<IΦParameterElement> value)
        {
            IΦ parameter = null;

            try
            {
                parameter = new Φ(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}
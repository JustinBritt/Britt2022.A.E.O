namespace Britt2022.A.E.O.Factories.Parameters.Surgeries
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.Surgeries;

    internal sealed class AFactory : IAFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AFactory()
        {
        }

        public IA Create(
            ImmutableList<IAParameterElement> value)
        {
            IA parameter = null;

            try
            {
                parameter = new A(
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
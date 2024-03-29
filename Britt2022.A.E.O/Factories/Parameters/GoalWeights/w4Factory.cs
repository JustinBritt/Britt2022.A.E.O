﻿namespace Britt2022.A.E.O.Factories.Parameters.GoalWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.GoalWeights;

    internal sealed class w4Factory : Iw4Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w4Factory()
        {
        }

        public Iw4 Create(
            INullableValue<decimal> value)
        {
            Iw4 instance = null;

            try
            {
                instance = new w4(
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
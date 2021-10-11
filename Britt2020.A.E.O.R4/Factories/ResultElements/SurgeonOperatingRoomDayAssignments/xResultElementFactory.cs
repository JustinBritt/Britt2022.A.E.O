﻿namespace Britt2020.A.E.O.Factories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using System;
  
    using log4net;

    using Britt2020.A.E.O.Classes.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public xResultElementFactory()
        {
        }

        public IxResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            bool value)
        {
            IxResultElement resultElement = null;

            try
            {
                resultElement = new xResultElement(
                    iIndexElement,
                    jIndexElement,
                    kIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}
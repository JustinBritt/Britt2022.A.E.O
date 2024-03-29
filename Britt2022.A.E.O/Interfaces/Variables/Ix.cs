﻿namespace Britt2022.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    public interface Ix
    {
        VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> Value { get; }

        bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Ii i,
            Ij j,
            Ik k);
    }
}
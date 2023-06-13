﻿namespace Britt2022.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IWGPMInputContext
    {
        ImmutableSortedSet<INullableValue<int>> Clusters { get; }

        Bundle Surgeons { get; }

        Bundle OperatingRooms { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumLengthsOfStay { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMinimumNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonStrategicTargetNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        Duration TimeBlockLength { get; }

        INullableValue<decimal> GoalWeight1 { get; }

        INullableValue<decimal> GoalWeight2 { get; }

        INullableValue<decimal> GoalWeight3 { get; }

        INullableValue<decimal> GoalWeight4 { get; }

        RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> SurgeonOperatingRoomAvailabilities { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAvailabilities { get; }
    }
}
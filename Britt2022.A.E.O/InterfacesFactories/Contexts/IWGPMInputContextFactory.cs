namespace Britt2022.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Contexts;

    public interface IWGPMInputContextFactory
    {
        IWGPMInputContext Create(
            ImmutableList<PositiveInt> clusters,
            Bundle surgeons,
            Bundle operatingRooms,
            ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> planningHorizon,
            ImmutableList<PositiveInt> lengthOfStayDays,
            ImmutableList<Tuple<Organization, ImmutableList<Organization>>> surgicalSpecialties,
            ImmutableList<PositiveInt> scenarios,
            ImmutableList<Tuple<Organization, PositiveInt, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgicalSpecialtyStrategicTargetNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumLengthsOfStay,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMinimumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonStrategicTargetNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioLengthOfStayProbabilities,
            Duration timeBlockLength,
            FhirDecimal goalWeight1,
            FhirDecimal goalWeight2,
            FhirDecimal goalWeight3,
            FhirDecimal goalWeight4,
            ImmutableList<Tuple<Organization, Location, FhirBoolean>> surgeonOperatingRoomAvailabilities,
            ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioCumulativeNumberPatients,
            ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> surgeonDayAvailabilities);
    }
}
namespace Britt2022.A.E.O.Factories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.Contexts;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.InterfacesFactories.Contexts;

    internal sealed class WGPMInputContextFactory : IWGPMInputContextFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMInputContextFactory()
        {
        }

        public IWGPMInputContext Create(
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
            ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> surgeonDayAvailabilities)
        {
            IWGPMInputContext context = null;

            try
            {
                context = new WGPMInputContext(
                    clusters,
                    surgeons,
                    operatingRooms,
                    planningHorizon,
                    lengthOfStayDays,
                    surgicalSpecialties,
                    scenarios,
                    surgeonScenarioWeightedAverageSurgicalDurations,
                    surgicalSpecialtyStrategicTargetNumberTimeBlocks,
                    surgeonMaximumNumberTimeBlocks,
                    surgeonMaximumLengthsOfStay,
                    surgeonMinimumNumberTimeBlocks,
                    surgeonStrategicTargetNumberPatients,
                    surgeonScenarioMaximumNumberPatients,
                    surgeonDayScenarioLengthOfStayProbabilities,
                    timeBlockLength,
                    goalWeight1,
                    goalWeight2,
                    goalWeight3,
                    goalWeight4,
                    surgeonOperatingRoomAvailabilities,
                    scenarioProbabilities,
                    surgeonDayScenarioCumulativeNumberPatients,
                    surgeonDayAvailabilities);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return context;
        }
    }
}
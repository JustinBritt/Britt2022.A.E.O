namespace Britt2022.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Contexts;

    public sealed class WGPMInputContext : IWGPMInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMInputContext(
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
            // e
            this.Clusters = clusters;

            // i
            this.Surgeons = surgeons;

            // j
            this.OperatingRooms = operatingRooms;

            // k
            this.PlanningHorizon = planningHorizon;

            // l
            this.LengthOfStayDays = lengthOfStayDays;

            // r
            this.SurgicalSpecialties = surgicalSpecialties;

            // ω
            this.Scenarios = scenarios;

            // A(i, ω)
            if (surgeonScenarioWeightedAverageSurgicalDurations != null)
            {
                this.SurgeonScenarioWeightedAverageSurgicalDurations = surgeonScenarioWeightedAverageSurgicalDurations;
            }    
            
            // B(r)
            this.SurgicalSpecialtyStrategicTargetNumberTimeBlocks = surgicalSpecialtyStrategicTargetNumberTimeBlocks;

            // H(i)
            this.SurgeonMaximumNumberTimeBlocks = surgeonMaximumNumberTimeBlocks;

            // h(i)
            this.SurgeonMaximumLengthsOfStay = surgeonMaximumLengthsOfStay;

            // L(i)
            this.SurgeonMinimumNumberTimeBlocks = surgeonMinimumNumberTimeBlocks;

            // N(i)
            this.SurgeonStrategicTargetNumberPatients = surgeonStrategicTargetNumberPatients;

            // n(i, ω)
            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            // p(i, l, ω)
            if (surgeonDayScenarioLengthOfStayProbabilities != null)
            {
                this.SurgeonDayScenarioLengthOfStayProbabilities = surgeonDayScenarioLengthOfStayProbabilities;
            }

            // v
            this.TimeBlockLength = timeBlockLength;

            // w1
            this.GoalWeight1 = goalWeight1;

            // w2
            this.GoalWeight2 = goalWeight2;
            
            // w3
            this.GoalWeight3 = goalWeight3;

            // w4
            this.GoalWeight4 = goalWeight4;

            this.SurgeonOperatingRoomAvailabilities = surgeonOperatingRoomAvailabilities;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.SurgeonDayScenarioCumulativeNumberPatients = surgeonDayScenarioCumulativeNumberPatients;

            this.SurgeonDayAvailabilities = surgeonDayAvailabilities;
        }

        /// <summary>
        /// Gets the clusters.
        /// Parameter: e
        /// </summary>
        public ImmutableList<PositiveInt> Clusters { get; }

        /// <summary>
        /// Gets the surgeons.
        /// Parameter: i
        /// </summary>
        public Bundle Surgeons { get; }

        /// <summary>
        /// Gets the operating rooms.
        /// Parameter: j
        /// </summary>
        public Bundle OperatingRooms { get; }

        public ImmutableList<KeyValuePair<PositiveInt, FhirDateTime>> PlanningHorizon { get; }

        /// <summary>
        /// Gets the length of stay days.
        /// Parameter: l
        /// </summary>
        public ImmutableList<PositiveInt> LengthOfStayDays { get; }

        /// <summary>
        /// Gets the surgical specialties
        /// Parameter: r
        /// </summary>
        public ImmutableList<Tuple<Organization, ImmutableList<Organization>>> SurgicalSpecialties { get; }

        /// <summary>
        /// Gets the scenarios
        /// Parameter: ω
        /// </summary>
        public ImmutableList<PositiveInt> Scenarios { get; }

        /// <summary>
        /// 
        /// Parameter: A
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        /// <summary>
        /// 
        /// Parameter: B
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: H
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: h
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumLengthsOfStay { get; }

        /// <summary>
        /// 
        /// Parameter: L
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMinimumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: N
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonStrategicTargetNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: n
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonScenarioMaximumNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: p
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        /// <summary>
        /// Gets the time block length.
        /// Parameter: v
        /// </summary>
        public Duration TimeBlockLength { get; }

        /// <summary>
        /// 
        /// Parameter: w1
        /// </summary>
        public FhirDecimal GoalWeight1 { get; }

        /// <summary>
        /// 
        /// Parameter: w2
        /// </summary>
        public FhirDecimal GoalWeight2 { get; }

        /// <summary>
        /// 
        /// Parameter: w3
        /// </summary>
        public FhirDecimal GoalWeight3 { get; }

        /// <summary>
        /// 
        /// Parameter: w4
        /// </summary>
        public FhirDecimal GoalWeight4 { get; }

        /// <summary>
        /// 
        /// Parameter: Π
        /// </summary>
        public ImmutableList<Tuple<Organization, Location, FhirBoolean>> SurgeonOperatingRoomAvailabilities { get; }

        /// <summary>
        /// 
        /// Parameter: Ρ
        /// </summary>
        public ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> ScenarioProbabilities { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: Ω
        /// </summary>
        public ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> SurgeonDayAvailabilities { get; }
    }
}
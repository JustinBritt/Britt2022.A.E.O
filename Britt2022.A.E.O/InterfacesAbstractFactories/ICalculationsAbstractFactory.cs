﻿namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;

    public interface ICalculationsAbstractFactory
    {
        IScenarioNumberPatientsCalculationFactory CreateScenarioNumberPatientsCalculationFactory();

        IScenarioNumberPatientsResultElementCalculationFactory CreateScenarioNumberPatientsResultElementCalculationFactory();

        IScenarioTotalTimesCalculationFactory CreateScenarioTotalTimesCalculationFactory();

        IScenarioTotalTimesResultElementCalculationFactory CreateScenarioTotalTimesResultElementCalculationFactory();

        IScenarioUnderutilizationsCalculationFactory CreateScenarioUnderutilizationsCalculationFactory();

        IScenarioUnderutilizationsResultElementCalculationFactory CreateScenarioUnderutilizationsResultElementCalculationFactory();

        IScenarioUnutilizedTimesCalculationFactory CreateScenarioUnutilizedTimesCalculationFactory();

        IScenarioUnutilizedTimesResultElementCalculationFactory CreateScenarioUnutilizedTimesResultElementCalculationFactory();

        IScenarioUtilizedTimesCalculationFactory CreateScenarioUtilizedTimesCalculationFactory();

        IScenarioUtilizedTimesResultElementCalculationFactory CreateScenarioUtilizedTimesResultElementCalculationFactory();

        ISurgeonScenarioNumberPatientsCalculationFactory CreateSurgeonScenarioNumberPatientsCalculationFactory();

        ISurgeonScenarioNumberPatientsResultElementCalculationFactory CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory();
    }
}
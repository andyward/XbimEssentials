// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.UtilityResource
{
	public partial class @IfcTableRow : IIfcTableRow
	{
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcValue> IIfcTableRow.RowCells 
		{ 
			get
			{
			foreach (var member in RowCells)
			{
				if (member is MeasureResource.IfcVolumeMeasure) 
					yield return new Ifc4.MeasureResource.IfcVolumeMeasure((double)(MeasureResource.IfcVolumeMeasure)member);
				if (member is MeasureResource.IfcTimeMeasure) 
					yield return new Ifc4.MeasureResource.IfcTimeMeasure((double)(MeasureResource.IfcTimeMeasure)member);
				if (member is MeasureResource.IfcThermodynamicTemperatureMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure((double)(MeasureResource.IfcThermodynamicTemperatureMeasure)member);
				if (member is MeasureResource.IfcSolidAngleMeasure) 
					yield return new Ifc4.MeasureResource.IfcSolidAngleMeasure((double)(MeasureResource.IfcSolidAngleMeasure)member);
				if (member is MeasureResource.IfcPositiveRatioMeasure) 
					yield return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(MeasureResource.IfcPositiveRatioMeasure)member);
				if (member is MeasureResource.IfcRatioMeasure) 
					yield return new Ifc4.MeasureResource.IfcRatioMeasure((double)(MeasureResource.IfcRatioMeasure)member);
				if (member is MeasureResource.IfcPositivePlaneAngleMeasure) 
					yield return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)(MeasureResource.IfcPositivePlaneAngleMeasure)member);
				if (member is MeasureResource.IfcPlaneAngleMeasure) 
					yield return new Ifc4.MeasureResource.IfcPlaneAngleMeasure((double)(MeasureResource.IfcPlaneAngleMeasure)member);
				if (member is MeasureResource.IfcParameterValue) 
					yield return new Ifc4.MeasureResource.IfcParameterValue((double)(MeasureResource.IfcParameterValue)member);
				if (member is MeasureResource.IfcNumericMeasure) 
					yield return new Ifc4.MeasureResource.IfcNumericMeasure((double)(MeasureResource.IfcNumericMeasure)member);
				if (member is MeasureResource.IfcMassMeasure) 
					yield return new Ifc4.MeasureResource.IfcMassMeasure((double)(MeasureResource.IfcMassMeasure)member);
				if (member is MeasureResource.IfcPositiveLengthMeasure) 
					yield return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(MeasureResource.IfcPositiveLengthMeasure)member);
				if (member is MeasureResource.IfcLengthMeasure) 
					yield return new Ifc4.MeasureResource.IfcLengthMeasure((double)(MeasureResource.IfcLengthMeasure)member);
				if (member is MeasureResource.IfcElectricCurrentMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricCurrentMeasure((double)(MeasureResource.IfcElectricCurrentMeasure)member);
				if (member is MeasureResource.IfcDescriptiveMeasure) 
					yield return new Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(MeasureResource.IfcDescriptiveMeasure)member);
				if (member is MeasureResource.IfcCountMeasure) 
					yield return new Ifc4.MeasureResource.IfcCountMeasure((double)(MeasureResource.IfcCountMeasure)member);
				if (member is MeasureResource.IfcContextDependentMeasure) 
					yield return new Ifc4.MeasureResource.IfcContextDependentMeasure((double)(MeasureResource.IfcContextDependentMeasure)member);
				if (member is MeasureResource.IfcAreaMeasure) 
					yield return new Ifc4.MeasureResource.IfcAreaMeasure((double)(MeasureResource.IfcAreaMeasure)member);
				if (member is MeasureResource.IfcAmountOfSubstanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure((double)(MeasureResource.IfcAmountOfSubstanceMeasure)member);
				if (member is MeasureResource.IfcLuminousIntensityMeasure) 
					yield return new Ifc4.MeasureResource.IfcLuminousIntensityMeasure((double)(MeasureResource.IfcLuminousIntensityMeasure)member);
				if (member is MeasureResource.IfcNormalisedRatioMeasure) 
					yield return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(MeasureResource.IfcNormalisedRatioMeasure)member);
				if (member is MeasureResource.IfcComplexNumber) 
					yield return new Ifc4.MeasureResource.IfcComplexNumber((List<double>)(MeasureResource.IfcComplexNumber)member);
				if (member is MeasureResource.IfcInteger) 
					yield return new Ifc4.MeasureResource.IfcInteger((long)(MeasureResource.IfcInteger)member);
				if (member is MeasureResource.IfcReal) 
					yield return new Ifc4.MeasureResource.IfcReal((double)(MeasureResource.IfcReal)member);
				if (member is MeasureResource.IfcBoolean) 
					yield return new Ifc4.MeasureResource.IfcBoolean((bool)(MeasureResource.IfcBoolean)member);
				if (member is MeasureResource.IfcIdentifier) 
					yield return new Ifc4.MeasureResource.IfcIdentifier((string)(MeasureResource.IfcIdentifier)member);
				if (member is MeasureResource.IfcText) 
					yield return new Ifc4.MeasureResource.IfcText((string)(MeasureResource.IfcText)member);
				if (member is MeasureResource.IfcLabel) 
					yield return new Ifc4.MeasureResource.IfcLabel((string)(MeasureResource.IfcLabel)member);
				if (member is MeasureResource.IfcLogical) 
					yield return new Ifc4.MeasureResource.IfcLogical((bool?)(MeasureResource.IfcLogical)member);
				if (member is MeasureResource.IfcVolumetricFlowRateMeasure) 
					yield return new Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure((double)(MeasureResource.IfcVolumetricFlowRateMeasure)member);
				if (member is MeasureResource.IfcTimeStamp) 
					yield return new Ifc4.DateTimeResource.IfcTimeStamp((long)(MeasureResource.IfcTimeStamp)member);
				if (member is MeasureResource.IfcThermalTransmittanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermalTransmittanceMeasure((double)(MeasureResource.IfcThermalTransmittanceMeasure)member);
				if (member is MeasureResource.IfcThermalResistanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermalResistanceMeasure((double)(MeasureResource.IfcThermalResistanceMeasure)member);
				if (member is MeasureResource.IfcThermalAdmittanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermalAdmittanceMeasure((double)(MeasureResource.IfcThermalAdmittanceMeasure)member);
				if (member is MeasureResource.IfcPressureMeasure) 
					yield return new Ifc4.MeasureResource.IfcPressureMeasure((double)(MeasureResource.IfcPressureMeasure)member);
				if (member is MeasureResource.IfcPowerMeasure) 
					yield return new Ifc4.MeasureResource.IfcPowerMeasure((double)(MeasureResource.IfcPowerMeasure)member);
				if (member is MeasureResource.IfcMassFlowRateMeasure) 
					yield return new Ifc4.MeasureResource.IfcMassFlowRateMeasure((double)(MeasureResource.IfcMassFlowRateMeasure)member);
				if (member is MeasureResource.IfcMassDensityMeasure) 
					yield return new Ifc4.MeasureResource.IfcMassDensityMeasure((double)(MeasureResource.IfcMassDensityMeasure)member);
				if (member is MeasureResource.IfcLinearVelocityMeasure) 
					yield return new Ifc4.MeasureResource.IfcLinearVelocityMeasure((double)(MeasureResource.IfcLinearVelocityMeasure)member);
				if (member is MeasureResource.IfcKinematicViscosityMeasure) 
					yield return new Ifc4.MeasureResource.IfcKinematicViscosityMeasure((double)(MeasureResource.IfcKinematicViscosityMeasure)member);
				if (member is MeasureResource.IfcIntegerCountRateMeasure) 
					yield return new Ifc4.MeasureResource.IfcIntegerCountRateMeasure((long)(MeasureResource.IfcIntegerCountRateMeasure)member);
				if (member is MeasureResource.IfcHeatFluxDensityMeasure) 
					yield return new Ifc4.MeasureResource.IfcHeatFluxDensityMeasure((double)(MeasureResource.IfcHeatFluxDensityMeasure)member);
				if (member is MeasureResource.IfcFrequencyMeasure) 
					yield return new Ifc4.MeasureResource.IfcFrequencyMeasure((double)(MeasureResource.IfcFrequencyMeasure)member);
				if (member is MeasureResource.IfcEnergyMeasure) 
					yield return new Ifc4.MeasureResource.IfcEnergyMeasure((double)(MeasureResource.IfcEnergyMeasure)member);
				if (member is MeasureResource.IfcElectricVoltageMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricVoltageMeasure((double)(MeasureResource.IfcElectricVoltageMeasure)member);
				if (member is MeasureResource.IfcDynamicViscosityMeasure) 
					yield return new Ifc4.MeasureResource.IfcDynamicViscosityMeasure((double)(MeasureResource.IfcDynamicViscosityMeasure)member);
				if (member is MeasureResource.IfcCompoundPlaneAngleMeasure) 
					yield return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure((List<long>)(MeasureResource.IfcCompoundPlaneAngleMeasure)member);
				if (member is MeasureResource.IfcAngularVelocityMeasure) 
					yield return new Ifc4.MeasureResource.IfcAngularVelocityMeasure((double)(MeasureResource.IfcAngularVelocityMeasure)member);
				if (member is MeasureResource.IfcThermalConductivityMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermalConductivityMeasure((double)(MeasureResource.IfcThermalConductivityMeasure)member);
				if (member is MeasureResource.IfcMolecularWeightMeasure) 
					yield return new Ifc4.MeasureResource.IfcMolecularWeightMeasure((double)(MeasureResource.IfcMolecularWeightMeasure)member);
				if (member is MeasureResource.IfcVaporPermeabilityMeasure) 
					yield return new Ifc4.MeasureResource.IfcVaporPermeabilityMeasure((double)(MeasureResource.IfcVaporPermeabilityMeasure)member);
				if (member is MeasureResource.IfcMoistureDiffusivityMeasure) 
					yield return new Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure((double)(MeasureResource.IfcMoistureDiffusivityMeasure)member);
				if (member is MeasureResource.IfcIsothermalMoistureCapacityMeasure) 
					yield return new Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure((double)(MeasureResource.IfcIsothermalMoistureCapacityMeasure)member);
				if (member is MeasureResource.IfcSpecificHeatCapacityMeasure) 
					yield return new Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure((double)(MeasureResource.IfcSpecificHeatCapacityMeasure)member);
				if (member is MeasureResource.IfcMonetaryMeasure) 
					yield return new Ifc4.MeasureResource.IfcMonetaryMeasure((double)(MeasureResource.IfcMonetaryMeasure)member);
				if (member is MeasureResource.IfcMagneticFluxDensityMeasure) 
					yield return new Ifc4.MeasureResource.IfcMagneticFluxDensityMeasure((double)(MeasureResource.IfcMagneticFluxDensityMeasure)member);
				if (member is MeasureResource.IfcMagneticFluxMeasure) 
					yield return new Ifc4.MeasureResource.IfcMagneticFluxMeasure((double)(MeasureResource.IfcMagneticFluxMeasure)member);
				if (member is MeasureResource.IfcLuminousFluxMeasure) 
					yield return new Ifc4.MeasureResource.IfcLuminousFluxMeasure((double)(MeasureResource.IfcLuminousFluxMeasure)member);
				if (member is MeasureResource.IfcForceMeasure) 
					yield return new Ifc4.MeasureResource.IfcForceMeasure((double)(MeasureResource.IfcForceMeasure)member);
				if (member is MeasureResource.IfcInductanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcInductanceMeasure((double)(MeasureResource.IfcInductanceMeasure)member);
				if (member is MeasureResource.IfcIlluminanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcIlluminanceMeasure((double)(MeasureResource.IfcIlluminanceMeasure)member);
				if (member is MeasureResource.IfcElectricResistanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricResistanceMeasure((double)(MeasureResource.IfcElectricResistanceMeasure)member);
				if (member is MeasureResource.IfcElectricConductanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricConductanceMeasure((double)(MeasureResource.IfcElectricConductanceMeasure)member);
				if (member is MeasureResource.IfcElectricChargeMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricChargeMeasure((double)(MeasureResource.IfcElectricChargeMeasure)member);
				if (member is MeasureResource.IfcDoseEquivalentMeasure) 
					yield return new Ifc4.MeasureResource.IfcDoseEquivalentMeasure((double)(MeasureResource.IfcDoseEquivalentMeasure)member);
				if (member is MeasureResource.IfcElectricCapacitanceMeasure) 
					yield return new Ifc4.MeasureResource.IfcElectricCapacitanceMeasure((double)(MeasureResource.IfcElectricCapacitanceMeasure)member);
				if (member is MeasureResource.IfcAbsorbedDoseMeasure) 
					yield return new Ifc4.MeasureResource.IfcAbsorbedDoseMeasure((double)(MeasureResource.IfcAbsorbedDoseMeasure)member);
				if (member is MeasureResource.IfcRadioActivityMeasure) 
					yield return new Ifc4.MeasureResource.IfcRadioActivityMeasure((double)(MeasureResource.IfcRadioActivityMeasure)member);
				if (member is MeasureResource.IfcRotationalFrequencyMeasure) 
					yield return new Ifc4.MeasureResource.IfcRotationalFrequencyMeasure((double)(MeasureResource.IfcRotationalFrequencyMeasure)member);
				if (member is MeasureResource.IfcTorqueMeasure) 
					yield return new Ifc4.MeasureResource.IfcTorqueMeasure((double)(MeasureResource.IfcTorqueMeasure)member);
				if (member is MeasureResource.IfcAccelerationMeasure) 
					yield return new Ifc4.MeasureResource.IfcAccelerationMeasure((double)(MeasureResource.IfcAccelerationMeasure)member);
				if (member is MeasureResource.IfcLinearForceMeasure) 
					yield return new Ifc4.MeasureResource.IfcLinearForceMeasure((double)(MeasureResource.IfcLinearForceMeasure)member);
				if (member is MeasureResource.IfcLinearStiffnessMeasure) 
					yield return new Ifc4.MeasureResource.IfcLinearStiffnessMeasure((double)(MeasureResource.IfcLinearStiffnessMeasure)member);
				if (member is MeasureResource.IfcModulusOfSubgradeReactionMeasure) 
					yield return new Ifc4.MeasureResource.IfcModulusOfSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfSubgradeReactionMeasure)member);
				if (member is MeasureResource.IfcModulusOfElasticityMeasure) 
					yield return new Ifc4.MeasureResource.IfcModulusOfElasticityMeasure((double)(MeasureResource.IfcModulusOfElasticityMeasure)member);
				if (member is MeasureResource.IfcMomentOfInertiaMeasure) 
					yield return new Ifc4.MeasureResource.IfcMomentOfInertiaMeasure((double)(MeasureResource.IfcMomentOfInertiaMeasure)member);
				if (member is MeasureResource.IfcPlanarForceMeasure) 
					yield return new Ifc4.MeasureResource.IfcPlanarForceMeasure((double)(MeasureResource.IfcPlanarForceMeasure)member);
				if (member is MeasureResource.IfcRotationalStiffnessMeasure) 
					yield return new Ifc4.MeasureResource.IfcRotationalStiffnessMeasure((double)(MeasureResource.IfcRotationalStiffnessMeasure)member);
				if (member is MeasureResource.IfcShearModulusMeasure) 
					yield return new Ifc4.MeasureResource.IfcShearModulusMeasure((double)(MeasureResource.IfcShearModulusMeasure)member);
				if (member is MeasureResource.IfcLinearMomentMeasure) 
					yield return new Ifc4.MeasureResource.IfcLinearMomentMeasure((double)(MeasureResource.IfcLinearMomentMeasure)member);
				if (member is MeasureResource.IfcLuminousIntensityDistributionMeasure) 
					yield return new Ifc4.MeasureResource.IfcLuminousIntensityDistributionMeasure((double)(MeasureResource.IfcLuminousIntensityDistributionMeasure)member);
				if (member is MeasureResource.IfcCurvatureMeasure) 
					yield return new Ifc4.MeasureResource.IfcCurvatureMeasure((double)(MeasureResource.IfcCurvatureMeasure)member);
				if (member is MeasureResource.IfcMassPerLengthMeasure) 
					yield return new Ifc4.MeasureResource.IfcMassPerLengthMeasure((double)(MeasureResource.IfcMassPerLengthMeasure)member);
				if (member is MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure) 
					yield return new Ifc4.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)member);
				if (member is MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure) 
					yield return new Ifc4.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((double)(MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)member);
				if (member is MeasureResource.IfcRotationalMassMeasure) 
					yield return new Ifc4.MeasureResource.IfcRotationalMassMeasure((double)(MeasureResource.IfcRotationalMassMeasure)member);
				if (member is MeasureResource.IfcSectionalAreaIntegralMeasure) 
					yield return new Ifc4.MeasureResource.IfcSectionalAreaIntegralMeasure((double)(MeasureResource.IfcSectionalAreaIntegralMeasure)member);
				if (member is MeasureResource.IfcSectionModulusMeasure) 
					yield return new Ifc4.MeasureResource.IfcSectionModulusMeasure((double)(MeasureResource.IfcSectionModulusMeasure)member);
				if (member is MeasureResource.IfcTemperatureGradientMeasure) 
					yield return new Ifc4.MeasureResource.IfcTemperatureGradientMeasure((double)(MeasureResource.IfcTemperatureGradientMeasure)member);
				if (member is MeasureResource.IfcThermalExpansionCoefficientMeasure) 
					yield return new Ifc4.MeasureResource.IfcThermalExpansionCoefficientMeasure((double)(MeasureResource.IfcThermalExpansionCoefficientMeasure)member);
				if (member is MeasureResource.IfcWarpingConstantMeasure) 
					yield return new Ifc4.MeasureResource.IfcWarpingConstantMeasure((double)(MeasureResource.IfcWarpingConstantMeasure)member);
				if (member is MeasureResource.IfcWarpingMomentMeasure) 
					yield return new Ifc4.MeasureResource.IfcWarpingMomentMeasure((double)(MeasureResource.IfcWarpingMomentMeasure)member);
				if (member is MeasureResource.IfcSoundPowerMeasure) 
					yield return new Ifc4.MeasureResource.IfcSoundPowerMeasure((double)(MeasureResource.IfcSoundPowerMeasure)member);
				if (member is MeasureResource.IfcSoundPressureMeasure) 
					yield return new Ifc4.MeasureResource.IfcSoundPressureMeasure((double)(MeasureResource.IfcSoundPressureMeasure)member);
				if (member is MeasureResource.IfcHeatingValueMeasure) 
					yield return new Ifc4.MeasureResource.IfcHeatingValueMeasure((double)(MeasureResource.IfcHeatingValueMeasure)member);
				if (member is MeasureResource.IfcPHMeasure) 
					yield return new Ifc4.MeasureResource.IfcPHMeasure((double)(MeasureResource.IfcPHMeasure)member);
				if (member is MeasureResource.IfcIonConcentrationMeasure) 
					yield return new Ifc4.MeasureResource.IfcIonConcentrationMeasure((double)(MeasureResource.IfcIonConcentrationMeasure)member);
			}
			} 
		}
		bool? IIfcTableRow.IsHeading 
		{ 
			get
			{
				return IsHeading;
			} 
		}
		IIfcTable IIfcTableRow.OfTable 
		{ 
			get
			{
				return Model.Instances.FirstOrDefault<IIfcTable>(e => e.Rows != null &&  e.Rows.Contains(this));
			} 
		}

	//## Custom code
	//##
	}
}
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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcLightIntensityDistribution : IIfcLightIntensityDistribution
	{
		Ifc4.PresentationOrganizationResource.IfcLightDistributionCurveEnum IIfcLightIntensityDistribution.LightDistributionCurve 
		{ 
			get
			{
				switch (LightDistributionCurve)
				{
					case IfcLightDistributionCurveEnum.TYPE_A:
						return Ifc4.PresentationOrganizationResource.IfcLightDistributionCurveEnum.TYPE_A;
					
					case IfcLightDistributionCurveEnum.TYPE_B:
						return Ifc4.PresentationOrganizationResource.IfcLightDistributionCurveEnum.TYPE_B;
					
					case IfcLightDistributionCurveEnum.TYPE_C:
						return Ifc4.PresentationOrganizationResource.IfcLightDistributionCurveEnum.TYPE_C;
					
					case IfcLightDistributionCurveEnum.NOTDEFINED:
						return Ifc4.PresentationOrganizationResource.IfcLightDistributionCurveEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		IEnumerable<IIfcLightDistributionData> IIfcLightIntensityDistribution.DistributionData 
		{ 
			get
			{
			foreach (var member in DistributionData)
			{
				yield return member as IIfcLightDistributionData;
			}
			} 
		}

	//## Custom code
	//##
	}
}
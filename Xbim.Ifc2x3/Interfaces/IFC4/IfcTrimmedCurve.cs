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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcTrimmedCurve : IIfcTrimmedCurve
	{
		IIfcCurve IIfcTrimmedCurve.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
		}
		IEnumerable<Xbim.Ifc4.GeometryResource.IfcTrimmingSelect> IIfcTrimmedCurve.Trim1 
		{ 
			get
			{
			foreach (var member in Trim1)
			{
				var ifccartesianpoint = member as IfcCartesianPoint;
				if (ifccartesianpoint != null) 
					yield return ifccartesianpoint;
				if (member is MeasureResource.IfcParameterValue) 
					yield return new Ifc4.MeasureResource.IfcParameterValue((double)(MeasureResource.IfcParameterValue)member);
			}
			} 
		}
		IEnumerable<Xbim.Ifc4.GeometryResource.IfcTrimmingSelect> IIfcTrimmedCurve.Trim2 
		{ 
			get
			{
			foreach (var member in Trim2)
			{
				var ifccartesianpoint = member as IfcCartesianPoint;
				if (ifccartesianpoint != null) 
					yield return ifccartesianpoint;
				if (member is MeasureResource.IfcParameterValue) 
					yield return new Ifc4.MeasureResource.IfcParameterValue((double)(MeasureResource.IfcParameterValue)member);
			}
			} 
		}
		bool IIfcTrimmedCurve.SenseAgreement 
		{ 
			get
			{
				return SenseAgreement;
			} 
		}
		Ifc4.GeometryResource.IfcTrimmingPreference IIfcTrimmedCurve.MasterRepresentation 
		{ 
			get
			{
				switch (MasterRepresentation)
				{
					case IfcTrimmingPreference.CARTESIAN:
						return Ifc4.GeometryResource.IfcTrimmingPreference.CARTESIAN;
					
					case IfcTrimmingPreference.PARAMETER:
						return Ifc4.GeometryResource.IfcTrimmingPreference.PARAMETER;
					
					case IfcTrimmingPreference.UNSPECIFIED:
						return Ifc4.GeometryResource.IfcTrimmingPreference.UNSPECIFIED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
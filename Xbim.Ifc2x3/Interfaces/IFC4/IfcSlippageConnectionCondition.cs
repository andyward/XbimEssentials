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
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcSlippageConnectionCondition : IIfcSlippageConnectionCondition
	{
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageX 
		{ 
			get
			{
				if (!SlippageX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageX.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageY 
		{ 
			get
			{
				if (!SlippageY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageY.Value);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSlippageConnectionCondition.SlippageZ 
		{ 
			get
			{
				if (!SlippageZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(SlippageZ.Value);
			} 
		}

	//## Custom code
	//##
	}
}
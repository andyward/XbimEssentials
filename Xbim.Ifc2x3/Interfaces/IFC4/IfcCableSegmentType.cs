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
namespace Xbim.Ifc2x3.ElectricalDomain
{
	public partial class @IfcCableSegmentType : IIfcCableSegmentType
	{
		Ifc4.ElectricalDomain.IfcCableSegmentTypeEnum IIfcCableSegmentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCableSegmentTypeEnum.CABLESEGMENT:
						return Ifc4.ElectricalDomain.IfcCableSegmentTypeEnum.CABLESEGMENT;
					
					case IfcCableSegmentTypeEnum.CONDUCTORSEGMENT:
						return Ifc4.ElectricalDomain.IfcCableSegmentTypeEnum.CONDUCTORSEGMENT;
					
					case IfcCableSegmentTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcCableSegmentTypeEnum.USERDEFINED;
					
					case IfcCableSegmentTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcCableSegmentTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
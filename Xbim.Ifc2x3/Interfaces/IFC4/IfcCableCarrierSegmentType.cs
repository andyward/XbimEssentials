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
	public partial class @IfcCableCarrierSegmentType : IIfcCableCarrierSegmentType
	{
		Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum IIfcCableCarrierSegmentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.CABLELADDERSEGMENT;
					
					case IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.CABLETRAYSEGMENT;
					
					case IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.CABLETRUNKINGSEGMENT;
					
					case IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.CONDUITSEGMENT;
					
					case IfcCableCarrierSegmentTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.USERDEFINED;
					
					case IfcCableCarrierSegmentTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcCableCarrierSegmentTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
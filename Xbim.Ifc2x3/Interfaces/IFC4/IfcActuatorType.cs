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
namespace Xbim.Ifc2x3.BuildingcontrolsDomain
{
	public partial class @IfcActuatorType : IIfcActuatorType
	{
		Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum IIfcActuatorType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcActuatorTypeEnum.ELECTRICACTUATOR:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.ELECTRICACTUATOR;
					
					case IfcActuatorTypeEnum.HANDOPERATEDACTUATOR:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.HANDOPERATEDACTUATOR;
					
					case IfcActuatorTypeEnum.HYDRAULICACTUATOR:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.HYDRAULICACTUATOR;
					
					case IfcActuatorTypeEnum.PNEUMATICACTUATOR:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.PNEUMATICACTUATOR;
					
					case IfcActuatorTypeEnum.THERMOSTATICACTUATOR:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.THERMOSTATICACTUATOR;
					
					case IfcActuatorTypeEnum.USERDEFINED:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.USERDEFINED;
					
					case IfcActuatorTypeEnum.NOTDEFINED:
						return Ifc4.BuildingControlsDomain.IfcActuatorTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
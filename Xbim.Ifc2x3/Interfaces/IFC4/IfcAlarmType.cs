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
	public partial class @IfcAlarmType : IIfcAlarmType
	{
		Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum IIfcAlarmType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcAlarmTypeEnum.BELL:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.BELL;
					
					case IfcAlarmTypeEnum.BREAKGLASSBUTTON:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.BREAKGLASSBUTTON;
					
					case IfcAlarmTypeEnum.LIGHT:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.LIGHT;
					
					case IfcAlarmTypeEnum.MANUALPULLBOX:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.MANUALPULLBOX;
					
					case IfcAlarmTypeEnum.SIREN:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.SIREN;
					
					case IfcAlarmTypeEnum.WHISTLE:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.WHISTLE;
					
					case IfcAlarmTypeEnum.USERDEFINED:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.USERDEFINED;
					
					case IfcAlarmTypeEnum.NOTDEFINED:
						return Ifc4.BuildingControlsDomain.IfcAlarmTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
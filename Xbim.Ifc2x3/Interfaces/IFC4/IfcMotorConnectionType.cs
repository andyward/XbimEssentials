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
	public partial class @IfcMotorConnectionType : IIfcMotorConnectionType
	{
		Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum IIfcMotorConnectionType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcMotorConnectionTypeEnum.BELTDRIVE:
						return Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum.BELTDRIVE;
					
					case IfcMotorConnectionTypeEnum.COUPLING:
						return Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum.COUPLING;
					
					case IfcMotorConnectionTypeEnum.DIRECTDRIVE:
						return Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum.DIRECTDRIVE;
					
					case IfcMotorConnectionTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum.USERDEFINED;
					
					case IfcMotorConnectionTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcMotorConnectionTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
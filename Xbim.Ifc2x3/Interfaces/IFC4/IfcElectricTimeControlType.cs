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
	public partial class @IfcElectricTimeControlType : IIfcElectricTimeControlType
	{
		Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum IIfcElectricTimeControlType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcElectricTimeControlTypeEnum.TIMECLOCK:
						return Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum.TIMECLOCK;
					
					case IfcElectricTimeControlTypeEnum.TIMEDELAY:
						return Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum.TIMEDELAY;
					
					case IfcElectricTimeControlTypeEnum.RELAY:
						return Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum.RELAY;
					
					case IfcElectricTimeControlTypeEnum.USERDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum.USERDEFINED;
					
					case IfcElectricTimeControlTypeEnum.NOTDEFINED:
						return Ifc4.ElectricalDomain.IfcElectricTimeControlTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
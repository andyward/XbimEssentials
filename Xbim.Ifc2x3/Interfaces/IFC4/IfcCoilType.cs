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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcCoilType : IIfcCoilType
	{
		Ifc4.HvacDomain.IfcCoilTypeEnum IIfcCoilType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcCoilTypeEnum.DXCOOLINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.DXCOOLINGCOIL;
					
					case IfcCoilTypeEnum.WATERCOOLINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.WATERCOOLINGCOIL;
					
					case IfcCoilTypeEnum.STEAMHEATINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.STEAMHEATINGCOIL;
					
					case IfcCoilTypeEnum.WATERHEATINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.WATERHEATINGCOIL;
					
					case IfcCoilTypeEnum.ELECTRICHEATINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.ELECTRICHEATINGCOIL;
					
					case IfcCoilTypeEnum.GASHEATINGCOIL:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.GASHEATINGCOIL;
					
					case IfcCoilTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.USERDEFINED;
					
					case IfcCoilTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcCoilTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
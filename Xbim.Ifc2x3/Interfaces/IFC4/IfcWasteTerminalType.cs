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
namespace Xbim.Ifc2x3.PlumbingFireProtectionDomain
{
	public partial class @IfcWasteTerminalType : IIfcWasteTerminalType
	{
		Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum IIfcWasteTerminalType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcWasteTerminalTypeEnum.FLOORTRAP:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORTRAP;
					
					case IfcWasteTerminalTypeEnum.FLOORWASTE:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.FLOORWASTE;
					
					case IfcWasteTerminalTypeEnum.GULLYSUMP:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYSUMP;
					
					case IfcWasteTerminalTypeEnum.GULLYTRAP:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.GULLYTRAP;
					
					case IfcWasteTerminalTypeEnum.GREASEINTERCEPTOR:
						//## Handle translation of GREASEINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
                        return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED;
						//##
										
					case IfcWasteTerminalTypeEnum.OILINTERCEPTOR:
						//## Handle translation of OILINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
                        return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED;
						//##
										
					case IfcWasteTerminalTypeEnum.PETROLINTERCEPTOR:
						//## Handle translation of PETROLINTERCEPTOR member from IfcWasteTerminalTypeEnum in property PredefinedType
                        return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED;
						//##
										
					case IfcWasteTerminalTypeEnum.ROOFDRAIN:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.ROOFDRAIN;
					
					case IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT;
					
					case IfcWasteTerminalTypeEnum.WASTETRAP:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.WASTETRAP;
					
					case IfcWasteTerminalTypeEnum.USERDEFINED:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.USERDEFINED;
					
					case IfcWasteTerminalTypeEnum.NOTDEFINED:
						return Ifc4.PlumbingFireProtectionDomain.IfcWasteTerminalTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
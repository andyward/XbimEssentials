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
	public partial class @IfcDamperType : IIfcDamperType
	{
		Ifc4.HvacDomain.IfcDamperTypeEnum IIfcDamperType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcDamperTypeEnum.CONTROLDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.CONTROLDAMPER;
					
					case IfcDamperTypeEnum.FIREDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.FIREDAMPER;
					
					case IfcDamperTypeEnum.SMOKEDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.SMOKEDAMPER;
					
					case IfcDamperTypeEnum.FIRESMOKEDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.FIRESMOKEDAMPER;
					
					case IfcDamperTypeEnum.BACKDRAFTDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.BACKDRAFTDAMPER;
					
					case IfcDamperTypeEnum.RELIEFDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.RELIEFDAMPER;
					
					case IfcDamperTypeEnum.BLASTDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.BLASTDAMPER;
					
					case IfcDamperTypeEnum.GRAVITYDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.GRAVITYDAMPER;
					
					case IfcDamperTypeEnum.GRAVITYRELIEFDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.GRAVITYRELIEFDAMPER;
					
					case IfcDamperTypeEnum.BALANCINGDAMPER:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.BALANCINGDAMPER;
					
					case IfcDamperTypeEnum.FUMEHOODEXHAUST:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.FUMEHOODEXHAUST;
					
					case IfcDamperTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.USERDEFINED;
					
					case IfcDamperTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcDamperTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}

	//## Custom code
	//##
	}
}
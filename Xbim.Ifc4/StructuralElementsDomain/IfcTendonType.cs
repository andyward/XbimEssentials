// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.StructuralElementsDomain;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTendonType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTendonType : IIfcReinforcingElementType
	{
		IfcTendonTypeEnum @PredefinedType { get;  set; }
		IfcPositiveLengthMeasure? @NominalDiameter { get;  set; }
		IfcAreaMeasure? @CrossSectionArea { get;  set; }
		IfcPositiveLengthMeasure? @SheethDiameter { get;  set; }
	
	}
}

namespace Xbim.Ifc4.StructuralElementsDomain
{
	[ExpressType("IfcTendonType", 1298)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTendonType : IfcReinforcingElementType, IInstantiableEntity, IIfcTendonType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTendonType>
	{
		#region IIfcTendonType explicit implementation
		IfcTendonTypeEnum IIfcTendonType.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IfcPositiveLengthMeasure? IIfcTendonType.NominalDiameter { 
 
			get { return @NominalDiameter; } 
			set { NominalDiameter = value;}
		}	
		IfcAreaMeasure? IIfcTendonType.CrossSectionArea { 
 
			get { return @CrossSectionArea; } 
			set { CrossSectionArea = value;}
		}	
		IfcPositiveLengthMeasure? IIfcTendonType.SheethDiameter { 
 
			get { return @SheethDiameter; } 
			set { SheethDiameter = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTendonType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTendonTypeEnum _predefinedType;
		private IfcPositiveLengthMeasure? _nominalDiameter;
		private IfcAreaMeasure? _crossSectionArea;
		private IfcPositiveLengthMeasure? _sheethDiameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1, 19)]
		public IfcTendonTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 20)]
		public IfcPositiveLengthMeasure? @NominalDiameter 
		{ 
			get 
			{
				if(_activated) return _nominalDiameter;
				Activate();
				return _nominalDiameter;
			} 
			set
			{
				SetValue( v =>  _nominalDiameter = v, _nominalDiameter, value,  "NominalDiameter", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 21)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(_activated) return _crossSectionArea;
				Activate();
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 22)]
		public IfcPositiveLengthMeasure? @SheethDiameter 
		{ 
			get 
			{
				if(_activated) return _sheethDiameter;
				Activate();
				return _sheethDiameter;
			} 
			set
			{
				SetValue( v =>  _sheethDiameter = v, _sheethDiameter, value,  "SheethDiameter", 13);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcTendonTypeEnum) System.Enum.Parse(typeof (IfcTendonTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_nominalDiameter = value.RealVal;
					return;
				case 11: 
					_crossSectionArea = value.RealVal;
					return;
				case 12: 
					_sheethDiameter = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTendonType other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @HasPropertySets)
					yield return entity;
				foreach(var entity in @RepresentationMaps)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
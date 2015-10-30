// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MaterialResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.MaterialPropertyResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcThermalMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcThermalMaterialProperties : IIfcMaterialProperties
	{
		IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity { get; }
		IfcThermodynamicTemperatureMeasure? @BoilingPoint { get; }
		IfcThermodynamicTemperatureMeasure? @FreezingPoint { get; }
		IfcThermalConductivityMeasure? @ThermalConductivity { get; }
		
	}
}

namespace Xbim.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IFCTHERMALMATERIALPROPERTIES", 720)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcThermalMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcThermalMaterialProperties, IEqualityComparer<@IfcThermalMaterialProperties>, IEquatable<@IfcThermalMaterialProperties>
	{
		#region IIfcThermalMaterialProperties explicit implementation
		IfcSpecificHeatCapacityMeasure? IIfcThermalMaterialProperties.SpecificHeatCapacity { get { return @SpecificHeatCapacity; } }	
		IfcThermodynamicTemperatureMeasure? IIfcThermalMaterialProperties.BoilingPoint { get { return @BoilingPoint; } }	
		IfcThermodynamicTemperatureMeasure? IIfcThermalMaterialProperties.FreezingPoint { get { return @FreezingPoint; } }	
		IfcThermalConductivityMeasure? IIfcThermalMaterialProperties.ThermalConductivity { get { return @ThermalConductivity; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcThermalMaterialProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSpecificHeatCapacityMeasure? _specificHeatCapacity;
		private IfcThermodynamicTemperatureMeasure? _boilingPoint;
		private IfcThermodynamicTemperatureMeasure? _freezingPoint;
		private IfcThermalConductivityMeasure? _thermalConductivity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _specificHeatCapacity;
				((IPersistEntity)this).Activate(false);
				return _specificHeatCapacity;
			} 
			set
			{
				SetValue( v =>  _specificHeatCapacity = v, _specificHeatCapacity, value,  "SpecificHeatCapacity");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @BoilingPoint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _boilingPoint;
				((IPersistEntity)this).Activate(false);
				return _boilingPoint;
			} 
			set
			{
				SetValue( v =>  _boilingPoint = v, _boilingPoint, value,  "BoilingPoint");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure? @FreezingPoint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _freezingPoint;
				((IPersistEntity)this).Activate(false);
				return _freezingPoint;
			} 
			set
			{
				SetValue( v =>  _freezingPoint = v, _freezingPoint, value,  "FreezingPoint");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermalConductivityMeasure? @ThermalConductivity 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thermalConductivity;
				((IPersistEntity)this).Activate(false);
				return _thermalConductivity;
			} 
			set
			{
				SetValue( v =>  _thermalConductivity = v, _thermalConductivity, value,  "ThermalConductivity");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_specificHeatCapacity = value.RealVal;
					return;
				case 2: 
					_boilingPoint = value.RealVal;
					return;
				case 3: 
					_freezingPoint = value.RealVal;
					return;
				case 4: 
					_thermalConductivity = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcThermalMaterialProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcThermalMaterialProperties
            var root = (@IfcThermalMaterialProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcThermalMaterialProperties left, @IfcThermalMaterialProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcThermalMaterialProperties left, @IfcThermalMaterialProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcThermalMaterialProperties x, @IfcThermalMaterialProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcThermalMaterialProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
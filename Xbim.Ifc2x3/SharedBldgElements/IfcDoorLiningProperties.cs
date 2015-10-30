// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedBldgElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDoorLiningProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDoorLiningProperties : IIfcPropertySetDefinition
	{
		IfcPositiveLengthMeasure? @LiningDepth { get; }
		IfcPositiveLengthMeasure? @LiningThickness { get; }
		IfcPositiveLengthMeasure? @ThresholdDepth { get; }
		IfcPositiveLengthMeasure? @ThresholdThickness { get; }
		IfcPositiveLengthMeasure? @TransomThickness { get; }
		IfcLengthMeasure? @TransomOffset { get; }
		IfcLengthMeasure? @LiningOffset { get; }
		IfcLengthMeasure? @ThresholdOffset { get; }
		IfcPositiveLengthMeasure? @CasingThickness { get; }
		IfcPositiveLengthMeasure? @CasingDepth { get; }
		IIfcShapeAspect @ShapeAspectStyle { get; }
		
	}
}

namespace Xbim.Ifc2x3.SharedBldgElements
{
	[ExpressType("IFCDOORLININGPROPERTIES", 493)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDoorLiningProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcDoorLiningProperties, IEqualityComparer<@IfcDoorLiningProperties>, IEquatable<@IfcDoorLiningProperties>
	{
		#region IIfcDoorLiningProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.LiningDepth { get { return @LiningDepth; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.LiningThickness { get { return @LiningThickness; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.ThresholdDepth { get { return @ThresholdDepth; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.ThresholdThickness { get { return @ThresholdThickness; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.TransomThickness { get { return @TransomThickness; } }	
		IfcLengthMeasure? IIfcDoorLiningProperties.TransomOffset { get { return @TransomOffset; } }	
		IfcLengthMeasure? IIfcDoorLiningProperties.LiningOffset { get { return @LiningOffset; } }	
		IfcLengthMeasure? IIfcDoorLiningProperties.ThresholdOffset { get { return @ThresholdOffset; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.CasingThickness { get { return @CasingThickness; } }	
		IfcPositiveLengthMeasure? IIfcDoorLiningProperties.CasingDepth { get { return @CasingDepth; } }	
		IIfcShapeAspect IIfcDoorLiningProperties.ShapeAspectStyle { get { return @ShapeAspectStyle; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDoorLiningProperties(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcPositiveLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _thresholdDepth;
		private IfcPositiveLengthMeasure? _thresholdThickness;
		private IfcPositiveLengthMeasure? _transomThickness;
		private IfcLengthMeasure? _transomOffset;
		private IfcLengthMeasure? _liningOffset;
		private IfcLengthMeasure? _thresholdOffset;
		private IfcPositiveLengthMeasure? _casingThickness;
		private IfcPositiveLengthMeasure? _casingDepth;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningDepth;
				((IPersistEntity)this).Activate(false);
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningThickness;
				((IPersistEntity)this).Activate(false);
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @ThresholdDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thresholdDepth;
				((IPersistEntity)this).Activate(false);
				return _thresholdDepth;
			} 
			set
			{
				SetValue( v =>  _thresholdDepth = v, _thresholdDepth, value,  "ThresholdDepth");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @ThresholdThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thresholdThickness;
				((IPersistEntity)this).Activate(false);
				return _thresholdThickness;
			} 
			set
			{
				SetValue( v =>  _thresholdThickness = v, _thresholdThickness, value,  "ThresholdThickness");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transomThickness;
				((IPersistEntity)this).Activate(false);
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @TransomOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transomOffset;
				((IPersistEntity)this).Activate(false);
				return _transomOffset;
			} 
			set
			{
				SetValue( v =>  _transomOffset = v, _transomOffset, value,  "TransomOffset");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @LiningOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _liningOffset;
				((IPersistEntity)this).Activate(false);
				return _liningOffset;
			} 
			set
			{
				SetValue( v =>  _liningOffset = v, _liningOffset, value,  "LiningOffset");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ThresholdOffset 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _thresholdOffset;
				((IPersistEntity)this).Activate(false);
				return _thresholdOffset;
			} 
			set
			{
				SetValue( v =>  _thresholdOffset = v, _thresholdOffset, value,  "ThresholdOffset");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CasingThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _casingThickness;
				((IPersistEntity)this).Activate(false);
				return _casingThickness;
			} 
			set
			{
				SetValue( v =>  _casingThickness = v, _casingThickness, value,  "CasingThickness");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CasingDepth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _casingDepth;
				((IPersistEntity)this).Activate(false);
				return _casingDepth;
			} 
			set
			{
				SetValue( v =>  _casingDepth = v, _casingDepth, value,  "CasingDepth");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _shapeAspectStyle;
				((IPersistEntity)this).Activate(false);
				return _shapeAspectStyle;
			} 
			set
			{
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_thresholdDepth = value.RealVal;
					return;
				case 7: 
					_thresholdThickness = value.RealVal;
					return;
				case 8: 
					_transomThickness = value.RealVal;
					return;
				case 9: 
					_transomOffset = value.RealVal;
					return;
				case 10: 
					_liningOffset = value.RealVal;
					return;
				case 11: 
					_thresholdOffset = value.RealVal;
					return;
				case 12: 
					_casingThickness = value.RealVal;
					return;
				case 13: 
					_casingDepth = value.RealVal;
					return;
				case 14: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:	WR31 : NOT(NOT(EXISTS(LiningDepth)) AND EXISTS(LiningThickness));*/
		/*WR32:	WR32 : NOT(NOT(EXISTS(ThresholdDepth)) AND EXISTS(ThresholdThickness));*/
		/*WR33:             (NOT(EXISTS(TransomOffset)) AND NOT(EXISTS(TransomThickness)));*/
		/*WR34:             (NOT(EXISTS(CasingDepth)) AND NOT(EXISTS(CasingThickness)));*/
		/*WR35:             ('IFC2X3.IFCDOORSTYLE' IN TYPEOF(SELF\IfcPropertySetDefinition.DefinesType[1]));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDoorLiningProperties other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDoorLiningProperties
            var root = (@IfcDoorLiningProperties)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDoorLiningProperties left, @IfcDoorLiningProperties right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDoorLiningProperties left, @IfcDoorLiningProperties right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDoorLiningProperties x, @IfcDoorLiningProperties y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDoorLiningProperties obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
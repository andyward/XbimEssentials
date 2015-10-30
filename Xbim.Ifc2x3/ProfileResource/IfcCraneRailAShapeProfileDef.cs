// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfileResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCraneRailAShapeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCraneRailAShapeProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @OverallHeight { get; }
		IfcPositiveLengthMeasure @BaseWidth2 { get; }
		IfcPositiveLengthMeasure? @Radius { get; }
		IfcPositiveLengthMeasure @HeadWidth { get; }
		IfcPositiveLengthMeasure @HeadDepth2 { get; }
		IfcPositiveLengthMeasure @HeadDepth3 { get; }
		IfcPositiveLengthMeasure @WebThickness { get; }
		IfcPositiveLengthMeasure @BaseWidth4 { get; }
		IfcPositiveLengthMeasure @BaseDepth1 { get; }
		IfcPositiveLengthMeasure @BaseDepth2 { get; }
		IfcPositiveLengthMeasure @BaseDepth3 { get; }
		IfcPositiveLengthMeasure? @CentreOfGravityInY { get; }
		
	}
}

namespace Xbim.Ifc2x3.ProfileResource
{
	[ExpressType("IFCCRANERAILASHAPEPROFILEDEF", 257)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCraneRailAShapeProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcCraneRailAShapeProfileDef, IEqualityComparer<@IfcCraneRailAShapeProfileDef>, IEquatable<@IfcCraneRailAShapeProfileDef>
	{
		#region IIfcCraneRailAShapeProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.OverallHeight { get { return @OverallHeight; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseWidth2 { get { return @BaseWidth2; } }	
		IfcPositiveLengthMeasure? IIfcCraneRailAShapeProfileDef.Radius { get { return @Radius; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadWidth { get { return @HeadWidth; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadDepth2 { get { return @HeadDepth2; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.HeadDepth3 { get { return @HeadDepth3; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.WebThickness { get { return @WebThickness; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseWidth4 { get { return @BaseWidth4; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth1 { get { return @BaseDepth1; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth2 { get { return @BaseDepth2; } }	
		IfcPositiveLengthMeasure IIfcCraneRailAShapeProfileDef.BaseDepth3 { get { return @BaseDepth3; } }	
		IfcPositiveLengthMeasure? IIfcCraneRailAShapeProfileDef.CentreOfGravityInY { get { return @CentreOfGravityInY; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCraneRailAShapeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _overallHeight;
		private IfcPositiveLengthMeasure _baseWidth2;
		private IfcPositiveLengthMeasure? _radius;
		private IfcPositiveLengthMeasure _headWidth;
		private IfcPositiveLengthMeasure _headDepth2;
		private IfcPositiveLengthMeasure _headDepth3;
		private IfcPositiveLengthMeasure _webThickness;
		private IfcPositiveLengthMeasure _baseWidth4;
		private IfcPositiveLengthMeasure _baseDepth1;
		private IfcPositiveLengthMeasure _baseDepth2;
		private IfcPositiveLengthMeasure _baseDepth3;
		private IfcPositiveLengthMeasure? _centreOfGravityInY;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @OverallHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _overallHeight;
				((IPersistEntity)this).Activate(false);
				return _overallHeight;
			} 
			set
			{
				SetValue( v =>  _overallHeight = v, _overallHeight, value,  "OverallHeight");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseWidth2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseWidth2;
				((IPersistEntity)this).Activate(false);
				return _baseWidth2;
			} 
			set
			{
				SetValue( v =>  _baseWidth2 = v, _baseWidth2, value,  "BaseWidth2");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Radius 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _radius;
				((IPersistEntity)this).Activate(false);
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadWidth 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headWidth;
				((IPersistEntity)this).Activate(false);
				return _headWidth;
			} 
			set
			{
				SetValue( v =>  _headWidth = v, _headWidth, value,  "HeadWidth");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadDepth2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headDepth2;
				((IPersistEntity)this).Activate(false);
				return _headDepth2;
			} 
			set
			{
				SetValue( v =>  _headDepth2 = v, _headDepth2, value,  "HeadDepth2");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @HeadDepth3 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _headDepth3;
				((IPersistEntity)this).Activate(false);
				return _headDepth3;
			} 
			set
			{
				SetValue( v =>  _headDepth3 = v, _headDepth3, value,  "HeadDepth3");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @WebThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _webThickness;
				((IPersistEntity)this).Activate(false);
				return _webThickness;
			} 
			set
			{
				SetValue( v =>  _webThickness = v, _webThickness, value,  "WebThickness");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseWidth4 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseWidth4;
				((IPersistEntity)this).Activate(false);
				return _baseWidth4;
			} 
			set
			{
				SetValue( v =>  _baseWidth4 = v, _baseWidth4, value,  "BaseWidth4");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth1 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseDepth1;
				((IPersistEntity)this).Activate(false);
				return _baseDepth1;
			} 
			set
			{
				SetValue( v =>  _baseDepth1 = v, _baseDepth1, value,  "BaseDepth1");
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth2 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseDepth2;
				((IPersistEntity)this).Activate(false);
				return _baseDepth2;
			} 
			set
			{
				SetValue( v =>  _baseDepth2 = v, _baseDepth2, value,  "BaseDepth2");
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure @BaseDepth3 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _baseDepth3;
				((IPersistEntity)this).Activate(false);
				return _baseDepth3;
			} 
			set
			{
				SetValue( v =>  _baseDepth3 = v, _baseDepth3, value,  "BaseDepth3");
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @CentreOfGravityInY 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _centreOfGravityInY;
				((IPersistEntity)this).Activate(false);
				return _centreOfGravityInY;
			} 
			set
			{
				SetValue( v =>  _centreOfGravityInY = v, _centreOfGravityInY, value,  "CentreOfGravityInY");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_overallHeight = value.RealVal;
					return;
				case 4: 
					_baseWidth2 = value.RealVal;
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_headWidth = value.RealVal;
					return;
				case 7: 
					_headDepth2 = value.RealVal;
					return;
				case 8: 
					_headDepth3 = value.RealVal;
					return;
				case 9: 
					_webThickness = value.RealVal;
					return;
				case 10: 
					_baseWidth4 = value.RealVal;
					return;
				case 11: 
					_baseDepth1 = value.RealVal;
					return;
				case 12: 
					_baseDepth2 = value.RealVal;
					return;
				case 13: 
					_baseDepth3 = value.RealVal;
					return;
				case 14: 
					_centreOfGravityInY = value.RealVal;
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
        public bool Equals(@IfcCraneRailAShapeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCraneRailAShapeProfileDef
            var root = (@IfcCraneRailAShapeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCraneRailAShapeProfileDef left, @IfcCraneRailAShapeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCraneRailAShapeProfileDef left, @IfcCraneRailAShapeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCraneRailAShapeProfileDef x, @IfcCraneRailAShapeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCraneRailAShapeProfileDef obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
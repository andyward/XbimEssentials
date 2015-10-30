// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.GeometricConstraintResource;
using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.SharedComponentElements;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcChamferEdgeFeature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcChamferEdgeFeature : IIfcEdgeFeature
	{
		IfcPositiveLengthMeasure? @Width { get; }
		IfcPositiveLengthMeasure? @Height { get; }
		
	}
}

namespace Xbim.Ifc2x3.SharedComponentElements
{
	[ExpressType("IFCCHAMFEREDGEFEATURE", 765)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcChamferEdgeFeature : IfcEdgeFeature, IInstantiableEntity, IIfcChamferEdgeFeature, IEqualityComparer<@IfcChamferEdgeFeature>, IEquatable<@IfcChamferEdgeFeature>
	{
		#region IIfcChamferEdgeFeature explicit implementation
		IfcPositiveLengthMeasure? IIfcChamferEdgeFeature.Width { get { return @Width; } }	
		IfcPositiveLengthMeasure? IIfcChamferEdgeFeature.Height { get { return @Height; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcChamferEdgeFeature(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _width;
		private IfcPositiveLengthMeasure? _height;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Width 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _width;
				((IPersistEntity)this).Activate(false);
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcPositiveLengthMeasure? @Height 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _height;
				((IPersistEntity)this).Activate(false);
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height");
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
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_width = value.RealVal;
					return;
				case 10: 
					_height = value.RealVal;
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
        public bool Equals(@IfcChamferEdgeFeature other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcChamferEdgeFeature
            var root = (@IfcChamferEdgeFeature)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcChamferEdgeFeature left, @IfcChamferEdgeFeature right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcChamferEdgeFeature left, @IfcChamferEdgeFeature right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcChamferEdgeFeature x, @IfcChamferEdgeFeature y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcChamferEdgeFeature obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
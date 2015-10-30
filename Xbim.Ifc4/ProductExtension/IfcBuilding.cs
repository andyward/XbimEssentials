// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ProductExtension;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBuilding
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBuilding : IIfcSpatialStructureElement
	{
		IfcLengthMeasure? @ElevationOfRefHeight { get; }
		IfcLengthMeasure? @ElevationOfTerrain { get; }
		IIfcPostalAddress @BuildingAddress { get; }
		
	}
}

namespace Xbim.Ifc4.ProductExtension
{
	[ExpressType("IFCBUILDING", 447)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBuilding : IfcSpatialStructureElement, IInstantiableEntity, IIfcBuilding, IEqualityComparer<@IfcBuilding>, IEquatable<@IfcBuilding>
	{
		#region IIfcBuilding explicit implementation
		IfcLengthMeasure? IIfcBuilding.ElevationOfRefHeight { get { return @ElevationOfRefHeight; } }	
		IfcLengthMeasure? IIfcBuilding.ElevationOfTerrain { get { return @ElevationOfTerrain; } }	
		IIfcPostalAddress IIfcBuilding.BuildingAddress { get { return @BuildingAddress; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBuilding(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure? _elevationOfRefHeight;
		private IfcLengthMeasure? _elevationOfTerrain;
		private IfcPostalAddress _buildingAddress;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ElevationOfRefHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _elevationOfRefHeight;
				((IPersistEntity)this).Activate(false);
				return _elevationOfRefHeight;
			} 
			set
			{
				SetValue( v =>  _elevationOfRefHeight = v, _elevationOfRefHeight, value,  "ElevationOfRefHeight");
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLengthMeasure? @ElevationOfTerrain 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _elevationOfTerrain;
				((IPersistEntity)this).Activate(false);
				return _elevationOfTerrain;
			} 
			set
			{
				SetValue( v =>  _elevationOfTerrain = v, _elevationOfTerrain, value,  "ElevationOfTerrain");
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPostalAddress @BuildingAddress 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _buildingAddress;
				((IPersistEntity)this).Activate(false);
				return _buildingAddress;
			} 
			set
			{
				SetValue( v =>  _buildingAddress = v, _buildingAddress, value,  "BuildingAddress");
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
					_elevationOfRefHeight = value.RealVal;
					return;
				case 10: 
					_elevationOfTerrain = value.RealVal;
					return;
				case 11: 
					_buildingAddress = (IfcPostalAddress)(value.EntityVal);
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
        public bool Equals(@IfcBuilding other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcBuilding
            var root = (@IfcBuilding)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcBuilding left, @IfcBuilding right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcBuilding left, @IfcBuilding right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcBuilding x, @IfcBuilding y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcBuilding obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
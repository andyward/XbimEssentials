// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometryResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMappedItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMappedItem : IIfcRepresentationItem
	{
		IIfcRepresentationMap @MappingSource { get; }
		IIfcCartesianTransformationOperator @MappingTarget { get; }
		
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCMAPPEDITEM", 740)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMappedItem : IfcRepresentationItem, IInstantiableEntity, IIfcMappedItem, IEqualityComparer<@IfcMappedItem>, IEquatable<@IfcMappedItem>
	{
		#region IIfcMappedItem explicit implementation
		IIfcRepresentationMap IIfcMappedItem.MappingSource { get { return @MappingSource; } }	
		IIfcCartesianTransformationOperator IIfcMappedItem.MappingTarget { get { return @MappingTarget; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMappedItem(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcRepresentationMap _mappingSource;
		private IfcCartesianTransformationOperator _mappingTarget;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRepresentationMap @MappingSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappingSource;
				((IPersistEntity)this).Activate(false);
				return _mappingSource;
			} 
			set
			{
				SetValue( v =>  _mappingSource = v, _mappingSource, value,  "MappingSource");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianTransformationOperator @MappingTarget 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappingTarget;
				((IPersistEntity)this).Activate(false);
				return _mappingTarget;
			} 
			set
			{
				SetValue( v =>  _mappingTarget = v, _mappingTarget, value,  "MappingTarget");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mappingSource = (IfcRepresentationMap)(value.EntityVal);
					return;
				case 1: 
					_mappingTarget = (IfcCartesianTransformationOperator)(value.EntityVal);
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
        public bool Equals(@IfcMappedItem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMappedItem
            var root = (@IfcMappedItem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMappedItem left, @IfcMappedItem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMappedItem left, @IfcMappedItem right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMappedItem x, @IfcMappedItem y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMappedItem obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
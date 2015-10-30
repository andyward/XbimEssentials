// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralLoadResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadConfiguration
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadConfiguration : IIfcStructuralLoad
	{
		IEnumerable<IIfcStructuralLoadOrResult> @Values { get; }
		IEnumerable<IEnumerable<IfcLengthMeasure>> @Locations { get; }
		
	}
}

namespace Xbim.Ifc4.StructuralLoadResource
{
	[ExpressType("IFCSTRUCTURALLOADCONFIGURATION", 1024)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadConfiguration : IfcStructuralLoad, IInstantiableEntity, IIfcStructuralLoadConfiguration, IEqualityComparer<@IfcStructuralLoadConfiguration>, IEquatable<@IfcStructuralLoadConfiguration>
	{
		#region IIfcStructuralLoadConfiguration explicit implementation
		IEnumerable<IIfcStructuralLoadOrResult> IIfcStructuralLoadConfiguration.Values { get { return @Values; } }	
		IEnumerable<IEnumerable<IfcLengthMeasure>> IIfcStructuralLoadConfiguration.Locations { get { return @Locations; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadConfiguration(IModel model) : base(model) 		{ 
			Model = model; 
			_values = new ItemSet<IfcStructuralLoadOrResult>( this, 0 );
			_locations = new OptionalItemSet<ItemSet<IfcLengthMeasure>>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcStructuralLoadOrResult> _values;
		private OptionalItemSet<ItemSet<IfcLengthMeasure>> _locations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcStructuralLoadOrResult> @Values 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _values;
				((IPersistEntity)this).Activate(false);
				return _values;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public OptionalItemSet<ItemSet<IfcLengthMeasure>> @Locations 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _locations;
				((IPersistEntity)this).Activate(false);
				return _locations;
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
					if (_values == null) _values = new ItemSet<IfcStructuralLoadOrResult>( this );
					_values.InternalAdd((IfcStructuralLoadOrResult)value.EntityVal);
					return;
				case 2: 
					_locations
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcLengthMeasure)(value.RealVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ValidListSize:	ValidListSize : NOT EXISTS(Locations) OR (SIZEOF(Locations) = SIZEOF(Values));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadConfiguration other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralLoadConfiguration
            var root = (@IfcStructuralLoadConfiguration)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralLoadConfiguration left, @IfcStructuralLoadConfiguration right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralLoadConfiguration left, @IfcStructuralLoadConfiguration right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralLoadConfiguration x, @IfcStructuralLoadConfiguration y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralLoadConfiguration obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
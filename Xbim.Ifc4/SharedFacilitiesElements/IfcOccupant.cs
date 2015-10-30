// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Kernel;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedFacilitiesElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOccupant
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOccupant : IIfcActor
	{
		IfcOccupantTypeEnum? @PredefinedType { get; }
		
	}
}

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IFCOCCUPANT", 778)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOccupant : IfcActor, IInstantiableEntity, IIfcOccupant, IEqualityComparer<@IfcOccupant>, IEquatable<@IfcOccupant>
	{
		#region IIfcOccupant explicit implementation
		IfcOccupantTypeEnum? IIfcOccupant.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOccupant(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcOccupantTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcOccupantTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcOccupantTypeEnum) System.Enum.Parse(typeof (IfcOccupantTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR31:             OR EXISTS(SELF\IfcObject.ObjectType);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOccupant other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcOccupant
            var root = (@IfcOccupant)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcOccupant left, @IfcOccupant right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcOccupant left, @IfcOccupant right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcOccupant x, @IfcOccupant y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcOccupant obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
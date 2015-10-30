// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.SharedBldgServiceElements;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDistributionSystem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionSystem : IIfcSystem
	{
		IfcLabel? @LongName { get; }
		IfcDistributionSystemEnum? @PredefinedType { get; }
		
	}
}

namespace Xbim.Ifc4.SharedBldgServiceElements
{
	[ExpressType("IFCDISTRIBUTIONSYSTEM", 577)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionSystem : IfcSystem, IInstantiableEntity, IIfcDistributionSystem, IEqualityComparer<@IfcDistributionSystem>, IEquatable<@IfcDistributionSystem>
	{
		#region IIfcDistributionSystem explicit implementation
		IfcLabel? IIfcDistributionSystem.LongName { get { return @LongName; } }	
		IfcDistributionSystemEnum? IIfcDistributionSystem.PredefinedType { get { return @PredefinedType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionSystem(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcDistributionSystemEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _longName;
				((IPersistEntity)this).Activate(false);
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcDistributionSystemEnum? @PredefinedType 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_longName = value.StringVal;
					return;
				case 6: 
                    _predefinedType = (IfcDistributionSystemEnum) System.Enum.Parse(typeof (IfcDistributionSystemEnum), value.EnumVal, true);
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
        public bool Equals(@IfcDistributionSystem other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcDistributionSystem
            var root = (@IfcDistributionSystem)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcDistributionSystem left, @IfcDistributionSystem right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcDistributionSystem left, @IfcDistributionSystem right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcDistributionSystem x, @IfcDistributionSystem y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcDistributionSystem obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
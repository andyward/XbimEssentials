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
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.StructuralAnalysisDomain;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralAction
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralAction : IIfcStructuralActivity
	{
		bool @DestabilizingLoad { get; }
		IIfcStructuralReaction @CausedBy { get; }
		
	}
}

namespace Xbim.Ifc2x3.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALACTION", 40)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcStructuralAction : IfcStructuralActivity, IIfcStructuralAction, IEqualityComparer<@IfcStructuralAction>, IEquatable<@IfcStructuralAction>
	{
		#region IIfcStructuralAction explicit implementation
		bool IIfcStructuralAction.DestabilizingLoad { get { return @DestabilizingLoad; } }	
		IIfcStructuralReaction IIfcStructuralAction.CausedBy { get { return @CausedBy; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralAction(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private bool _destabilizingLoad;
		private IfcStructuralReaction _causedBy;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @DestabilizingLoad 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _destabilizingLoad;
				((IPersistEntity)this).Activate(false);
				return _destabilizingLoad;
			} 
			set
			{
				SetValue( v =>  _destabilizingLoad = v, _destabilizingLoad, value,  "DestabilizingLoad");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcStructuralReaction @CausedBy 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _causedBy;
				((IPersistEntity)this).Activate(false);
				return _causedBy;
			} 
			set
			{
				SetValue( v =>  _causedBy = v, _causedBy, value,  "CausedBy");
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
					_destabilizingLoad = value.BooleanVal;
					return;
				case 10: 
					_causedBy = (IfcStructuralReaction)(value.EntityVal);
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
        public bool Equals(@IfcStructuralAction other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralAction
            var root = (@IfcStructuralAction)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralAction left, @IfcStructuralAction right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralAction left, @IfcStructuralAction right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralAction x, @IfcStructuralAction y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralAction obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
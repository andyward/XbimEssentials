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
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelSequence
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelSequence : IIfcRelConnects
	{
		IIfcProcess @RelatingProcess { get; }
		IIfcProcess @RelatedProcess { get; }
		IfcTimeMeasure @TimeLag { get; }
		IfcSequenceEnum @SequenceType { get; }
		
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCRELSEQUENCE", 490)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSequence : IfcRelConnects, IInstantiableEntity, IIfcRelSequence, IEqualityComparer<@IfcRelSequence>, IEquatable<@IfcRelSequence>
	{
		#region IIfcRelSequence explicit implementation
		IIfcProcess IIfcRelSequence.RelatingProcess { get { return @RelatingProcess; } }	
		IIfcProcess IIfcRelSequence.RelatedProcess { get { return @RelatedProcess; } }	
		IfcTimeMeasure IIfcRelSequence.TimeLag { get { return @TimeLag; } }	
		IfcSequenceEnum IIfcRelSequence.SequenceType { get { return @SequenceType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSequence(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProcess _relatingProcess;
		private IfcProcess _relatedProcess;
		private IfcTimeMeasure _timeLag;
		private IfcSequenceEnum _sequenceType;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcess @RelatingProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingProcess;
				((IPersistEntity)this).Activate(false);
				return _relatingProcess;
			} 
			set
			{
				SetValue( v =>  _relatingProcess = v, _relatingProcess, value,  "RelatingProcess");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcProcess @RelatedProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedProcess;
				((IPersistEntity)this).Activate(false);
				return _relatedProcess;
			} 
			set
			{
				SetValue( v =>  _relatedProcess = v, _relatedProcess, value,  "RelatedProcess");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTimeMeasure @TimeLag 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _timeLag;
				((IPersistEntity)this).Activate(false);
				return _timeLag;
			} 
			set
			{
				SetValue( v =>  _timeLag = v, _timeLag, value,  "TimeLag");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSequenceEnum @SequenceType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sequenceType;
				((IPersistEntity)this).Activate(false);
				return _sequenceType;
			} 
			set
			{
				SetValue( v =>  _sequenceType = v, _sequenceType, value,  "SequenceType");
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
					_relatingProcess = (IfcProcess)(value.EntityVal);
					return;
				case 5: 
					_relatedProcess = (IfcProcess)(value.EntityVal);
					return;
				case 6: 
					_timeLag = value.RealVal;
					return;
				case 7: 
                    _sequenceType = (IfcSequenceEnum) System.Enum.Parse(typeof (IfcSequenceEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : RelatingProcess :<>: RelatedProcess;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelSequence other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelSequence
            var root = (@IfcRelSequence)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelSequence left, @IfcRelSequence right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelSequence left, @IfcRelSequence right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelSequence x, @IfcRelSequence y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelSequence obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
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
    /// Readonly interface for IfcCompositeCurveSegment
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCompositeCurveSegment : IIfcGeometricRepresentationItem
	{
		IfcTransitionCode @Transition { get; }
		bool @SameSense { get; }
		IIfcCurve @ParentCurve { get; }
		IEnumerable<IIfcCompositeCurve> @UsingCurves {  get; }
		
	}
}

namespace Xbim.Ifc4.GeometryResource
{
	[ExpressType("IFCCOMPOSITECURVESEGMENT", 502)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeCurveSegment : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcCompositeCurveSegment, IEqualityComparer<@IfcCompositeCurveSegment>, IEquatable<@IfcCompositeCurveSegment>
	{
		#region IIfcCompositeCurveSegment explicit implementation
		IfcTransitionCode IIfcCompositeCurveSegment.Transition { get { return @Transition; } }	
		bool IIfcCompositeCurveSegment.SameSense { get { return @SameSense; } }	
		IIfcCurve IIfcCompositeCurveSegment.ParentCurve { get { return @ParentCurve; } }	
		 
		IEnumerable<IIfcCompositeCurve> IIfcCompositeCurveSegment.UsingCurves {  get { return @UsingCurves; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeCurveSegment(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcTransitionCode _transition;
		private bool _sameSense;
		private IfcCurve _parentCurve;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcTransitionCode @Transition 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _transition;
				((IPersistEntity)this).Activate(false);
				return _transition;
			} 
			set
			{
				SetValue( v =>  _transition = v, _transition, value,  "Transition");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public bool @SameSense 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sameSense;
				((IPersistEntity)this).Activate(false);
				return _sameSense;
			} 
			set
			{
				SetValue( v =>  _sameSense = v, _sameSense, value,  "SameSense");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCurve @ParentCurve 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _parentCurve;
				((IPersistEntity)this).Activate(false);
				return _parentCurve;
			} 
			set
			{
				SetValue( v =>  _parentCurve = v, _parentCurve, value,  "ParentCurve");
			} 
		}	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcCompositeCurve> @UsingCurves 
		{ 
			get 
			{
				return Model.Instances.Where<IfcCompositeCurve>(e => e.Segments != null &&  e.Segments.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _transition = (IfcTransitionCode) System.Enum.Parse(typeof (IfcTransitionCode), value.EnumVal, true);
					return;
				case 1: 
					_sameSense = value.BooleanVal;
					return;
				case 2: 
					_parentCurve = (IfcCurve)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*ParentIsBoundedCurve:	ParentIsBoundedCurve : ('IFC4.IFCBOUNDEDCURVE' IN TYPEOF(ParentCurve));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeCurveSegment other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCompositeCurveSegment
            var root = (@IfcCompositeCurveSegment)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCompositeCurveSegment left, @IfcCompositeCurveSegment right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCompositeCurveSegment left, @IfcCompositeCurveSegment right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCompositeCurveSegment x, @IfcCompositeCurveSegment y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCompositeCurveSegment obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
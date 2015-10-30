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
using Xbim.Ifc2x3.GeometryResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPlacement : IIfcGeometricRepresentationItem
	{
		IIfcCartesianPoint @Location { get; }
		
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IFCPLACEMENT", 281)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPlacement : IfcGeometricRepresentationItem, IIfcPlacement, IEqualityComparer<@IfcPlacement>, IEquatable<@IfcPlacement>
	{
		#region IIfcPlacement explicit implementation
		IIfcCartesianPoint IIfcPlacement.Location { get { return @Location; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _location;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcCartesianPoint @Location 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _location;
				((IPersistEntity)this).Activate(false);
				return _location;
			} 
			set
			{
				SetValue( v =>  _location = v, _location, value,  "Location");
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_location = (IfcCartesianPoint)(value.EntityVal);
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
        public bool Equals(@IfcPlacement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcPlacement
            var root = (@IfcPlacement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcPlacement left, @IfcPlacement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcPlacement left, @IfcPlacement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcPlacement x, @IfcPlacement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcPlacement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
    /// Readonly interface for IfcObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObject : IIfcObjectDefinition
	{
		IfcLabel? @ObjectType { get; }
		IEnumerable<IIfcRelDefines> @IsDefinedBy {  get; }
		
	}
}

namespace Xbim.Ifc2x3.Kernel
{
	[ExpressType("IFCOBJECT", 21)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObject : IfcObjectDefinition, IIfcObject, IEqualityComparer<@IfcObject>, IEquatable<@IfcObject>
	{
		#region IIfcObject explicit implementation
		IfcLabel? IIfcObject.ObjectType { get { return @ObjectType; } }	
		 
		IEnumerable<IIfcRelDefines> IIfcObject.IsDefinedBy {  get { return @IsDefinedBy; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObject(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLabel? _objectType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @ObjectType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _objectType;
				((IPersistEntity)this).Activate(false);
				return _objectType;
			} 
			set
			{
				SetValue( v =>  _objectType = v, _objectType, value,  "ObjectType");
			} 
		}	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelDefines> @IsDefinedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelDefines>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
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
					_objectType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* IsDefinedBy | 'IFC2X3.IFCRELDEFINESBYTYPE' IN TYPEOF(temp))) <= 1;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcObject
            var root = (@IfcObject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcObject left, @IfcObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcObject left, @IfcObject right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcObject x, @IfcObject y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcObject obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
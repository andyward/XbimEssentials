// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureCoordinate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureCoordinate : IIfcPresentationItem
	{
		IEnumerable<IIfcSurfaceTexture> @Maps { get; }
		
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCTEXTURECOORDINATE", 1098)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcTextureCoordinate : IfcPresentationItem, IIfcTextureCoordinate, IEqualityComparer<@IfcTextureCoordinate>, IEquatable<@IfcTextureCoordinate>
	{
		#region IIfcTextureCoordinate explicit implementation
		IEnumerable<IIfcSurfaceTexture> IIfcTextureCoordinate.Maps { get { return @Maps; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinate(IModel model) : base(model) 		{ 
			Model = model; 
			_maps = new ItemSet<IfcSurfaceTexture>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcSurfaceTexture> _maps;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcSurfaceTexture> @Maps 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _maps;
				((IPersistEntity)this).Activate(false);
				return _maps;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_maps == null) _maps = new ItemSet<IfcSurfaceTexture>( this );
					_maps.InternalAdd((IfcSurfaceTexture)value.EntityVal);
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
        public bool Equals(@IfcTextureCoordinate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureCoordinate
            var root = (@IfcTextureCoordinate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureCoordinate left, @IfcTextureCoordinate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureCoordinate left, @IfcTextureCoordinate right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextureCoordinate x, @IfcTextureCoordinate y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextureCoordinate obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
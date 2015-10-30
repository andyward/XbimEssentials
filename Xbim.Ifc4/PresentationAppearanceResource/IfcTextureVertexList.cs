// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureVertexList
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureVertexList : IIfcPresentationItem
	{
		IEnumerable<IEnumerable<IfcParameterValue>> @TexCoordsList { get; }
		
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IFCTEXTUREVERTEXLIST", 1102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertexList : IfcPresentationItem, IInstantiableEntity, IIfcTextureVertexList, IEqualityComparer<@IfcTextureVertexList>, IEquatable<@IfcTextureVertexList>
	{
		#region IIfcTextureVertexList explicit implementation
		IEnumerable<IEnumerable<IfcParameterValue>> IIfcTextureVertexList.TexCoordsList { get { return @TexCoordsList; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertexList(IModel model) : base(model) 		{ 
			Model = model; 
			_texCoordsList = new ItemSet<ItemSet<IfcParameterValue>>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<ItemSet<IfcParameterValue>> _texCoordsList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, 1, -1)]
		public ItemSet<ItemSet<IfcParameterValue>> @TexCoordsList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _texCoordsList;
				((IPersistEntity)this).Activate(false);
				return _texCoordsList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_texCoordsList
						.InternalGetAt(nestedIndex[0])
						.InternalAdd((IfcParameterValue)(value.RealVal));
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
        public bool Equals(@IfcTextureVertexList other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextureVertexList
            var root = (@IfcTextureVertexList)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextureVertexList left, @IfcTextureVertexList right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextureVertexList left, @IfcTextureVertexList right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextureVertexList x, @IfcTextureVertexList y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextureVertexList obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
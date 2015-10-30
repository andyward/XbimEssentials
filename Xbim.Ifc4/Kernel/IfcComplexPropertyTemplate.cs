// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcComplexPropertyTemplate
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcComplexPropertyTemplate : IIfcPropertyTemplate
	{
		IfcLabel? @UsageName { get; }
		IfcComplexPropertyTemplateTypeEnum? @TemplateType { get; }
		IEnumerable<IIfcPropertyTemplate> @HasPropertyTemplates { get; }
		
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCCOMPLEXPROPERTYTEMPLATE", 499)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexPropertyTemplate : IfcPropertyTemplate, IInstantiableEntity, IIfcComplexPropertyTemplate, IEqualityComparer<@IfcComplexPropertyTemplate>, IEquatable<@IfcComplexPropertyTemplate>
	{
		#region IIfcComplexPropertyTemplate explicit implementation
		IfcLabel? IIfcComplexPropertyTemplate.UsageName { get { return @UsageName; } }	
		IfcComplexPropertyTemplateTypeEnum? IIfcComplexPropertyTemplate.TemplateType { get { return @TemplateType; } }	
		IEnumerable<IIfcPropertyTemplate> IIfcComplexPropertyTemplate.HasPropertyTemplates { get { return @HasPropertyTemplates; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexPropertyTemplate(IModel model) : base(model) 		{ 
			Model = model; 
			_hasPropertyTemplates = new OptionalItemSet<IfcPropertyTemplate>( this, 0 );
		}

		#region Explicit attribute fields
		private IfcLabel? _usageName;
		private IfcComplexPropertyTemplateTypeEnum? _templateType;
		private OptionalItemSet<IfcPropertyTemplate> _hasPropertyTemplates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UsageName 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _usageName;
				((IPersistEntity)this).Activate(false);
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcComplexPropertyTemplateTypeEnum? @TemplateType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _templateType;
				((IPersistEntity)this).Activate(false);
				return _templateType;
			} 
			set
			{
				SetValue( v =>  _templateType = v, _templateType, value,  "TemplateType");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public OptionalItemSet<IfcPropertyTemplate> @HasPropertyTemplates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _hasPropertyTemplates;
				((IPersistEntity)this).Activate(false);
				return _hasPropertyTemplates;
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
					_usageName = value.StringVal;
					return;
				case 5: 
                    _templateType = (IfcComplexPropertyTemplateTypeEnum) System.Enum.Parse(typeof (IfcComplexPropertyTemplateTypeEnum), value.EnumVal, true);
					return;
				case 6: 
					if (_hasPropertyTemplates == null) _hasPropertyTemplates = new OptionalItemSet<IfcPropertyTemplate>( this );
					_hasPropertyTemplates.InternalAdd((IfcPropertyTemplate)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*UniquePropertyNames:	UniquePropertyNames : IfcUniquePropertyTemplateNames(HasPropertyTemplates);*/
		/*NoSelfReference:	NoSelfReference : SIZEOF(QUERY(temp <* HasPropertyTemplates | SELF :=: temp)) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcComplexPropertyTemplate other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcComplexPropertyTemplate
            var root = (@IfcComplexPropertyTemplate)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcComplexPropertyTemplate left, @IfcComplexPropertyTemplate right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcComplexPropertyTemplate left, @IfcComplexPropertyTemplate right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcComplexPropertyTemplate x, @IfcComplexPropertyTemplate y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcComplexPropertyTemplate obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
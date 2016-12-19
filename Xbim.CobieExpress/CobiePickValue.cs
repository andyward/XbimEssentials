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
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobiePickValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobiePickValue : IPersistEntity
	{
		string @Value { get;  set; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("PickValue", 35)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @CobiePickValue : PersistEntity, ICobiePickValue, IEquatable<@CobiePickValue>
	{
		#region ICobiePickValue explicit implementation
		string ICobiePickValue.Value { 
 
			get { return @Value; } 
			set { Value = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobiePickValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private string _value;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public string @Value 
		{ 
			get 
			{
				if(_activated) return _value;
				Activate();
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_value = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobiePickValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
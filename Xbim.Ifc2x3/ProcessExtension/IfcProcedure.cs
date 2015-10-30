// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProcessExtension;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProcedure
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProcedure : IIfcProcess
	{
		IfcIdentifier @ProcedureID { get; }
		IfcProcedureTypeEnum @ProcedureType { get; }
		IfcLabel? @UserDefinedProcedureType { get; }
		
	}
}

namespace Xbim.Ifc2x3.ProcessExtension
{
	[ExpressType("IFCPROCEDURE", 294)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProcedure : IfcProcess, IInstantiableEntity, IIfcProcedure, IEqualityComparer<@IfcProcedure>, IEquatable<@IfcProcedure>
	{
		#region IIfcProcedure explicit implementation
		IfcIdentifier IIfcProcedure.ProcedureID { get { return @ProcedureID; } }	
		IfcProcedureTypeEnum IIfcProcedure.ProcedureType { get { return @ProcedureType; } }	
		IfcLabel? IIfcProcedure.UserDefinedProcedureType { get { return @UserDefinedProcedureType; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProcedure(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcIdentifier _procedureID;
		private IfcProcedureTypeEnum _procedureType;
		private IfcLabel? _userDefinedProcedureType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier @ProcedureID 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _procedureID;
				((IPersistEntity)this).Activate(false);
				return _procedureID;
			} 
			set
			{
				SetValue( v =>  _procedureID = v, _procedureID, value,  "ProcedureID");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcProcedureTypeEnum @ProcedureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _procedureType;
				((IPersistEntity)this).Activate(false);
				return _procedureType;
			} 
			set
			{
				SetValue( v =>  _procedureType = v, _procedureType, value,  "ProcedureType");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @UserDefinedProcedureType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _userDefinedProcedureType;
				((IPersistEntity)this).Activate(false);
				return _userDefinedProcedureType;
			} 
			set
			{
				SetValue( v =>  _userDefinedProcedureType = v, _userDefinedProcedureType, value,  "UserDefinedProcedureType");
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
					_procedureID = value.StringVal;
					return;
				case 6: 
                    _procedureType = (IfcProcedureTypeEnum) System.Enum.Parse(typeof (IfcProcedureTypeEnum), value.EnumVal, true);
					return;
				case 7: 
					_userDefinedProcedureType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR1:	WR1 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.Decomposes | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR2:	WR2 : SIZEOF(QUERY(temp <* SELF\IfcObjectDefinition.IsDecomposedBy | NOT('IFC2X3.IFCRELNESTS' IN TYPEOF(temp)))) = 0;*/
		/*WR3:	WR3 : EXISTS(SELF\IfcRoot.Name);*/
		/*WR4:            ((ProcedureType = IfcProcedureTypeEnum.USERDEFINED) AND EXISTS(SELF\IfcProcedure.UserDefinedProcedureType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProcedure other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcProcedure
            var root = (@IfcProcedure)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcProcedure left, @IfcProcedure right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcProcedure left, @IfcProcedure right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcProcedure x, @IfcProcedure y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcProcedure obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
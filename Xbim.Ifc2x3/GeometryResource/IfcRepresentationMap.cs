// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRepresentationMap
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRepresentationMap : IPersistEntity
	{
		IfcAxis2Placement @MappingOrigin { get; }
		IIfcRepresentation @MappedRepresentation { get; }
		IEnumerable<IIfcMappedItem> @MapUsage {  get; }
		
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[IndexedClass]
	[ExpressType("IFCREPRESENTATIONMAP", 95)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRepresentationMap : INotifyPropertyChanged, IInstantiableEntity, IIfcRepresentationMap, IEqualityComparer<@IfcRepresentationMap>, IEquatable<@IfcRepresentationMap>
	{
		#region IIfcRepresentationMap explicit implementation
		IfcAxis2Placement IIfcRepresentationMap.MappingOrigin { get { return @MappingOrigin; } }	
		IIfcRepresentation IIfcRepresentationMap.MappedRepresentation { get { return @MappedRepresentation; } }	
		 
		IEnumerable<IIfcMappedItem> IIfcRepresentationMap.MapUsage {  get { return @MapUsage; } }
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentationMap(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement _mappingOrigin;
		private IfcRepresentation _mappedRepresentation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @MappingOrigin 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappingOrigin;
				((IPersistEntity)this).Activate(false);
				return _mappingOrigin;
			} 
			set
			{
				SetValue( v =>  _mappingOrigin = v, _mappingOrigin, value,  "MappingOrigin");
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcRepresentation @MappedRepresentation 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _mappedRepresentation;
				((IPersistEntity)this).Activate(false);
				return _mappedRepresentation;
			} 
			set
			{
				SetValue( v =>  _mappedRepresentation = v, _mappedRepresentation, value,  "MappedRepresentation");
			} 
		}	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcMappedItem> @MapUsage 
		{ 
			get 
			{
				return Model.Instances.Where<IfcMappedItem>(e => (e.MappingSource as IfcRepresentationMap) == this);
			} 
		}
		#endregion

		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_mappingOrigin = (IfcAxis2Placement)(value.EntityVal);
					return;
				case 1: 
					_mappedRepresentation = (IfcRepresentation)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentationMap other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRepresentationMap
            var root = (@IfcRepresentationMap)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRepresentationMap left, @IfcRepresentationMap right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRepresentationMap left, @IfcRepresentationMap right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRepresentationMap x, @IfcRepresentationMap y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRepresentationMap obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcObject : IIfcObject
	{
		Ifc4.MeasureResource.IfcLabel? IIfcObject.ObjectType 
		{ 
			get
			{
				if (!ObjectType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ObjectType.Value);
			} 
		}
		IEnumerable<IIfcRelDefinesByObject> IIfcObject.IsDeclaredBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByObject>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		IEnumerable<IIfcRelDefinesByObject> IIfcObject.Declares 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByObject>(e => (e.RelatingObject as IfcObject) == this);
			} 
		}
		IEnumerable<IIfcRelDefinesByType> IIfcObject.IsTypedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByType>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}
		IEnumerable<IIfcRelDefinesByProperties> IIfcObject.IsDefinedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDefinesByProperties>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this));
			} 
		}

	//## Custom code
	//##
	}
}
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
	public partial class @IfcRelAssociatesDocument : IIfcRelAssociatesDocument
	{
		Ifc4.ExternalReferenceResource.IfcDocumentSelect IIfcRelAssociatesDocument.RelatingDocument 
		{ 
			get
			{
				if (RelatingDocument == null) return null;
				var ifcdocumentreference = RelatingDocument as ExternalReferenceResource.IfcDocumentReference;
				if (ifcdocumentreference != null) 
					return ifcdocumentreference;
				var ifcdocumentinformation = RelatingDocument as ExternalReferenceResource.IfcDocumentInformation;
				if (ifcdocumentinformation != null) 
					return ifcdocumentinformation;
				return null;
			} 
		}

	//## Custom code
	//##
	}
}
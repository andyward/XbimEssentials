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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcPolyline : IIfcPolyline
	{
		IEnumerable<IIfcCartesianPoint> IIfcPolyline.Points 
		{ 
			get
			{
			foreach (var member in Points)
			{
				yield return member as IIfcCartesianPoint;
			}
			} 
		}

	//## Custom code
	//##
	}
}
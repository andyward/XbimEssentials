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
using Xbim.Ifc4.MeasureResource;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.UtilityResource
{
	public partial class @IfcTable : IIfcTable
	{
		Ifc4.MeasureResource.IfcLabel? IIfcTable.Name 
		{ 
			get
			{
				//## Handle return of Name for which no match was found
                if(string.IsNullOrWhiteSpace(Name)) 
                    return null; 
                else  
                    return new IfcLabel(Name);
				//##
			} 
		}
        IEnumerable<IIfcTableRow> IIfcTable.Rows
        {
            get
            {
                foreach (var member in Rows)
                {
                    yield return member as IIfcTableRow;
                }
            }
        }
        IEnumerable<IIfcTableColumn> IIfcTable.Columns 
		{ 
			get
			{
				//## Handle return of Columns for which no match was found
                return null;
				//##
			} 
		}

	//## Custom code
	//##
	}
}
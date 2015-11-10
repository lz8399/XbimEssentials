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
namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	public partial class @IfcPresentationLayerAssignment : IIfcPresentationLayerAssignment
	{
		Ifc4.MeasureResource.IfcLabel IIfcPresentationLayerAssignment.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcPresentationLayerAssignment.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
		}
		IEnumerable<IIfcLayeredItem> IIfcPresentationLayerAssignment.AssignedItems 
		{ 
			get
			{
				foreach (var member in AssignedItems)
				{
					var ifcrepresentationitem = member as GeometryResource.IfcRepresentationItem;
					if (ifcrepresentationitem != null) 
						yield return ifcrepresentationitem;
					var ifcrepresentation = member as RepresentationResource.IfcRepresentation;
					if (ifcrepresentation != null) 
						yield return ifcrepresentation;
				}
			} 
		}
		Ifc4.MeasureResource.IfcIdentifier? IIfcPresentationLayerAssignment.Identifier 
		{ 
			get
			{
				if (!Identifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Identifier.Value);
			} 
		}
	//## Custom code
	//##
	}
}
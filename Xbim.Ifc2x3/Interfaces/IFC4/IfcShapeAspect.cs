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
namespace Xbim.Ifc2x3.RepresentationResource
{
	public partial class @IfcShapeAspect : IIfcShapeAspect
	{
		IEnumerable<IIfcShapeModel> IIfcShapeAspect.ShapeRepresentations 
		{ 
			get
			{
				foreach (var member in ShapeRepresentations)
				{
					yield return member as IIfcShapeModel;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcShapeAspect.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcShapeAspect.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
		}
		bool? IIfcShapeAspect.ProductDefinitional 
		{ 
			get
			{
				return ProductDefinitional;
			} 
		}
		IIfcProductRepresentationSelect IIfcShapeAspect.PartOfProductDefinitionShape 
		{ 
			get
			{
				return PartOfProductDefinitionShape;
			} 
		}
	//## Custom code
	//##
	}
}
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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelSpaceBoundary : IIfcRelSpaceBoundary
	{
		IIfcSpaceBoundarySelect IIfcRelSpaceBoundary.RelatingSpace 
		{ 
			get
			{
				return RelatingSpace;
			} 
		}
		IIfcElement IIfcRelSpaceBoundary.RelatedBuildingElement 
		{ 
			get
			{
				return RelatedBuildingElement;
			} 
		}
		IIfcConnectionGeometry IIfcRelSpaceBoundary.ConnectionGeometry 
		{ 
			get
			{
				return ConnectionGeometry;
			} 
		}
		Ifc4.ProductExtension.IfcPhysicalOrVirtualEnum IIfcRelSpaceBoundary.PhysicalOrVirtualBoundary 
		{ 
			get
			{
				switch (PhysicalOrVirtualBoundary)
				{
					case IfcPhysicalOrVirtualEnum.PHYSICAL:
						return Ifc4.ProductExtension.IfcPhysicalOrVirtualEnum.PHYSICAL;
					
					case IfcPhysicalOrVirtualEnum.VIRTUAL:
						return Ifc4.ProductExtension.IfcPhysicalOrVirtualEnum.VIRTUAL;
					
					case IfcPhysicalOrVirtualEnum.NOTDEFINED:
						return Ifc4.ProductExtension.IfcPhysicalOrVirtualEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.ProductExtension.IfcInternalOrExternalEnum IIfcRelSpaceBoundary.InternalOrExternalBoundary 
		{ 
			get
			{
				switch (InternalOrExternalBoundary)
				{
					case IfcInternalOrExternalEnum.INTERNAL:
						return Ifc4.ProductExtension.IfcInternalOrExternalEnum.INTERNAL;
					
					case IfcInternalOrExternalEnum.EXTERNAL:
						return Ifc4.ProductExtension.IfcInternalOrExternalEnum.EXTERNAL;
					
					case IfcInternalOrExternalEnum.NOTDEFINED:
						return Ifc4.ProductExtension.IfcInternalOrExternalEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	//## Custom code
	//##
	}
}
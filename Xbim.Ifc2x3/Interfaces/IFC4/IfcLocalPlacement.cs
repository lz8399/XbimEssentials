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
namespace Xbim.Ifc2x3.GeometricConstraintResource
{
	public partial class @IfcLocalPlacement : IIfcLocalPlacement
	{
		IIfcObjectPlacement IIfcLocalPlacement.PlacementRelTo 
		{ 
			get
			{
				return PlacementRelTo;
			} 
		}
		IIfcAxis2Placement IIfcLocalPlacement.RelativePlacement 
		{ 
			get
			{
				if (RelativePlacement == null) return null;
				var ifcaxis2placement2d = RelativePlacement as GeometryResource.IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = RelativePlacement as GeometryResource.IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
		}
	//## Custom code
	//##
	}
}
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
	public partial class @IfcConnectionCurveGeometry : IIfcConnectionCurveGeometry
	{
		Xbim.Ifc4.GeometricConstraintResource.IfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatingElement 
		{ 
			get
			{
				if (CurveOnRelatingElement == null) return null;
				var ifcboundedcurve = CurveOnRelatingElement as Xbim.Ifc2x3.GeometryResource.IfcBoundedCurve;
				if (ifcboundedcurve != null) 
					return ifcboundedcurve;
				var ifcedgecurve = CurveOnRelatingElement as Xbim.Ifc2x3.TopologyResource.IfcEdgeCurve;
				if (ifcedgecurve != null) 
					return ifcedgecurve;
				return null;
			} 
		}
		Xbim.Ifc4.GeometricConstraintResource.IfcCurveOrEdgeCurve IIfcConnectionCurveGeometry.CurveOnRelatedElement 
		{ 
			get
			{
				if (CurveOnRelatedElement == null) return null;
				var ifcboundedcurve = CurveOnRelatedElement as Xbim.Ifc2x3.GeometryResource.IfcBoundedCurve;
				if (ifcboundedcurve != null) 
					return ifcboundedcurve;
				var ifcedgecurve = CurveOnRelatedElement as Xbim.Ifc2x3.TopologyResource.IfcEdgeCurve;
				if (ifcedgecurve != null) 
					return ifcedgecurve;
				return null;
			} 
		}
	}
}
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
namespace Xbim.Ifc2x3.GeometricModelResource
{
	public partial class @IfcGeometricSet : IIfcGeometricSet
	{
		IEnumerable<IIfcGeometricSetSelect> IIfcGeometricSet.Elements 
		{ 
			get
			{
				foreach (var member in Elements)
				{
					var ifcpoint = member as GeometryResource.IfcPoint;
					if (ifcpoint != null) 
						yield return ifcpoint;
					var ifccurve = member as GeometryResource.IfcCurve;
					if (ifccurve != null) 
						yield return ifccurve;
					var ifcsurface = member as GeometryResource.IfcSurface;
					if (ifcsurface != null) 
						yield return ifcsurface;
				}
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcGeometricSet.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}
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
	public partial class @IfcShellBasedSurfaceModel : IIfcShellBasedSurfaceModel
	{
		IEnumerable<Xbim.Ifc4.TopologyResource.IfcShell> IIfcShellBasedSurfaceModel.SbsmBoundary 
		{ 
			get
			{
			foreach (var member in SbsmBoundary)
			{
				var ifcclosedshell = member as TopologyResource.IfcClosedShell;
				if (ifcclosedshell != null) 
					yield return ifcclosedshell;
				var ifcopenshell = member as TopologyResource.IfcOpenShell;
				if (ifcopenshell != null) 
					yield return ifcopenshell;
			}
			} 
		}
	}
}
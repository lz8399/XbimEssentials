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
	public partial class @IfcLightSourceSpot : IIfcLightSourceSpot
	{
		IIfcDirection IIfcLightSourceSpot.Orientation 
		{ 
			get
			{
				return Orientation as IIfcDirection;
			} 
		}
		Ifc4.MeasureResource.IfcReal? IIfcLightSourceSpot.ConcentrationExponent 
		{ 
			get
			{
				if (ConcentrationExponent == null) return null;
				return new Ifc4.MeasureResource.IfcReal((double)ConcentrationExponent);
			} 
		}
		Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.SpreadAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)SpreadAngle);
			} 
		}
		Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure IIfcLightSourceSpot.BeamWidthAngle 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositivePlaneAngleMeasure((double)BeamWidthAngle);
			} 
		}
	}
}
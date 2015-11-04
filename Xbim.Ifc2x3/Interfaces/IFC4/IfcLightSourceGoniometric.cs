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
	public partial class @IfcLightSourceGoniometric : IIfcLightSourceGoniometric
	{
		IIfcAxis2Placement3D IIfcLightSourceGoniometric.Position 
		{ 
			get
			{
				return Position as IIfcAxis2Placement3D;
			} 
		}
		IIfcColourRgb IIfcLightSourceGoniometric.ColourAppearance 
		{ 
			get
			{
				return ColourAppearance as IIfcColourRgb;
			} 
		}
		Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure IIfcLightSourceGoniometric.ColourTemperature 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure((double)ColourTemperature);
			} 
		}
		Ifc4.MeasureResource.IfcLuminousFluxMeasure IIfcLightSourceGoniometric.LuminousFlux 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLuminousFluxMeasure((double)LuminousFlux);
			} 
		}
		Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum IIfcLightSourceGoniometric.LightEmissionSource 
		{ 
			get
			{
				switch (LightEmissionSource)
				{
					case IfcLightEmissionSourceEnum.COMPACTFLUORESCENT:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.COMPACTFLUORESCENT;
					
					case IfcLightEmissionSourceEnum.FLUORESCENT:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.FLUORESCENT;
					
					case IfcLightEmissionSourceEnum.HIGHPRESSUREMERCURY:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.HIGHPRESSUREMERCURY;
					
					case IfcLightEmissionSourceEnum.HIGHPRESSURESODIUM:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.HIGHPRESSURESODIUM;
					
					case IfcLightEmissionSourceEnum.LIGHTEMITTINGDIODE:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.LIGHTEMITTINGDIODE;
					
					case IfcLightEmissionSourceEnum.LOWPRESSURESODIUM:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.LOWPRESSURESODIUM;
					
					case IfcLightEmissionSourceEnum.LOWVOLTAGEHALOGEN:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.LOWVOLTAGEHALOGEN;
					
					case IfcLightEmissionSourceEnum.MAINVOLTAGEHALOGEN:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.MAINVOLTAGEHALOGEN;
					
					case IfcLightEmissionSourceEnum.METALHALIDE:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.METALHALIDE;
					
					case IfcLightEmissionSourceEnum.TUNGSTENFILAMENT:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.TUNGSTENFILAMENT;
					
					case IfcLightEmissionSourceEnum.NOTDEFINED:
						return Ifc4.PresentationOrganizationResource.IfcLightEmissionSourceEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.PresentationOrganizationResource.IfcLightDistributionDataSourceSelect IIfcLightSourceGoniometric.LightDistributionDataSource 
		{ 
			get
			{
				if (LightDistributionDataSource == null) return null;
				var ifcexternalreference = LightDistributionDataSource as ExternalReferenceResource.IfcExternalReference;
				if (ifcexternalreference != null) 
					return ifcexternalreference;
				var ifclightintensitydistribution = LightDistributionDataSource as IfcLightIntensityDistribution;
				if (ifclightintensitydistribution != null) 
					return ifclightintensitydistribution;
				return null;
			} 
		}
	}
}
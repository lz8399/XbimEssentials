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
namespace Xbim.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialLayerSetUsage : IIfcMaterialLayerSetUsage
	{
		IIfcMaterialLayerSet IIfcMaterialLayerSetUsage.ForLayerSet 
		{ 
			get
			{
				return ForLayerSet as IIfcMaterialLayerSet;
			} 
		}
		Ifc4.MaterialResource.IfcLayerSetDirectionEnum IIfcMaterialLayerSetUsage.LayerSetDirection 
		{ 
			get
			{
				switch (LayerSetDirection)
				{
					case IfcLayerSetDirectionEnum.AXIS1:
						return Ifc4.MaterialResource.IfcLayerSetDirectionEnum.AXIS1;
					
					case IfcLayerSetDirectionEnum.AXIS2:
						return Ifc4.MaterialResource.IfcLayerSetDirectionEnum.AXIS2;
					
					case IfcLayerSetDirectionEnum.AXIS3:
						return Ifc4.MaterialResource.IfcLayerSetDirectionEnum.AXIS3;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MaterialResource.IfcDirectionSenseEnum IIfcMaterialLayerSetUsage.DirectionSense 
		{ 
			get
			{
				switch (DirectionSense)
				{
					case IfcDirectionSenseEnum.POSITIVE:
						return Ifc4.MaterialResource.IfcDirectionSenseEnum.POSITIVE;
					
					case IfcDirectionSenseEnum.NEGATIVE:
						return Ifc4.MaterialResource.IfcDirectionSenseEnum.NEGATIVE;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure IIfcMaterialLayerSetUsage.OffsetFromReferenceLine 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure((double)OffsetFromReferenceLine);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMaterialLayerSetUsage.ReferenceExtent 
		{ 
			get
			{
				//## Handle return of ReferenceExtent for which no match was found
				//TODO: Handle return of ReferenceExtent for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialUsageDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterialLayerSetUsage) == this);
			} 
		}
	}
}
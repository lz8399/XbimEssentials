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
namespace Xbim.Ifc2x3.HVACDomain
{
	public partial class @IfcDuctSegmentType : IIfcDuctSegmentType
	{
		Ifc4.HvacDomain.IfcDuctSegmentTypeEnum IIfcDuctSegmentType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcDuctSegmentTypeEnum.RIGIDSEGMENT:
						return Ifc4.HvacDomain.IfcDuctSegmentTypeEnum.RIGIDSEGMENT;
					
					case IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT:
						return Ifc4.HvacDomain.IfcDuctSegmentTypeEnum.FLEXIBLESEGMENT;
					
					case IfcDuctSegmentTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcDuctSegmentTypeEnum.USERDEFINED;
					
					case IfcDuctSegmentTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcDuctSegmentTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}
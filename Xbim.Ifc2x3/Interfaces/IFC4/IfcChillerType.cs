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
	public partial class @IfcChillerType : IIfcChillerType
	{
		Ifc4.HvacDomain.IfcChillerTypeEnum IIfcChillerType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcChillerTypeEnum.AIRCOOLED:
						return Ifc4.HvacDomain.IfcChillerTypeEnum.AIRCOOLED;
					
					case IfcChillerTypeEnum.WATERCOOLED:
						return Ifc4.HvacDomain.IfcChillerTypeEnum.WATERCOOLED;
					
					case IfcChillerTypeEnum.HEATRECOVERY:
						return Ifc4.HvacDomain.IfcChillerTypeEnum.HEATRECOVERY;
					
					case IfcChillerTypeEnum.USERDEFINED:
						return Ifc4.HvacDomain.IfcChillerTypeEnum.USERDEFINED;
					
					case IfcChillerTypeEnum.NOTDEFINED:
						return Ifc4.HvacDomain.IfcChillerTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}
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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcRampFlightType : IIfcRampFlightType
	{
		Ifc4.SharedBldgElements.IfcRampFlightTypeEnum IIfcRampFlightType.PredefinedType 
		{ 
			get
			{
				switch (PredefinedType)
				{
					case IfcRampFlightTypeEnum.STRAIGHT:
						return Ifc4.SharedBldgElements.IfcRampFlightTypeEnum.STRAIGHT;
					
					case IfcRampFlightTypeEnum.SPIRAL:
						return Ifc4.SharedBldgElements.IfcRampFlightTypeEnum.SPIRAL;
					
					case IfcRampFlightTypeEnum.USERDEFINED:
						return Ifc4.SharedBldgElements.IfcRampFlightTypeEnum.USERDEFINED;
					
					case IfcRampFlightTypeEnum.NOTDEFINED:
						return Ifc4.SharedBldgElements.IfcRampFlightTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
	}
}
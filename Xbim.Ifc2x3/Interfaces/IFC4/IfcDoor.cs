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
	public partial class @IfcDoor : IIfcDoor
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoor.OverallHeight 
		{ 
			get
			{
				if (OverallHeight == null) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)OverallHeight);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoor.OverallWidth 
		{ 
			get
			{
				if (OverallWidth == null) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)OverallWidth);
			} 
		}
		Ifc4.SharedBldgElements.IfcDoorTypeEnum? IIfcDoor.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.SharedBldgElements.IfcDoorTypeOperationEnum? IIfcDoor.OperationType 
		{ 
			get
			{
				//## Handle return of OperationType for which no match was found
				//TODO: Handle return of OperationType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcDoor.UserDefinedOperationType 
		{ 
			get
			{
				//## Handle return of UserDefinedOperationType for which no match was found
				//TODO: Handle return of UserDefinedOperationType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}
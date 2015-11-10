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
namespace Xbim.Ifc2x3.TimeSeriesResource
{
	public partial class @IfcTimeSeries : IIfcTimeSeries
	{
		Ifc4.MeasureResource.IfcLabel IIfcTimeSeries.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcTimeSeries.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime IIfcTimeSeries.StartTime 
		{ 
			get
			{
				//## Handle return of StartTime for which no match was found
                return new Ifc4.DateTimeResource.IfcDateTime(StartTime.ToISODateTimeString());
				//##
			} 
		}
		Ifc4.DateTimeResource.IfcDateTime IIfcTimeSeries.EndTime 
		{ 
			get
			{
				//## Handle return of EndTime for which no match was found
                return new Ifc4.DateTimeResource.IfcDateTime(EndTime.ToISODateTimeString());
				//##
			} 
		}
		Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum IIfcTimeSeries.TimeSeriesDataType 
		{ 
			get
			{
				switch (TimeSeriesDataType)
				{
					case IfcTimeSeriesDataTypeEnum.CONTINUOUS:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.CONTINUOUS;
					
					case IfcTimeSeriesDataTypeEnum.DISCRETE:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.DISCRETE;
					
					case IfcTimeSeriesDataTypeEnum.DISCRETEBINARY:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.DISCRETEBINARY;
					
					case IfcTimeSeriesDataTypeEnum.PIECEWISEBINARY:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.PIECEWISEBINARY;
					
					case IfcTimeSeriesDataTypeEnum.PIECEWISECONSTANT:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.PIECEWISECONSTANT;
					
					case IfcTimeSeriesDataTypeEnum.PIECEWISECONTINUOUS:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.PIECEWISECONTINUOUS;
					
					case IfcTimeSeriesDataTypeEnum.NOTDEFINED:
						return Ifc4.DateTimeResource.IfcTimeSeriesDataTypeEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.DateTimeResource.IfcDataOriginEnum IIfcTimeSeries.DataOrigin 
		{ 
			get
			{
				switch (DataOrigin)
				{
					case IfcDataOriginEnum.MEASURED:
						return Ifc4.DateTimeResource.IfcDataOriginEnum.MEASURED;
					
					case IfcDataOriginEnum.PREDICTED:
						return Ifc4.DateTimeResource.IfcDataOriginEnum.PREDICTED;
					
					case IfcDataOriginEnum.SIMULATED:
						return Ifc4.DateTimeResource.IfcDataOriginEnum.SIMULATED;
					
					case IfcDataOriginEnum.USERDEFINED:
						return Ifc4.DateTimeResource.IfcDataOriginEnum.USERDEFINED;
					
					case IfcDataOriginEnum.NOTDEFINED:
						return Ifc4.DateTimeResource.IfcDataOriginEnum.NOTDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcTimeSeries.UserDefinedDataOrigin 
		{ 
			get
			{
				if (!UserDefinedDataOrigin.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedDataOrigin.Value);
			} 
		}
		IIfcUnit IIfcTimeSeries.Unit 
		{ 
			get
			{
				if (Unit == null) return null;
				var ifcderivedunit = Unit as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = Unit as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = Unit as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcTimeSeries.HasExternalReference 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	//## Custom code
	//##
	}
}
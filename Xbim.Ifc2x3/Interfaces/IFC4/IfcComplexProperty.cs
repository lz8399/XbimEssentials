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
namespace Xbim.Ifc2x3.PropertyResource
{
	public partial class @IfcComplexProperty : IIfcComplexProperty
	{
		Ifc4.MeasureResource.IfcIdentifier IIfcComplexProperty.UsageName 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier((string)UsageName);
			} 
		}
		IEnumerable<IIfcProperty> IIfcComplexProperty.HasProperties 
		{ 
			get
			{
			foreach (var member in HasProperties)
			{
				yield return member as IIfcProperty;
			}
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this));
			} 
		}
	}
}
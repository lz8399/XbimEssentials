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
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcClassificationReference : IIfcClassificationReference
	{
		IIfcClassificationReferenceSelect IIfcClassificationReference.ReferencedSource 
		{ 
			get
			{
				return ReferencedSource;
			} 
		}
		Ifc4.MeasureResource.IfcText? IIfcClassificationReference.Description 
		{ 
			get
			{
				//## Handle return of Description for which no match was found
			    return null;
			    //##
			} 
		}
		Ifc4.MeasureResource.IfcIdentifier? IIfcClassificationReference.Sort 
		{ 
			get
			{
				//## Handle return of Sort for which no match was found
			    return null;
			    //##
			} 
		}
		IEnumerable<IIfcRelAssociatesClassification> IIfcClassificationReference.ClassificationRefForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesClassification>(e => (e.RelatingClassification as IfcClassificationReference) == this);
			} 
		}
		IEnumerable<IIfcClassificationReference> IIfcClassificationReference.HasReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcClassificationReference>(e => (e.ReferencedSource as IfcClassificationReference) == this);
			} 
		}
	//## Custom code
	//##
	}
}
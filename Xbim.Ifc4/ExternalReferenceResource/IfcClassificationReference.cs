// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.ExternalReferenceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassificationReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassificationReference : IIfcExternalReference, IfcClassificationReferenceSelect, IfcClassificationSelect
	{
		IIfcClassificationReferenceSelect @ReferencedSource { get; }
		IfcText? @Description { get; }
		IfcIdentifier? @Sort { get; }
		IEnumerable<IIfcRelAssociatesClassification> @ClassificationRefForObjects {  get; }
		IEnumerable<IIfcClassificationReference> @HasReferences {  get; }
	
	}
}

namespace Xbim.Ifc4.ExternalReferenceResource
{
	[IndexedClass]
	[ExpressType("IFCCLASSIFICATIONREFERENCE", 486)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationReference : IfcExternalReference, IInstantiableEntity, IIfcClassificationReference, IEqualityComparer<@IfcClassificationReference>, IEquatable<@IfcClassificationReference>
	{
		#region IIfcClassificationReference explicit implementation
		IIfcClassificationReferenceSelect IIfcClassificationReference.ReferencedSource { get { return @ReferencedSource; } }	
		IfcText? IIfcClassificationReference.Description { get { return @Description; } }	
		IfcIdentifier? IIfcClassificationReference.Sort { get { return @Sort; } }	
		 
		IEnumerable<IIfcRelAssociatesClassification> IIfcClassificationReference.ClassificationRefForObjects {  get { return @ClassificationRefForObjects; } }
		IEnumerable<IIfcClassificationReference> IIfcClassificationReference.HasReferences {  get { return @HasReferences; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationReference(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcClassificationReferenceSelect _referencedSource;
		private IfcText? _description;
		private IfcIdentifier? _sort;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcClassificationReferenceSelect @ReferencedSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _referencedSource;
				((IPersistEntity)this).Activate(false);
				return _referencedSource;
			} 
			set
			{
				SetValue( v =>  _referencedSource = v, _referencedSource, value,  "ReferencedSource");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcIdentifier? @Sort 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _sort;
				((IPersistEntity)this).Activate(false);
				return _sort;
			} 
			set
			{
				SetValue( v =>  _sort = v, _sort, value,  "Sort");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssociatesClassification> @ClassificationRefForObjects 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesClassification>(e => (e.RelatingClassification as IfcClassificationReference) == this);
			} 
		}
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcClassificationReference> @HasReferences 
		{ 
			get 
			{
				return Model.Instances.Where<IfcClassificationReference>(e => (e.ReferencedSource as IfcClassificationReference) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_referencedSource = (IfcClassificationReferenceSelect)(value.EntityVal);
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_sort = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassificationReference other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcClassificationReference
            var root = (@IfcClassificationReference)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcClassificationReference left, @IfcClassificationReference right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcClassificationReference left, @IfcClassificationReference right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcClassificationReference x, @IfcClassificationReference y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcClassificationReference obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}
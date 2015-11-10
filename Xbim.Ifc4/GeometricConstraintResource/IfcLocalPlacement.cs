// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.GeometricConstraintResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLocalPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLocalPlacement : IIfcObjectPlacement
	{
		IIfcObjectPlacement @PlacementRelTo { get; }
		IIfcAxis2Placement @RelativePlacement { get; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCLOCALPLACEMENT", 736)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLocalPlacement : IfcObjectPlacement, IInstantiableEntity, IIfcLocalPlacement, IEqualityComparer<@IfcLocalPlacement>, IEquatable<@IfcLocalPlacement>
	{
		#region IIfcLocalPlacement explicit implementation
		IIfcObjectPlacement IIfcLocalPlacement.PlacementRelTo { get { return @PlacementRelTo; } }	
		IIfcAxis2Placement IIfcLocalPlacement.RelativePlacement { get { return @RelativePlacement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLocalPlacement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcObjectPlacement _placementRelTo;
		private IfcAxis2Placement _relativePlacement;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObjectPlacement @PlacementRelTo 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _placementRelTo;
				((IPersistEntity)this).Activate(false);
				return _placementRelTo;
			} 
			set
			{
				SetValue( v =>  _placementRelTo = v, _placementRelTo, value,  "PlacementRelTo");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement @RelativePlacement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relativePlacement;
				((IPersistEntity)this).Activate(false);
				return _relativePlacement;
			} 
			set
			{
				SetValue( v =>  _relativePlacement = v, _relativePlacement, value,  "RelativePlacement");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_placementRelTo = (IfcObjectPlacement)(value.EntityVal);
					return;
				case 1: 
					_relativePlacement = (IfcAxis2Placement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*WR21:	WR21 : IfcCorrectLocalPlacement(RelativePlacement, PlacementRelTo);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLocalPlacement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLocalPlacement
            var root = (@IfcLocalPlacement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLocalPlacement left, @IfcLocalPlacement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLocalPlacement left, @IfcLocalPlacement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLocalPlacement x, @IfcLocalPlacement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLocalPlacement obj)
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
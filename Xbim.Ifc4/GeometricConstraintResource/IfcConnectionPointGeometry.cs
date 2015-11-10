// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

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
    /// Readonly interface for IfcConnectionPointGeometry
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcConnectionPointGeometry : IIfcConnectionGeometry
	{
		IIfcPointOrVertexPoint @PointOnRelatingElement { get; }
		IIfcPointOrVertexPoint @PointOnRelatedElement { get; }
	
	}
}

namespace Xbim.Ifc4.GeometricConstraintResource
{
	[IndexedClass]
	[ExpressType("IFCCONNECTIONPOINTGEOMETRY", 513)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcConnectionPointGeometry : IfcConnectionGeometry, IInstantiableEntity, IIfcConnectionPointGeometry, IEqualityComparer<@IfcConnectionPointGeometry>, IEquatable<@IfcConnectionPointGeometry>
	{
		#region IIfcConnectionPointGeometry explicit implementation
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatingElement { get { return @PointOnRelatingElement; } }	
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatedElement { get { return @PointOnRelatedElement; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcConnectionPointGeometry(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcPointOrVertexPoint _pointOnRelatingElement;
		private IfcPointOrVertexPoint _pointOnRelatedElement;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPointOrVertexPoint @PointOnRelatingElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointOnRelatingElement;
				((IPersistEntity)this).Activate(false);
				return _pointOnRelatingElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatingElement = v, _pointOnRelatingElement, value,  "PointOnRelatingElement");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcPointOrVertexPoint @PointOnRelatedElement 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _pointOnRelatedElement;
				((IPersistEntity)this).Activate(false);
				return _pointOnRelatedElement;
			} 
			set
			{
				SetValue( v =>  _pointOnRelatedElement = v, _pointOnRelatedElement, value,  "PointOnRelatedElement");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_pointOnRelatingElement = (IfcPointOrVertexPoint)(value.EntityVal);
					return;
				case 1: 
					_pointOnRelatedElement = (IfcPointOrVertexPoint)(value.EntityVal);
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
        public bool Equals(@IfcConnectionPointGeometry other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcConnectionPointGeometry
            var root = (@IfcConnectionPointGeometry)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcConnectionPointGeometry left, @IfcConnectionPointGeometry right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcConnectionPointGeometry left, @IfcConnectionPointGeometry right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcConnectionPointGeometry x, @IfcConnectionPointGeometry y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcConnectionPointGeometry obj)
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
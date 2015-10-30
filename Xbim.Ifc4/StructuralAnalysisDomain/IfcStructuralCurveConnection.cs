// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using Xbim.Ifc4.StructuralLoadResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.StructuralAnalysisDomain;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralCurveConnection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralCurveConnection : IIfcStructuralConnection
	{
		IIfcDirection @Axis { get; }
		
	}
}

namespace Xbim.Ifc4.StructuralAnalysisDomain
{
	[ExpressType("IFCSTRUCTURALCURVECONNECTION", 1016)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralCurveConnection : IfcStructuralConnection, IInstantiableEntity, IIfcStructuralCurveConnection, IEqualityComparer<@IfcStructuralCurveConnection>, IEquatable<@IfcStructuralCurveConnection>
	{
		#region IIfcStructuralCurveConnection explicit implementation
		IIfcDirection IIfcStructuralCurveConnection.Axis { get { return @Axis; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralCurveConnection(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcDirection _axis;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcDirection @Axis 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _axis;
				((IPersistEntity)this).Activate(false);
				return _axis;
			} 
			set
			{
				SetValue( v =>  _axis = v, _axis, value,  "Axis");
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
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
					_axis = (IfcDirection)(value.EntityVal);
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
        public bool Equals(@IfcStructuralCurveConnection other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcStructuralCurveConnection
            var root = (@IfcStructuralCurveConnection)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcStructuralCurveConnection left, @IfcStructuralCurveConnection right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcStructuralCurveConnection left, @IfcStructuralCurveConnection right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcStructuralCurveConnection x, @IfcStructuralCurveConnection y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcStructuralCurveConnection obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}
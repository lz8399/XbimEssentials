// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.PresentationAppearanceResource;
using Xbim.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationOrganizationResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightSourceGoniometric
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightSourceGoniometric : IIfcLightSource
	{
		IIfcAxis2Placement3D @Position { get; }
		IIfcColourRgb @ColourAppearance { get; }
		IfcThermodynamicTemperatureMeasure @ColourTemperature { get; }
		IfcLuminousFluxMeasure @LuminousFlux { get; }
		IfcLightEmissionSourceEnum @LightEmissionSource { get; }
		IIfcLightDistributionDataSourceSelect @LightDistributionDataSource { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationOrganizationResource
{
	[ExpressType("IFCLIGHTSOURCEGONIOMETRIC", 732)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceGoniometric : IfcLightSource, IInstantiableEntity, IIfcLightSourceGoniometric, IEqualityComparer<@IfcLightSourceGoniometric>, IEquatable<@IfcLightSourceGoniometric>
	{
		#region IIfcLightSourceGoniometric explicit implementation
		IIfcAxis2Placement3D IIfcLightSourceGoniometric.Position { get { return @Position; } }	
		IIfcColourRgb IIfcLightSourceGoniometric.ColourAppearance { get { return @ColourAppearance; } }	
		IfcThermodynamicTemperatureMeasure IIfcLightSourceGoniometric.ColourTemperature { get { return @ColourTemperature; } }	
		IfcLuminousFluxMeasure IIfcLightSourceGoniometric.LuminousFlux { get { return @LuminousFlux; } }	
		IfcLightEmissionSourceEnum IIfcLightSourceGoniometric.LightEmissionSource { get { return @LightEmissionSource; } }	
		IIfcLightDistributionDataSourceSelect IIfcLightSourceGoniometric.LightDistributionDataSource { get { return @LightDistributionDataSource; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceGoniometric(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		private IfcColourRgb _colourAppearance;
		private IfcThermodynamicTemperatureMeasure _colourTemperature;
		private IfcLuminousFluxMeasure _luminousFlux;
		private IfcLightEmissionSourceEnum _lightEmissionSource;
		private IfcLightDistributionDataSourceSelect _lightDistributionDataSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _position;
				((IPersistEntity)this).Activate(false);
				return _position;
			} 
			set
			{
				SetValue( v =>  _position = v, _position, value,  "Position");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColourRgb @ColourAppearance 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colourAppearance;
				((IPersistEntity)this).Activate(false);
				return _colourAppearance;
			} 
			set
			{
				SetValue( v =>  _colourAppearance = v, _colourAppearance, value,  "ColourAppearance");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcThermodynamicTemperatureMeasure @ColourTemperature 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colourTemperature;
				((IPersistEntity)this).Activate(false);
				return _colourTemperature;
			} 
			set
			{
				SetValue( v =>  _colourTemperature = v, _colourTemperature, value,  "ColourTemperature");
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLuminousFluxMeasure @LuminousFlux 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _luminousFlux;
				((IPersistEntity)this).Activate(false);
				return _luminousFlux;
			} 
			set
			{
				SetValue( v =>  _luminousFlux = v, _luminousFlux, value,  "LuminousFlux");
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcLightEmissionSourceEnum @LightEmissionSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lightEmissionSource;
				((IPersistEntity)this).Activate(false);
				return _lightEmissionSource;
			} 
			set
			{
				SetValue( v =>  _lightEmissionSource = v, _lightEmissionSource, value,  "LightEmissionSource");
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcLightDistributionDataSourceSelect @LightDistributionDataSource 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lightDistributionDataSource;
				((IPersistEntity)this).Activate(false);
				return _lightDistributionDataSource;
			} 
			set
			{
				SetValue( v =>  _lightDistributionDataSource = v, _lightDistributionDataSource, value,  "LightDistributionDataSource");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 5: 
					_colourAppearance = (IfcColourRgb)(value.EntityVal);
					return;
				case 6: 
					_colourTemperature = value.RealVal;
					return;
				case 7: 
					_luminousFlux = value.RealVal;
					return;
				case 8: 
                    _lightEmissionSource = (IfcLightEmissionSourceEnum) System.Enum.Parse(typeof (IfcLightEmissionSourceEnum), value.EnumVal, true);
					return;
				case 9: 
					_lightDistributionDataSource = (IfcLightDistributionDataSourceSelect)(value.EntityVal);
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
        public bool Equals(@IfcLightSourceGoniometric other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcLightSourceGoniometric
            var root = (@IfcLightSourceGoniometric)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcLightSourceGoniometric left, @IfcLightSourceGoniometric right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcLightSourceGoniometric left, @IfcLightSourceGoniometric right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcLightSourceGoniometric x, @IfcLightSourceGoniometric y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcLightSourceGoniometric obj)
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
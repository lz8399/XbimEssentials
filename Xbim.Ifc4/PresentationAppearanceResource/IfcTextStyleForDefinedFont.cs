// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextStyleForDefinedFont
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextStyleForDefinedFont : IIfcPresentationItem
	{
		IIfcColour @Colour { get; }
		IIfcColour @BackgroundColour { get; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTSTYLEFORDEFINEDFONT", 1096)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleForDefinedFont : IfcPresentationItem, IInstantiableEntity, IIfcTextStyleForDefinedFont, IEqualityComparer<@IfcTextStyleForDefinedFont>, IEquatable<@IfcTextStyleForDefinedFont>
	{
		#region IIfcTextStyleForDefinedFont explicit implementation
		IIfcColour IIfcTextStyleForDefinedFont.Colour { get { return @Colour; } }	
		IIfcColour IIfcTextStyleForDefinedFont.BackgroundColour { get { return @BackgroundColour; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleForDefinedFont(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcColour _colour;
		private IfcColour _backgroundColour;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColour @Colour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _colour;
				((IPersistEntity)this).Activate(false);
				return _colour;
			} 
			set
			{
				SetValue( v =>  _colour = v, _colour, value,  "Colour");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcColour @BackgroundColour 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _backgroundColour;
				((IPersistEntity)this).Activate(false);
				return _backgroundColour;
			} 
			set
			{
				SetValue( v =>  _backgroundColour = v, _backgroundColour, value,  "BackgroundColour");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_colour = (IfcColour)(value.EntityVal);
					return;
				case 1: 
					_backgroundColour = (IfcColour)(value.EntityVal);
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
        public bool Equals(@IfcTextStyleForDefinedFont other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextStyleForDefinedFont
            var root = (@IfcTextStyleForDefinedFont)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextStyleForDefinedFont left, @IfcTextStyleForDefinedFont right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextStyleForDefinedFont left, @IfcTextStyleForDefinedFont right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextStyleForDefinedFont x, @IfcTextStyleForDefinedFont y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextStyleForDefinedFont obj)
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
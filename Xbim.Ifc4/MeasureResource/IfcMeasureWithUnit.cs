// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.CostResource;
using Xbim.Ifc4.ConstraintResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MeasureResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMeasureWithUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMeasureWithUnit : IPersistEntity, IfcAppliedValueSelect, IfcMetricValueSelect
	{
		IIfcValue @ValueComponent { get; }
		IIfcUnit @UnitComponent { get; }
	
	}
}

namespace Xbim.Ifc4.MeasureResource
{
	[ExpressType("IFCMEASUREWITHUNIT", 760)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMeasureWithUnit : INotifyPropertyChanged, IInstantiableEntity, IIfcMeasureWithUnit, IEqualityComparer<@IfcMeasureWithUnit>, IEquatable<@IfcMeasureWithUnit>
	{
		#region IIfcMeasureWithUnit explicit implementation
		IIfcValue IIfcMeasureWithUnit.ValueComponent { get { return @ValueComponent; } }	
		IIfcUnit IIfcMeasureWithUnit.UnitComponent { get { return @UnitComponent; } }	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMeasureWithUnit(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcValue _valueComponent;
		private IfcUnit _unitComponent;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcValue @ValueComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _valueComponent;
				((IPersistEntity)this).Activate(false);
				return _valueComponent;
			} 
			set
			{
				SetValue( v =>  _valueComponent = v, _valueComponent, value,  "ValueComponent");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcUnit @UnitComponent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unitComponent;
				((IPersistEntity)this).Activate(false);
				return _unitComponent;
			} 
			set
			{
				SetValue( v =>  _unitComponent = v, _unitComponent, value,  "UnitComponent");
			} 
		}	
		#endregion




		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_valueComponent = (IfcValue)(value.EntityVal);
					return;
				case 1: 
					_unitComponent = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMeasureWithUnit other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMeasureWithUnit
            var root = (@IfcMeasureWithUnit)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMeasureWithUnit left, @IfcMeasureWithUnit right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMeasureWithUnit left, @IfcMeasureWithUnit right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMeasureWithUnit x, @IfcMeasureWithUnit y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMeasureWithUnit obj)
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
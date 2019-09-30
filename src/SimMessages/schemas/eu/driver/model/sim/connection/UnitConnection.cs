// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.connection
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class UnitConnection : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""UnitConnection"",""namespace"":""eu.driver.model.sim.connection"",""fields"":[{""name"":""guid"",""doc"":""Globally unique identifier for this entity"",""type"":""string""},{""name"":""owner"",""doc"":""Identifier of the simulator currently responsible for this entity"",""type"":""string""},{""name"":""mainUnit"",""doc"":""GUID of the unit representing the main (parent) unit"",""type"":""string""},{""name"":""subUnit"",""doc"":""GUID of the unit representing the sub (child) unit"",""type"":""string""}]}");
		/// <summary>
		/// Globally unique identifier for this entity
		/// </summary>
		private string _guid;
		/// <summary>
		/// Identifier of the simulator currently responsible for this entity
		/// </summary>
		private string _owner;
		/// <summary>
		/// GUID of the unit representing the main (parent) unit
		/// </summary>
		private string _mainUnit;
		/// <summary>
		/// GUID of the unit representing the sub (child) unit
		/// </summary>
		private string _subUnit;
		public virtual Schema Schema
		{
			get
			{
				return UnitConnection._SCHEMA;
			}
		}
		/// <summary>
		/// Globally unique identifier for this entity
		/// </summary>
		public string guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				this._guid = value;
			}
		}
		/// <summary>
		/// Identifier of the simulator currently responsible for this entity
		/// </summary>
		public string owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
			}
		}
		/// <summary>
		/// GUID of the unit representing the main (parent) unit
		/// </summary>
		public string mainUnit
		{
			get
			{
				return this._mainUnit;
			}
			set
			{
				this._mainUnit = value;
			}
		}
		/// <summary>
		/// GUID of the unit representing the sub (child) unit
		/// </summary>
		public string subUnit
		{
			get
			{
				return this._subUnit;
			}
			set
			{
				this._subUnit = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.guid;
			case 1: return this.owner;
			case 2: return this.mainUnit;
			case 3: return this.subUnit;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.guid = (System.String)fieldValue; break;
			case 1: this.owner = (System.String)fieldValue; break;
			case 2: this.mainUnit = (System.String)fieldValue; break;
			case 3: this.subUnit = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

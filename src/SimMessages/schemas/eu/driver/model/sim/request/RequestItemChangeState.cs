// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.request
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RequestItemChangeState : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""RequestItemChangeState"",""namespace"":""eu.driver.model.sim.request"",""fields"":[{""name"":""guid"",""doc"":""Globally unique identifier for this request"",""type"":""string""},{""name"":""owner"",""doc"":""Identifier of the simulator currently responsible for this request"",""type"":""string""},{""name"":""item"",""doc"":""Globally unique identifier for the item that should change its state"",""type"":""string""},{""name"":""state"",""doc"":""Name of the state to change to"",""type"":{""type"":""enum"",""name"":""States"",""namespace"":""eu.driver.model.sim.request"",""symbols"":[""IDLE"",""FRIGHTENED""]}}]}");
		/// <summary>
		/// Globally unique identifier for this request
		/// </summary>
		private string _guid;
		/// <summary>
		/// Identifier of the simulator currently responsible for this request
		/// </summary>
		private string _owner;
		/// <summary>
		/// Globally unique identifier for the item that should change its state
		/// </summary>
		private string _item;
		/// <summary>
		/// Name of the state to change to
		/// </summary>
		private eu.driver.model.sim.request.States _state;
		public virtual Schema Schema
		{
			get
			{
				return RequestItemChangeState._SCHEMA;
			}
		}
		/// <summary>
		/// Globally unique identifier for this request
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
		/// Identifier of the simulator currently responsible for this request
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
		/// Globally unique identifier for the item that should change its state
		/// </summary>
		public string item
		{
			get
			{
				return this._item;
			}
			set
			{
				this._item = value;
			}
		}
		/// <summary>
		/// Name of the state to change to
		/// </summary>
		public eu.driver.model.sim.request.States state
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.guid;
			case 1: return this.owner;
			case 2: return this.item;
			case 3: return this.state;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.guid = (System.String)fieldValue; break;
			case 1: this.owner = (System.String)fieldValue; break;
			case 2: this.item = (System.String)fieldValue; break;
			case 3: this.state = (eu.driver.model.sim.request.States)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.system
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class TopicInvite : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""TopicInvite"",""namespace"":""eu.driver.model.system"",""fields"":[{""name"":""id"",""doc"":""Client id"",""type"":""string""},{""name"":""topicName"",""doc"":""The name of the Topic to which the adaptor (client) is invited to join."",""type"":""string""},{""name"":""subscribeAllowed"",""doc"":""Indicates if the client is allowed to connect as subscriber."",""type"":""boolean""},{""name"":""publishAllowed"",""doc"":""Indicates if the client is allowed to connect as subscriber."",""type"":""boolean""}]}");
		/// <summary>
		/// Client id
		/// </summary>
		private string _id;
		/// <summary>
		/// The name of the Topic to which the adaptor (client) is invited to join.
		/// </summary>
		private string _topicName;
		/// <summary>
		/// Indicates if the client is allowed to connect as subscriber.
		/// </summary>
		private bool _subscribeAllowed;
		/// <summary>
		/// Indicates if the client is allowed to connect as subscriber.
		/// </summary>
		private bool _publishAllowed;
		public virtual Schema Schema
		{
			get
			{
				return TopicInvite._SCHEMA;
			}
		}
		/// <summary>
		/// Client id
		/// </summary>
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		/// <summary>
		/// The name of the Topic to which the adaptor (client) is invited to join.
		/// </summary>
		public string topicName
		{
			get
			{
				return this._topicName;
			}
			set
			{
				this._topicName = value;
			}
		}
		/// <summary>
		/// Indicates if the client is allowed to connect as subscriber.
		/// </summary>
		public bool subscribeAllowed
		{
			get
			{
				return this._subscribeAllowed;
			}
			set
			{
				this._subscribeAllowed = value;
			}
		}
		/// <summary>
		/// Indicates if the client is allowed to connect as subscriber.
		/// </summary>
		public bool publishAllowed
		{
			get
			{
				return this._publishAllowed;
			}
			set
			{
				this._publishAllowed = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.topicName;
			case 2: return this.subscribeAllowed;
			case 3: return this.publishAllowed;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.topicName = (System.String)fieldValue; break;
			case 2: this.subscribeAllowed = (System.Boolean)fieldValue; break;
			case 3: this.publishAllowed = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class RolePlayerMessage : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""RolePlayerMessage"",""namespace"":""eu.driver.model.core"",""fields"":[{""name"":""id"",""doc"":""The unique ID of the message"",""type"":""string""},{""name"":""type"",""doc"":""The type of role play."",""type"":{""type"":""enum"",""name"":""Type"",""namespace"":""eu.driver.model.tm"",""symbols"":[""CALL"",""ACTION"",""MESSAGE"",""MAIL"",""TWEET""]}},{""name"":""title"",""doc"":""The title of the role play message."",""type"":""string""},{""name"":""headline"",""doc"":""The headline of the role play message."",""type"":""string""},{""name"":""description"",""doc"":""The longer description of the role play message."",""type"":""string""},{""name"":""rolePlayerName"",""doc"":""The name of the person that has to handle the message."",""type"":""string""},{""name"":""participantNames"",""doc"":""The names of the person that have to receive the message."",""default"":null,""type"":[""null"",{""type"":""array"",""items"":""string""}]},{""name"":""comment"",""doc"":""An optional comment to the session state."",""default"":null,""type"":[""null"",""string""]}]}");
		/// <summary>
		/// The unique ID of the message
		/// </summary>
		private string _id;
		/// <summary>
		/// The type of role play.
		/// </summary>
		private eu.driver.model.tm.Type _type;
		/// <summary>
		/// The title of the role play message.
		/// </summary>
		private string _title;
		/// <summary>
		/// The headline of the role play message.
		/// </summary>
		private string _headline;
		/// <summary>
		/// The longer description of the role play message.
		/// </summary>
		private string _description;
		/// <summary>
		/// The name of the person that has to handle the message.
		/// </summary>
		private string _rolePlayerName;
		/// <summary>
		/// The names of the person that have to receive the message.
		/// </summary>
		private IList<System.String> _participantNames;
		/// <summary>
		/// An optional comment to the session state.
		/// </summary>
		private string _comment;
		public virtual Schema Schema
		{
			get
			{
				return RolePlayerMessage._SCHEMA;
			}
		}
		/// <summary>
		/// The unique ID of the message
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
		/// The type of role play.
		/// </summary>
		public eu.driver.model.tm.Type type
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}
		/// <summary>
		/// The title of the role play message.
		/// </summary>
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				this._title = value;
			}
		}
		/// <summary>
		/// The headline of the role play message.
		/// </summary>
		public string headline
		{
			get
			{
				return this._headline;
			}
			set
			{
				this._headline = value;
			}
		}
		/// <summary>
		/// The longer description of the role play message.
		/// </summary>
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		/// <summary>
		/// The name of the person that has to handle the message.
		/// </summary>
		public string rolePlayerName
		{
			get
			{
				return this._rolePlayerName;
			}
			set
			{
				this._rolePlayerName = value;
			}
		}
		/// <summary>
		/// The names of the person that have to receive the message.
		/// </summary>
		public IList<System.String> participantNames
		{
			get
			{
				return this._participantNames;
			}
			set
			{
				this._participantNames = value;
			}
		}
		/// <summary>
		/// An optional comment to the session state.
		/// </summary>
		public string comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				this._comment = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.id;
			case 1: return this.type;
			case 2: return this.title;
			case 3: return this.headline;
			case 4: return this.description;
			case 5: return this.rolePlayerName;
			case 6: return this.participantNames;
			case 7: return this.comment;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.id = (System.String)fieldValue; break;
			case 1: this.type = (eu.driver.model.tm.Type)fieldValue; break;
			case 2: this.title = (System.String)fieldValue; break;
			case 3: this.headline = (System.String)fieldValue; break;
			case 4: this.description = (System.String)fieldValue; break;
			case 5: this.rolePlayerName = (System.String)fieldValue; break;
			case 6: this.participantNames = (IList<System.String>)fieldValue; break;
			case 7: this.comment = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

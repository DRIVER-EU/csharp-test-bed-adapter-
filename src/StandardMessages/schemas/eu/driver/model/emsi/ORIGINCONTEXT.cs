// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.emsi
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ORIGINCONTEXT : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ORIGINCONTEXT"",""namespace"":""eu.driver.model.emsi"",""fields"":[{""name"":""ORG_ID"",""type"":""string"",""source"":""element ORG_ID""},{""name"":""USER_ID"",""type"":[""null"",""string""],""source"":""element USER_ID""},{""name"":""NAME"",""type"":[""null"",""string""],""source"":""element NAME""}]}");
		private string _ORG_ID;
		private string _USER_ID;
		private string _NAME;
		public virtual Schema Schema
		{
			get
			{
				return ORIGINCONTEXT._SCHEMA;
			}
		}
		public string ORG_ID
		{
			get
			{
				return this._ORG_ID;
			}
			set
			{
				this._ORG_ID = value;
			}
		}
		public string USER_ID
		{
			get
			{
				return this._USER_ID;
			}
			set
			{
				this._USER_ID = value;
			}
		}
		public string NAME
		{
			get
			{
				return this._NAME;
			}
			set
			{
				this._NAME = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.ORG_ID;
			case 1: return this.USER_ID;
			case 2: return this.NAME;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.ORG_ID = (System.String)fieldValue; break;
			case 1: this.USER_ID = (System.String)fieldValue; break;
			case 2: this.NAME = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

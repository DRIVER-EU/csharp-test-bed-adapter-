// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.mlp
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class AltAcc : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"AltAcc\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"na" +
				"me\":\"alt_acc\",\"doc\":\"Accuracy of Altitude in meters\",\"default\":null,\"type\":[\"nul" +
				"l\",\"int\"]}]}");
		/// <summary>
		/// Accuracy of Altitude in meters
		/// </summary>
		private System.Nullable<int> _alt_acc;
		public virtual Schema Schema
		{
			get
			{
				return AltAcc._SCHEMA;
			}
		}
		/// <summary>
		/// Accuracy of Altitude in meters
		/// </summary>
		public System.Nullable<int> alt_acc
		{
			get
			{
				return this._alt_acc;
			}
			set
			{
				this._alt_acc = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.alt_acc;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.alt_acc = (System.Nullable<int>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

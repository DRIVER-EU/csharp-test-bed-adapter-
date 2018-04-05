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
	
	public partial class COORDType : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""COORDType"",""namespace"":""eu.driver.model.emsi"",""fields"":[{""name"":""LAT"",""type"":""double"",""source"":""element LAT""},{""name"":""LON"",""type"":""double"",""source"":""element LON""},{""name"":""HEIGHT"",""type"":[""null"",""double""],""source"":""element HEIGHT""}]}");
		private double _LAT;
		private double _LON;
		private System.Nullable<double> _HEIGHT;
		public virtual Schema Schema
		{
			get
			{
				return COORDType._SCHEMA;
			}
		}
		public double LAT
		{
			get
			{
				return this._LAT;
			}
			set
			{
				this._LAT = value;
			}
		}
		public double LON
		{
			get
			{
				return this._LON;
			}
			set
			{
				this._LON = value;
			}
		}
		public System.Nullable<double> HEIGHT
		{
			get
			{
				return this._HEIGHT;
			}
			set
			{
				this._HEIGHT = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.LAT;
			case 1: return this.LON;
			case 2: return this.HEIGHT;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.LAT = (System.Double)fieldValue; break;
			case 1: this.LON = (System.Double)fieldValue; break;
			case 2: this.HEIGHT = (System.Nullable<double>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
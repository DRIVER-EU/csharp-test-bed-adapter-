// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.geojson
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class LineString : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""LineString"",""namespace"":""eu.driver.model.geojson"",""fields"":[{""name"":""type"",""default"":""LineString"",""type"":{""type"":""enum"",""name"":""LineStringType"",""namespace"":""eu.driver.model.geojson"",""symbols"":[""LineString""]}},{""name"":""coordinates"",""type"":{""type"":""array"",""items"":{""type"":""array"",""items"":""double""}}}]}");
		private eu.driver.model.geojson.LineStringType _type;
		private IList<IList<System.Double>> _coordinates;
		public virtual Schema Schema
		{
			get
			{
				return LineString._SCHEMA;
			}
		}
		public eu.driver.model.geojson.LineStringType type
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
		public IList<IList<System.Double>> coordinates
		{
			get
			{
				return this._coordinates;
			}
			set
			{
				this._coordinates = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.type;
			case 1: return this.coordinates;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.type = (eu.driver.model.geojson.LineStringType)fieldValue; break;
			case 1: this.coordinates = (IList<IList<System.Double>>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

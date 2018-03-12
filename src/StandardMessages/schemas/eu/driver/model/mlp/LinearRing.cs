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
	
	public partial class LinearRing : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""LinearRing"",""namespace"":""eu.driver.model.mlp"",""fields"":[{""name"":""coords"",""doc"":""Must contain at least 3 coordinates"",""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""Coord"",""namespace"":""eu.driver.model.mlp"",""fields"":[{""name"":""X"",""doc"":""The first coordinate in a coordinate system (30 27 45.3N)"",""type"":""string""},{""name"":""Y"",""doc"":""Second ordinate in a coordinate.system (45 25 52.9E). This is optional if it is a linear coordinate system."",""default"":null,""type"":[""null"",""double""]},{""name"":""Z"",""doc"":""Third ordinate in a coordinate system which has at least three ordinates."",""default"":null,""type"":[""null"",""double""]}]}}}]}");
		/// <summary>
		/// Must contain at least 3 coordinates
		/// </summary>
		private IList<eu.driver.model.mlp.Coord> _coords;
		public virtual Schema Schema
		{
			get
			{
				return LinearRing._SCHEMA;
			}
		}
		/// <summary>
		/// Must contain at least 3 coordinates
		/// </summary>
		public IList<eu.driver.model.mlp.Coord> coords
		{
			get
			{
				return this._coords;
			}
			set
			{
				this._coords = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.coords;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.coords = (IList<eu.driver.model.mlp.Coord>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

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
	
	public partial class Point : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Point"",""namespace"":""eu.driver.model.mlp"",""fields"":[{""name"":""coord"",""type"":{""type"":""record"",""name"":""Coord"",""namespace"":""eu.driver.model.mlp"",""fields"":[{""name"":""X"",""doc"":""The first coordinate in a coordinate system (30 27 45.3N)"",""type"":""string""},{""name"":""Y"",""doc"":""Second ordinate in a coordinate.system (45 25 52.9E). This is optional if it is a linear coordinate system."",""default"":null,""type"":[""null"",""string""]},{""name"":""Z"",""doc"":""Third ordinate in a coordinate system which has at least three ordinates."",""default"":null,""type"":[""null"",""string""]}]}},{""name"":""attr_gid"",""default"":null,""type"":[""null"",""string""]},{""name"":""attr_srsName"",""default"":null,""type"":[""null"",""string""]}]}");
		private eu.driver.model.mlp.Coord _coord;
		private string _attr_gid;
		private string _attr_srsName;
		public virtual Schema Schema
		{
			get
			{
				return Point._SCHEMA;
			}
		}
		public eu.driver.model.mlp.Coord coord
		{
			get
			{
				return this._coord;
			}
			set
			{
				this._coord = value;
			}
		}
		public string attr_gid
		{
			get
			{
				return this._attr_gid;
			}
			set
			{
				this._attr_gid = value;
			}
		}
		public string attr_srsName
		{
			get
			{
				return this._attr_srsName;
			}
			set
			{
				this._attr_srsName = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.coord;
			case 1: return this.attr_gid;
			case 2: return this.attr_srsName;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.coord = (eu.driver.model.mlp.Coord)fieldValue; break;
			case 1: this.attr_gid = (System.String)fieldValue; break;
			case 2: this.attr_srsName = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

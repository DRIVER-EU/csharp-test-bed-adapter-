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
	
	public partial class Pd : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Pd\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":" +
				"\"time\",\"type\":{\"type\":\"record\",\"name\":\"Time\",\"namespace\":\"eu.driver.model.mlp\",\"" +
				"fields\":[{\"name\":\"time\",\"doc\":\"UTC Timestamp in milliseconds. Original MLP uses " +
				"String: yyyyMMddhhmmss\",\"type\":\"long\",\"logicalType\":\"timestamp-millis\"},{\"name\":" +
				"\"attr_utc_off\",\"doc\":\"Specifies the UTC [UTC] offset in hours and minutes. Posit" +
				"ive values indicate time zones east of Greenwich.\",\"default\":\"0000\",\"type\":\"stri" +
				"ng\"}]}},{\"name\":\"shape\",\"doc\":\"TODO: add  MultiLineString | MultiPoint | MultiPo" +
				"lygon if they are needed\",\"type\":[{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"e" +
				"u.driver.model.mlp\",\"fields\":[{\"name\":\"coord\",\"type\":{\"type\":\"record\",\"name\":\"Co" +
				"ord\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"X\",\"doc\":\"The first co" +
				"ordinate in a coordinate system (30 27 45.3N)\",\"type\":\"string\"},{\"name\":\"Y\",\"doc" +
				"\":\"Second ordinate in a coordinate.system (45 25 52.9E). This is optional if it " +
				"is a linear coordinate system.\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\"" +
				":\"Z\",\"doc\":\"Third ordinate in a coordinate system which has at least three ordin" +
				"ates.\",\"default\":null,\"type\":[\"null\",\"string\"]}]}},{\"name\":\"attr_gid\",\"default\":" +
				"null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"nu" +
				"ll\",\"string\"]}]},{\"type\":\"record\",\"name\":\"LineString\",\"namespace\":\"eu.driver.mod" +
				"el.mlp\",\"fields\":[{\"name\":\"coord\",\"doc\":\"Must contain at least 2 coordinates\",\"t" +
				"ype\":{\"type\":\"array\",\"items\":\"Coord\"}},{\"name\":\"attr_gid\",\"default\":null,\"type\":" +
				"[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"" +
				"]}]},{\"type\":\"record\",\"name\":\"Polygon\",\"namespace\":\"eu.driver.model.mlp\",\"fields" +
				"\":[{\"name\":\"outerBoundaryIs\",\"type\":{\"type\":\"record\",\"name\":\"LinearRing\",\"namesp" +
				"ace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"coords\",\"doc\":\"Must contain at lea" +
				"st 3 coordinates\",\"type\":{\"type\":\"array\",\"items\":\"Coord\"}}]}},{\"name\":\"innerBoun" +
				"daryIs\",\"default\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"LinearRing\"}]},{\"" +
				"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\"" +
				",\"default\":null,\"type\":[\"null\",\"string\"]}]},{\"type\":\"record\",\"name\":\"Box\",\"names" +
				"pace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"coordTopLeft\",\"type\":\"Coord\"},{\"n" +
				"ame\":\"coordBottomRight\",\"type\":\"Coord\"},{\"name\":\"attr_gid\",\"default\":null,\"type\"" +
				":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string" +
				"\"]}]},{\"type\":\"record\",\"name\":\"CircularArea\",\"namespace\":\"eu.driver.model.mlp\",\"" +
				"fields\":[{\"name\":\"coord\",\"type\":\"Coord\"},{\"name\":\"radius\",\"type\":\"double\"},{\"nam" +
				"e\":\"distanceUnit\",\"default\":null,\"type\":[\"null\",{\"type\":\"enum\",\"name\":\"DistanceU" +
				"nit\",\"namespace\":\"eu.driver.model.mlp\",\"symbols\":[\"meter\"]}]},{\"name\":\"attr_gid\"" +
				",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null," +
				"\"type\":[\"null\",\"string\"]}]},{\"type\":\"record\",\"name\":\"CircularArcArea\",\"namespace" +
				"\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"coord\",\"type\":\"Coord\"},{\"name\":\"inRad" +
				"ius\",\"type\":\"double\"},{\"name\":\"outRadius\",\"type\":\"double\"},{\"name\":\"startAngle\"," +
				"\"type\":\"double\"},{\"name\":\"stopAngle\",\"type\":\"double\"},{\"name\":\"angularUnit\",\"def" +
				"ault\":null,\"type\":[\"null\",{\"type\":\"enum\",\"name\":\"AngularUnit\",\"namespace\":\"eu.dr" +
				"iver.model.mlp\",\"symbols\":[\"Degrees\",\"Radians\"]}]},{\"name\":\"distanceUnit\",\"defau" +
				"lt\":null,\"type\":[\"null\",\"DistanceUnit\"]},{\"name\":\"attr_gid\",\"default\":null,\"type" +
				"\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"strin" +
				"g\"]}]},{\"type\":\"record\",\"name\":\"EllipticalArea\",\"namespace\":\"eu.driver.model.mlp" +
				"\",\"fields\":[{\"name\":\"coord\",\"type\":\"Coord\"},{\"name\":\"angle\",\"type\":\"double\"},{\"n" +
				"ame\":\"semiMajor\",\"type\":\"double\"},{\"name\":\"semiMinor\",\"type\":\"double\"},{\"name\":\"" +
				"stopAngle\",\"type\":\"double\"},{\"name\":\"angularUnit\",\"default\":null,\"type\":[\"null\"," +
				"\"AngularUnit\"]},{\"name\":\"distanceUnit\",\"default\":null,\"type\":[\"null\",\"DistanceUn" +
				"it\"]},{\"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_" +
				"srsName\",\"default\":null,\"type\":[\"null\",\"string\"]}]}]},{\"name\":\"alt\",\"default\":nu" +
				"ll,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"Alt\",\"namespace\":\"eu.driver.model.mlp" +
				"\",\"fields\":[{\"name\":\"alt\",\"doc\":\"Altitude in meters\",\"type\":\"int\"}]}]},{\"name\":\"" +
				"altAcc\",\"default\":null,\"type\":[\"null\",{\"type\":\"record\",\"name\":\"AltAcc\",\"namespac" +
				"e\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"alt_acc\",\"doc\":\"Accuracy of Altitude" +
				" in meters\",\"default\":null,\"type\":[\"null\",\"int\"]}]}]},{\"name\":\"speed\",\"doc\":\"Spe" +
				"ed in m/s\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"direction\",\"doc\":\"Dire" +
				"ction of movement in degrees\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"lev" +
				"_conf\",\"doc\":\"Probability in percent that the Mobile Station is located in the p" +
				"osition area that is returned\",\"default\":null,\"type\":[\"null\",\"int\"]}]}");
		private eu.driver.model.mlp.Time _time;
		/// <summary>
		/// TODO: add  MultiLineString | MultiPoint | MultiPolygon if they are needed
		/// </summary>
		private object _shape;
		private eu.driver.model.mlp.Alt _alt;
		private eu.driver.model.mlp.AltAcc _altAcc;
		/// <summary>
		/// Speed in m/s
		/// </summary>
		private System.Nullable<int> _speed;
		/// <summary>
		/// Direction of movement in degrees
		/// </summary>
		private System.Nullable<int> _direction;
		/// <summary>
		/// Probability in percent that the Mobile Station is located in the position area that is returned
		/// </summary>
		private System.Nullable<int> _lev_conf;
		public virtual Schema Schema
		{
			get
			{
				return Pd._SCHEMA;
			}
		}
		public eu.driver.model.mlp.Time time
		{
			get
			{
				return this._time;
			}
			set
			{
				this._time = value;
			}
		}
		/// <summary>
		/// TODO: add  MultiLineString | MultiPoint | MultiPolygon if they are needed
		/// </summary>
		public object shape
		{
			get
			{
				return this._shape;
			}
			set
			{
				this._shape = value;
			}
		}
		public eu.driver.model.mlp.Alt alt
		{
			get
			{
				return this._alt;
			}
			set
			{
				this._alt = value;
			}
		}
		public eu.driver.model.mlp.AltAcc altAcc
		{
			get
			{
				return this._altAcc;
			}
			set
			{
				this._altAcc = value;
			}
		}
		/// <summary>
		/// Speed in m/s
		/// </summary>
		public System.Nullable<int> speed
		{
			get
			{
				return this._speed;
			}
			set
			{
				this._speed = value;
			}
		}
		/// <summary>
		/// Direction of movement in degrees
		/// </summary>
		public System.Nullable<int> direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this._direction = value;
			}
		}
		/// <summary>
		/// Probability in percent that the Mobile Station is located in the position area that is returned
		/// </summary>
		public System.Nullable<int> lev_conf
		{
			get
			{
				return this._lev_conf;
			}
			set
			{
				this._lev_conf = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.time;
			case 1: return this.shape;
			case 2: return this.alt;
			case 3: return this.altAcc;
			case 4: return this.speed;
			case 5: return this.direction;
			case 6: return this.lev_conf;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.time = (eu.driver.model.mlp.Time)fieldValue; break;
			case 1: this.shape = (System.Object)fieldValue; break;
			case 2: this.alt = (eu.driver.model.mlp.Alt)fieldValue; break;
			case 3: this.altAcc = (eu.driver.model.mlp.AltAcc)fieldValue; break;
			case 4: this.speed = (System.Nullable<int>)fieldValue; break;
			case 5: this.direction = (System.Nullable<int>)fieldValue; break;
			case 6: this.lev_conf = (System.Nullable<int>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

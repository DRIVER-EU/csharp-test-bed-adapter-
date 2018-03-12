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
	
	public partial class Feature : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"Feature\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":" +
				"[{\"name\":\"type\",\"default\":\"Feature\",\"type\":{\"type\":\"enum\",\"name\":\"FeatureType\",\"" +
				"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Feature\"]}},{\"name\":\"bbox\",\"def" +
				"ault\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"double\"}]},{\"name\":\"geometry\"" +
				",\"type\":[{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"eu.driver.model.geojson\",\"" +
				"fields\":[{\"name\":\"type\",\"default\":\"Point\",\"type\":{\"type\":\"enum\",\"name\":\"PointTyp" +
				"e\",\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Point\"]}},{\"name\":\"coordina" +
				"tes\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"LineSt" +
				"ring\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"" +
				"LineString\",\"type\":{\"type\":\"enum\",\"name\":\"LineStringType\",\"namespace\":\"eu.driver" +
				".model.geojson\",\"symbols\":[\"LineString\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":" +
				"\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"M" +
				"ultiLineString\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\",\"" +
				"default\":\"MultiLineString\",\"type\":{\"type\":\"enum\",\"name\":\"MultiLineStringType\",\"n" +
				"amespace\":\"eu.driver.model.geojson\",\"symbols\":[\"MultiLineString\"]}},{\"name\":\"coo" +
				"rdinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\"" +
				",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"Polygon\",\"namespace\":\"eu.driver" +
				".model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Polygon\",\"type\":{\"type\":\"enu" +
				"m\",\"name\":\"PolygonType\",\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Polygo" +
				"n\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"item" +
				"s\":{\"type\":\"array\",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"MultiPolygon\"" +
				",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Multi" +
				"Polygon\",\"type\":{\"type\":\"enum\",\"name\":\"MultiPolygonType\",\"namespace\":\"eu.driver." +
				"model.geojson\",\"symbols\":[\"MultiPolygon\"]}},{\"name\":\"coordinates\",\"type\":{\"type\"" +
				":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\"" +
				",\"items\":\"double\"}}}}}]}]},{\"name\":\"properties\",\"doc\":\"Any type, without infinit" +
				"e nesting, should be replaced during actual usage with a record with named prope" +
				"rties.\",\"type\":{\"type\":\"map\",\"values\":[\"null\",\"boolean\",\"string\",\"int\",\"long\",\"f" +
				"loat\",\"double\",{\"type\":\"array\",\"items\":[\"null\",\"boolean\",\"string\",\"int\",\"long\",\"" +
				"float\",\"double\"]},{\"type\":\"map\",\"values\":[\"null\",\"boolean\",\"string\",\"int\",\"long\"" +
				",\"float\",\"double\"]}]}}]}");
		private eu.driver.model.geojson.FeatureType _type;
		private IList<System.Double> _bbox;
		private object _geometry;
		/// <summary>
		/// Any type, without infinite nesting, should be replaced during actual usage with a record with named properties.
		/// </summary>
		private IDictionary<string,System.Object> _properties;
		public virtual Schema Schema
		{
			get
			{
				return Feature._SCHEMA;
			}
		}
		public eu.driver.model.geojson.FeatureType type
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
		public IList<System.Double> bbox
		{
			get
			{
				return this._bbox;
			}
			set
			{
				this._bbox = value;
			}
		}
		public object geometry
		{
			get
			{
				return this._geometry;
			}
			set
			{
				this._geometry = value;
			}
		}
		/// <summary>
		/// Any type, without infinite nesting, should be replaced during actual usage with a record with named properties.
		/// </summary>
		public IDictionary<string,System.Object> properties
		{
			get
			{
				return this._properties;
			}
			set
			{
				this._properties = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.type;
			case 1: return this.bbox;
			case 2: return this.geometry;
			case 3: return this.properties;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.type = (eu.driver.model.geojson.FeatureType)fieldValue; break;
			case 1: this.bbox = (IList<System.Double>)fieldValue; break;
			case 2: this.geometry = (System.Object)fieldValue; break;
			case 3: this.properties = (IDictionary<string,System.Object>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
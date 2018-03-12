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
	
	public partial class FeatureCollection : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"FeatureCollection\",\"namespace\":\"eu.driver.model.geojson\"" +
				",\"fields\":[{\"name\":\"type\",\"default\":\"FeatureCollection\",\"type\":{\"type\":\"enum\",\"n" +
				"ame\":\"FeatureCollectionType\",\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"F" +
				"eatureCollection\"]}},{\"name\":\"bbox\",\"default\":null,\"type\":[\"null\",{\"type\":\"array" +
				"\",\"items\":\"double\"}]},{\"name\":\"features\",\"type\":[\"null\",{\"type\":\"array\",\"items\":" +
				"{\"type\":\"record\",\"name\":\"Feature\",\"namespace\":\"eu.driver.model.geojson\",\"fields\"" +
				":[{\"name\":\"type\",\"default\":\"Feature\",\"type\":{\"type\":\"enum\",\"name\":\"FeatureType\"," +
				"\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Feature\"]}},{\"name\":\"bbox\",\"de" +
				"fault\":null,\"type\":[\"null\",{\"type\":\"array\",\"items\":\"double\"}]},{\"name\":\"geometry" +
				"\",\"type\":[{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"eu.driver.model.geojson\"," +
				"\"fields\":[{\"name\":\"type\",\"default\":\"Point\",\"type\":{\"type\":\"enum\",\"name\":\"PointTy" +
				"pe\",\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Point\"]}},{\"name\":\"coordin" +
				"ates\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}]},{\"type\":\"record\",\"name\":\"LineS" +
				"tring\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":" +
				"\"LineString\",\"type\":{\"type\":\"enum\",\"name\":\"LineStringType\",\"namespace\":\"eu.drive" +
				"r.model.geojson\",\"symbols\":[\"LineString\"]}},{\"name\":\"coordinates\",\"type\":{\"type\"" +
				":\"array\",\"items\":{\"type\":\"array\",\"items\":\"double\"}}}]},{\"type\":\"record\",\"name\":\"" +
				"MultiLineString\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\"," +
				"\"default\":\"MultiLineString\",\"type\":{\"type\":\"enum\",\"name\":\"MultiLineStringType\",\"" +
				"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"MultiLineString\"]}},{\"name\":\"co" +
				"ordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array" +
				"\",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"Polygon\",\"namespace\":\"eu.drive" +
				"r.model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Polygon\",\"type\":{\"type\":\"en" +
				"um\",\"name\":\"PolygonType\",\"namespace\":\"eu.driver.model.geojson\",\"symbols\":[\"Polyg" +
				"on\"]}},{\"name\":\"coordinates\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"ite" +
				"ms\":{\"type\":\"array\",\"items\":\"double\"}}}}]},{\"type\":\"record\",\"name\":\"MultiPolygon" +
				"\",\"namespace\":\"eu.driver.model.geojson\",\"fields\":[{\"name\":\"type\",\"default\":\"Mult" +
				"iPolygon\",\"type\":{\"type\":\"enum\",\"name\":\"MultiPolygonType\",\"namespace\":\"eu.driver" +
				".model.geojson\",\"symbols\":[\"MultiPolygon\"]}},{\"name\":\"coordinates\",\"type\":{\"type" +
				"\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array\",\"items\":{\"type\":\"array" +
				"\",\"items\":\"double\"}}}}}]}]},{\"name\":\"properties\",\"doc\":\"Any type, without infini" +
				"te nesting, should be replaced during actual usage with a record with named prop" +
				"erties.\",\"type\":{\"type\":\"map\",\"values\":[\"null\",\"boolean\",\"string\",\"int\",\"long\",\"" +
				"float\",\"double\",{\"type\":\"array\",\"items\":[\"null\",\"boolean\",\"string\",\"int\",\"long\"," +
				"\"float\",\"double\"]},{\"type\":\"map\",\"values\":[\"null\",\"boolean\",\"string\",\"int\",\"long" +
				"\",\"float\",\"double\"]}]}}]}}]}]}");
		private eu.driver.model.geojson.FeatureCollectionType _type;
		private IList<System.Double> _bbox;
		private IList<eu.driver.model.geojson.Feature> _features;
		public virtual Schema Schema
		{
			get
			{
				return FeatureCollection._SCHEMA;
			}
		}
		public eu.driver.model.geojson.FeatureCollectionType type
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
		public IList<eu.driver.model.geojson.Feature> features
		{
			get
			{
				return this._features;
			}
			set
			{
				this._features = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.type;
			case 1: return this.bbox;
			case 2: return this.features;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.type = (eu.driver.model.geojson.FeatureCollectionType)fieldValue; break;
			case 1: this.bbox = (IList<System.Double>)fieldValue; break;
			case 2: this.features = (IList<eu.driver.model.geojson.Feature>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

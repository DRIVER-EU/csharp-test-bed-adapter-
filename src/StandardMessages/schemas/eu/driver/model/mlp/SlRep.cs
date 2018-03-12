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
	
	public partial class SlRep : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"SlRep\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"nam" +
				"e\":\"attr_ver\",\"default\":\"3.0.0\",\"type\":\"string\"},{\"name\":\"pos\",\"type\":{\"type\":\"r" +
				"ecord\",\"name\":\"Pos\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"msid\",\"" +
				"type\":{\"type\":\"record\",\"name\":\"Msid\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":" +
				"[{\"name\":\"msid\",\"type\":\"string\"},{\"name\":\"attr_type\",\"type\":{\"type\":\"enum\",\"name" +
				"\":\"AttrType\",\"namespace\":\"eu.driver.model.mlp\",\"symbols\":[\"MSISDN\",\"IMSI\",\"IMEI\"" +
				",\"MIN\",\"MDN\",\"EME_MSID\",\"ASID\",\"OPE_ID\",\"IPV4\",\"IPV6\",\"SESSID\"]}},{\"name\":\"attr_" +
				"enc\",\"type\":{\"type\":\"enum\",\"name\":\"AttrEnc\",\"namespace\":\"eu.driver.model.mlp\",\"s" +
				"ymbols\":[\"ASC\",\"CRP\"]}}]}},{\"name\":\"pd_poserr\",\"type\":[{\"type\":\"record\",\"name\":\"" +
				"Pd\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"time\",\"type\":{\"type\":\"r" +
				"ecord\",\"name\":\"Time\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"time\"," +
				"\"doc\":\"UTC Timestamp in milliseconds. Original MLP uses String: yyyyMMddhhmmss\"," +
				"\"type\":\"long\",\"logicalType\":\"timestamp-millis\"},{\"name\":\"attr_utc_off\",\"doc\":\"Sp" +
				"ecifies the UTC [UTC] offset in hours and minutes. Positive values indicate time" +
				" zones east of Greenwich.\",\"default\":\"0000\",\"type\":\"string\"}]}},{\"name\":\"shape\"," +
				"\"doc\":\"TODO: add  MultiLineString | MultiPoint | MultiPolygon if they are needed" +
				"\",\"type\":[{\"type\":\"record\",\"name\":\"Point\",\"namespace\":\"eu.driver.model.mlp\",\"fie" +
				"lds\":[{\"name\":\"coord\",\"type\":{\"type\":\"record\",\"name\":\"Coord\",\"namespace\":\"eu.dri" +
				"ver.model.mlp\",\"fields\":[{\"name\":\"X\",\"doc\":\"The first coordinate in a coordinate" +
				" system (30 27 45.3N)\",\"type\":\"string\"},{\"name\":\"Y\",\"doc\":\"Second ordinate in a " +
				"coordinate.system (45 25 52.9E). This is optional if it is a linear coordinate s" +
				"ystem.\",\"default\":null,\"type\":[\"null\",\"double\"]},{\"name\":\"Z\",\"doc\":\"Third ordina" +
				"te in a coordinate system which has at least three ordinates.\",\"default\":null,\"t" +
				"ype\":[\"null\",\"double\"]}]}},{\"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"str" +
				"ing\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"]}]},{\"type\"" +
				":\"record\",\"name\":\"LineString\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name" +
				"\":\"coord\",\"doc\":\"Must contain at least 2 coordinates\",\"type\":{\"type\":\"array\",\"it" +
				"ems\":\"Coord\"}},{\"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"nam" +
				"e\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"]}]},{\"type\":\"record\",\"n" +
				"ame\":\"Polygon\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"outerBoundar" +
				"yIs\",\"type\":{\"type\":\"record\",\"name\":\"LinearRing\",\"namespace\":\"eu.driver.model.ml" +
				"p\",\"fields\":[{\"name\":\"coords\",\"doc\":\"Must contain at least 3 coordinates\",\"type\"" +
				":{\"type\":\"array\",\"items\":\"Coord\"}}]}},{\"name\":\"innerBoundaryIs\",\"default\":null,\"" +
				"type\":[\"null\",{\"type\":\"array\",\"items\":\"LinearRing\"}]},{\"name\":\"attr_gid\",\"defaul" +
				"t\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[" +
				"\"null\",\"string\"]}]},{\"type\":\"record\",\"name\":\"Box\",\"namespace\":\"eu.driver.model.m" +
				"lp\",\"fields\":[{\"name\":\"coordTopLeft\",\"type\":\"Coord\"},{\"name\":\"coordBottomRight\"," +
				"\"type\":\"Coord\"},{\"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"na" +
				"me\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"]}]},{\"type\":\"record\",\"" +
				"name\":\"CircularArea\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"coord\"" +
				",\"type\":\"Coord\"},{\"name\":\"radius\",\"type\":\"double\"},{\"name\":\"distanceUnit\",\"defau" +
				"lt\":null,\"type\":[\"null\",{\"type\":\"enum\",\"name\":\"DistanceUnit\",\"namespace\":\"eu.dri" +
				"ver.model.mlp\",\"symbols\":[\"meter\"]}]},{\"name\":\"attr_gid\",\"default\":null,\"type\":[" +
				"\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"]" +
				"}]},{\"type\":\"record\",\"name\":\"CircularArcArea\",\"namespace\":\"eu.driver.model.mlp\"," +
				"\"fields\":[{\"name\":\"coord\",\"type\":\"Coord\"},{\"name\":\"inRadius\",\"type\":\"double\"},{\"" +
				"name\":\"outRadius\",\"type\":\"double\"},{\"name\":\"startAngle\",\"type\":\"double\"},{\"name\"" +
				":\"stopAngle\",\"type\":\"double\"},{\"name\":\"angularUnit\",\"default\":null,\"type\":[\"null" +
				"\",{\"type\":\"enum\",\"name\":\"AngularUnit\",\"namespace\":\"eu.driver.model.mlp\",\"symbols" +
				"\":[\"Degrees\",\"Radians\"]}]},{\"name\":\"distanceUnit\",\"default\":null,\"type\":[\"null\"," +
				"\"DistanceUnit\"]},{\"name\":\"attr_gid\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"n" +
				"ame\":\"attr_srsName\",\"default\":null,\"type\":[\"null\",\"string\"]}]},{\"type\":\"record\"," +
				"\"name\":\"EllipticalArea\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"coo" +
				"rd\",\"type\":\"Coord\"},{\"name\":\"angle\",\"type\":\"double\"},{\"name\":\"semiMajor\",\"type\":" +
				"\"double\"},{\"name\":\"semiMinor\",\"type\":\"double\"},{\"name\":\"stopAngle\",\"type\":\"doubl" +
				"e\"},{\"name\":\"angularUnit\",\"default\":null,\"type\":[\"null\",\"AngularUnit\"]},{\"name\":" +
				"\"distanceUnit\",\"default\":null,\"type\":[\"null\",\"DistanceUnit\"]},{\"name\":\"attr_gid\"" +
				",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"attr_srsName\",\"default\":null," +
				"\"type\":[\"null\",\"string\"]}]}]},{\"name\":\"alt_alt_acc\",\"default\":null,\"type\":[\"null" +
				"\",{\"type\":\"record\",\"name\":\"Alt\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"na" +
				"me\":\"alt\",\"doc\":\"Altitude in meters\",\"type\":\"int\"}]},{\"type\":\"record\",\"name\":\"Al" +
				"tAcc\",\"namespace\":\"eu.driver.model.mlp\",\"fields\":[{\"name\":\"alt_acc\",\"doc\":\"Accur" +
				"acy of Altitude in meters\",\"default\":null,\"type\":[\"null\",\"int\"]}]}]},{\"name\":\"sp" +
				"eed\",\"doc\":\"Speed in m/s\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"directi" +
				"on\",\"doc\":\"Direction of movement in degrees\",\"default\":null,\"type\":[\"null\",\"int\"" +
				"]},{\"name\":\"lev_conf\",\"doc\":\"Probability in percent that the Mobile Station is l" +
				"ocated in the position area that is returned\",\"default\":null,\"type\":[\"null\",\"int" +
				"\"]}]},{\"type\":\"record\",\"name\":\"Poserr\",\"namespace\":\"eu.driver.model.mlp\",\"fields" +
				"\":[{\"name\":\"result\",\"type\":{\"type\":\"record\",\"name\":\"Result\",\"namespace\":\"eu.driv" +
				"er.model.mlp\",\"fields\":[{\"name\":\"result\",\"doc\":\"See MLP 3.1 specifications chapt" +
				"er 5.4 on Result Codes\",\"type\":{\"type\":\"enum\",\"name\":\"ResultEnum\",\"namespace\":\"e" +
				"u.driver.model.mlp\",\"symbols\":[\"OK\",\"SYSTEM_FAILURE\",\"UNSPECIFIED_ERROR\",\"UNAUTH" +
				"ORIZED_APPLICATION\",\"UNKNOWN_SUBSCRIBER\",\"ABSENT_SUBSCRIBER\",\"POSITION_METHOD_FA" +
				"ILURE\",\"CONGESTION_IN_LOCATION_SERVER\",\"CONGESTION_IN_MOBILE_NETWORK\",\"UNSUPPORT" +
				"ED_VERSION\",\"TOO_MANY_POSITION_ITEMS\",\"FORMAT_ERROR\",\"SYNTAX_ERROR\",\"PROTOCOL_EL" +
				"EMENT_NOT_SUPPORTED\",\"SERVICE_NOT_SUPPORTED\",\"PROTOCOL_ELEMENT_ATTRIBUTE_NOT_SUP" +
				"PORTED\",\"INVALID_PROTOCOL_ELEMENT_VALUE\",\"INVALID_PROTOCOL_ELEMENT_ATTRIBUTE_VAL" +
				"UE\",\"PROTOCOL_ELEMENT_VALUE_NOT_SUPPORTED\",\"PROTOCOL_ELEMENT_ATTRIBUTE_VALUE_NOT" +
				"_SUPPORTED\",\"QOP_NOT_ATTAINABLE\",\"POSITIONING_NOT_ALLOWED\",\"DISALLOWED_BY_LOCAL_" +
				"REGULATIONS\",\"MISCONFIGURATION_OF_LOCATION_SERVER\"]}},{\"name\":\"attr_resid\",\"doc\"" +
				":\"See MLP 3.1 specifications chapter 5.4 on Result Codes\",\"type\":\"string\"}]}},{\"" +
				"name\":\"add_info\",\"default\":null,\"type\":[\"null\",\"string\"]},{\"name\":\"time\",\"type\":" +
				"\"Time\"}]}]}]}}]}");
		private string _attr_ver;
		private eu.driver.model.mlp.Pos _pos;
		public virtual Schema Schema
		{
			get
			{
				return SlRep._SCHEMA;
			}
		}
		public string attr_ver
		{
			get
			{
				return this._attr_ver;
			}
			set
			{
				this._attr_ver = value;
			}
		}
		public eu.driver.model.mlp.Pos pos
		{
			get
			{
				return this._pos;
			}
			set
			{
				this._pos = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.attr_ver;
			case 1: return this.pos;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.attr_ver = (System.String)fieldValue; break;
			case 1: this.pos = (eu.driver.model.mlp.Pos)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

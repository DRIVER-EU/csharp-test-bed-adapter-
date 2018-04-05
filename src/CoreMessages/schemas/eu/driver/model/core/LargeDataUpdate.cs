// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class LargeDataUpdate : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""LargeDataUpdate"",""namespace"":""eu.driver.model.core"",""fields"":[{""name"":""url"",""doc"":""Link of where to download the data file from"",""type"":""string""},{""name"":""title"",""doc"":""Optional title of the data file, e.g. to serve it via WMS or otherwise"",""default"":null,""type"":[""null"",""string""]},{""name"":""description"",""doc"":""Optional description of the file"",""default"":null,""type"":[""null"",""string""]},{""name"":""dataType"",""doc"":""The type of data that is sent"",""type"":{""type"":""enum"",""name"":""DataType"",""namespace"":""eu.driver.model.core"",""symbols"":[""msword"",""ogg"",""pdf"",""excel"",""powerpoint"",""zip"",""audio_mpeg"",""audio_vorbis"",""image_bmp"",""image_gif"",""image_geotiff"",""image_jpeg"",""image_png"",""json"",""geojson"",""text_plain"",""video_mpeg"",""video_msvideo"",""video_avi"",""other""]}}]}");
		/// <summary>
		/// Link of where to download the data file from
		/// </summary>
		private string _url;
		/// <summary>
		/// Optional title of the data file, e.g. to serve it via WMS or otherwise
		/// </summary>
		private string _title;
		/// <summary>
		/// Optional description of the file
		/// </summary>
		private string _description;
		/// <summary>
		/// The type of data that is sent
		/// </summary>
		private eu.driver.model.core.DataType _dataType;
		public virtual Schema Schema
		{
			get
			{
				return LargeDataUpdate._SCHEMA;
			}
		}
		/// <summary>
		/// Link of where to download the data file from
		/// </summary>
		public string url
		{
			get
			{
				return this._url;
			}
			set
			{
				this._url = value;
			}
		}
		/// <summary>
		/// Optional title of the data file, e.g. to serve it via WMS or otherwise
		/// </summary>
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				this._title = value;
			}
		}
		/// <summary>
		/// Optional description of the file
		/// </summary>
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
			}
		}
		/// <summary>
		/// The type of data that is sent
		/// </summary>
		public eu.driver.model.core.DataType dataType
		{
			get
			{
				return this._dataType;
			}
			set
			{
				this._dataType = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.url;
			case 1: return this.title;
			case 2: return this.description;
			case 3: return this.dataType;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.url = (System.String)fieldValue; break;
			case 1: this.title = (System.String)fieldValue; break;
			case 2: this.description = (System.String)fieldValue; break;
			case 3: this.dataType = (eu.driver.model.core.DataType)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}

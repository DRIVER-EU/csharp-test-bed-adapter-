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
	
	public partial class MapLayerUpdate : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""MapLayerUpdate"",""namespace"":""eu.driver.model.core"",""fields"":[{""name"":""url"",""doc"":""Link to the layer"",""type"":""string""},{""name"":""title"",""doc"":""Optional title of the data file, e.g. to serve it via WMS or otherwise"",""default"":null,""type"":[""null"",""string""]},{""name"":""description"",""doc"":""Optional description of the file"",""default"":null,""type"":[""null"",""string""]},{""name"":""username"",""doc"":""Optional username when security is enabled"",""default"":null,""type"":[""null"",""string""]},{""name"":""password"",""doc"":""Optional password when security is enabled"",""default"":null,""type"":[""null"",""string""]},{""name"":""updateType"",""doc"":""Create, update, delete"",""type"":{""type"":""enum"",""name"":""UpdateType"",""namespace"":""eu.driver.model.core"",""symbols"":[""CREATE"",""UPDATE"",""DELETE""]}},{""name"":""layerType"",""doc"":""The type of layer that is offered"",""type"":{""type"":""enum"",""name"":""LayerType"",""namespace"":""eu.driver.model.core"",""symbols"":[""WMS"",""WMTS"",""WCS"",""WFS"",""OTHER""]}}]}");
		/// <summary>
		/// Link to the layer
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
		/// Optional username when security is enabled
		/// </summary>
		private string _username;
		/// <summary>
		/// Optional password when security is enabled
		/// </summary>
		private string _password;
		/// <summary>
		/// Create, update, delete
		/// </summary>
		private eu.driver.model.core.UpdateType _updateType;
		/// <summary>
		/// The type of layer that is offered
		/// </summary>
		private eu.driver.model.core.LayerType _layerType;
		public virtual Schema Schema
		{
			get
			{
				return MapLayerUpdate._SCHEMA;
			}
		}
		/// <summary>
		/// Link to the layer
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
		/// Optional username when security is enabled
		/// </summary>
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				this._username = value;
			}
		}
		/// <summary>
		/// Optional password when security is enabled
		/// </summary>
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				this._password = value;
			}
		}
		/// <summary>
		/// Create, update, delete
		/// </summary>
		public eu.driver.model.core.UpdateType updateType
		{
			get
			{
				return this._updateType;
			}
			set
			{
				this._updateType = value;
			}
		}
		/// <summary>
		/// The type of layer that is offered
		/// </summary>
		public eu.driver.model.core.LayerType layerType
		{
			get
			{
				return this._layerType;
			}
			set
			{
				this._layerType = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.url;
			case 1: return this.title;
			case 2: return this.description;
			case 3: return this.username;
			case 4: return this.password;
			case 5: return this.updateType;
			case 6: return this.layerType;
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
			case 3: this.username = (System.String)fieldValue; break;
			case 4: this.password = (System.String)fieldValue; break;
			case 5: this.updateType = (eu.driver.model.core.UpdateType)fieldValue; break;
			case 6: this.layerType = (eu.driver.model.core.LayerType)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
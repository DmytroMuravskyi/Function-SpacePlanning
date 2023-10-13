//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A horizontal datum representing a building level at a specific elevation.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Level : Element
    {
        [JsonConstructor]
        public Level(double @elevation, double? @height, System.Guid? @planView, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.Elevation = @elevation;
            this.Height = @height;
            this.PlanView = @planView;
            }
        
        // Empty constructor
        public Level()
            : base()
        {
        }
    
        [JsonProperty("Elevation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Elevation { get; set; }
    
        /// <summary>The vertical distance from this level to the next. May be null for a top level, like a roof.</summary>
        [JsonProperty("Height", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Height { get; set; }
    
        /// <summary>The default plan view for this level</summary>
        [JsonProperty("Plan View", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? PlanView { get; set; }
    
    
    }
}
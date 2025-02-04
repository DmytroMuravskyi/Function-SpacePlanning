// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace SpacePlanning
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class SpacePlanningInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public SpacePlanningInputs(Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacePlanningInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @overrides});
            }
        
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(OverrideAdditions @additions, OverrideRemovals @removals, IList<SpacesOverride> @spaces)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @additions, @removals, @spaces});
            }
        
            this.Additions = @additions ?? this.Additions;
            this.Removals = @removals ?? this.Removals;
            this.Spaces = @spaces ?? this.Spaces;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Additions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideAdditions Additions { get; set; } = new OverrideAdditions();
    
        [Newtonsoft.Json.JsonProperty("Removals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideRemovals Removals { get; set; } = new OverrideRemovals();
    
        [Newtonsoft.Json.JsonProperty("Spaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<SpacesOverride> Spaces { get; set; } = new List<SpacesOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideAdditions 
    
    {
        public OverrideAdditions() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideAdditions(IList<SpacesOverrideAddition> @spaces)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideAdditions>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @spaces});
            }
        
            this.Spaces = @spaces ?? this.Spaces;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Spaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<SpacesOverrideAddition> Spaces { get; set; } = new List<SpacesOverrideAddition>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideRemovals 
    
    {
        public OverrideRemovals() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideRemovals(IList<SpacesOverrideRemoval> @spaces)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideRemovals>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @spaces});
            }
        
            this.Spaces = @spaces ?? this.Spaces;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Spaces", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<SpacesOverrideRemoval> Spaces { get; set; } = new List<SpacesOverrideRemoval>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverride(string @id, SpacesIdentity @identity, SpacesValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverrideAddition(string @id, SpacesIdentity @identity, SpacesOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverrideAddition>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesOverrideAdditionValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverrideRemoval(string @id, SpacesIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverrideRemoval>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity});
            }
        
            this.Id = @id;
            this.Identity = @identity;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesIdentity Identity { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesIdentity(string @levelAddId, Vector3 @relativePosition, Polygon @originalBoundary, IList<Polygon> @originalVoids)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @levelAddId, @relativePosition, @originalBoundary, @originalVoids});
            }
        
            this.LevelAddId = @levelAddId;
            this.RelativePosition = @relativePosition;
            this.OriginalBoundary = @originalBoundary;
            this.OriginalVoids = @originalVoids;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Level Add Id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LevelAddId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Relative Position", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 RelativePosition { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Original Boundary", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polygon OriginalBoundary { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Original Voids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<Polygon> OriginalVoids { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesValue(SpacesValueLevel @level, string @programType, Profile @boundary)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @level, @programType, @boundary});
            }
        
            this.Level = @level;
            this.ProgramType = @programType;
            this.Boundary = @boundary;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Level", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesValueLevel Level { get; set; }
    
        /// <summary>What program should be assigned to this zone?</summary>
        [Newtonsoft.Json.JsonProperty("Program Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProgramType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Boundary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Profile Boundary { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverrideAdditionValue(SpacesOverrideAdditionValueLevel @level, SpacesOverrideAdditionValueLevelLayout @levelLayout, string @programType, Profile @boundary)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @level, @levelLayout, @programType, @boundary});
            }
        
            this.Level = @level;
            this.LevelLayout = @levelLayout;
            this.ProgramType = @programType;
            this.Boundary = @boundary;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Level", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesOverrideAdditionValueLevel Level { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Level Layout", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SpacesOverrideAdditionValueLevelLayout LevelLayout { get; set; }
    
        /// <summary>What program should be assigned to this zone?</summary>
        [Newtonsoft.Json.JsonProperty("Program Type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProgramType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Boundary", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Profile Boundary { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesValueLevel 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesValueLevel(string @name, string @buildingName, string @addId)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesValueLevel>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name, @buildingName, @addId});
            }
        
            this.Name = @name;
            this.BuildingName = @buildingName;
            this.AddId = @addId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Building Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Add Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverrideAdditionValueLevel 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverrideAdditionValueLevel(string @name, string @buildingName, string @addId)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverrideAdditionValueLevel>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name, @buildingName, @addId});
            }
        
            this.Name = @name;
            this.BuildingName = @buildingName;
            this.AddId = @addId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Building Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Add Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SpacesOverrideAdditionValueLevelLayout 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SpacesOverrideAdditionValueLevelLayout(string @name, string @buildingName, string @addId)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SpacesOverrideAdditionValueLevelLayout>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name, @buildingName, @addId});
            }
        
            this.Name = @name;
            this.BuildingName = @buildingName;
            this.AddId = @addId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Building Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Add Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AddId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
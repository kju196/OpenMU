// <copyright file="MasterSkillDefinition.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel;

using MUnique.OpenMU.Persistence.Json;

/// <summary>
/// A plain implementation of <see cref="MasterSkillDefinition"/>.
/// </summary>
public partial class MasterSkillDefinition : MUnique.OpenMU.DataModel.Configuration.MasterSkillDefinition, IIdentifiable, IConvertibleTo<MasterSkillDefinition>
{
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="RequiredMasterSkills" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("requiredMasterSkills")]
    public ICollection<Skill> RawRequiredMasterSkills { get; } = new List<Skill>();
    
    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.Skill> RequiredMasterSkills
    {
        get => base.RequiredMasterSkills ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Skill, Skill>(this.RawRequiredMasterSkills);
        protected set
        {
            this.RequiredMasterSkills.Clear();
            foreach (var item in value)
            {
                this.RequiredMasterSkills.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw object of <see cref="Root" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("root")]
    public MasterSkillRoot RawRoot
    {
        get => base.Root as MasterSkillRoot;
        set => base.Root = value;
    }

    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Configuration.MasterSkillRoot Root
    {
        get => base.Root;
        set => base.Root = value;
    }

    /// <summary>
    /// Gets the raw object of <see cref="TargetAttribute" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("targetAttribute")]
    public AttributeDefinition RawTargetAttribute
    {
        get => base.TargetAttribute as AttributeDefinition;
        set => base.TargetAttribute = value;
    }

    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.AttributeSystem.AttributeDefinition TargetAttribute
    {
        get => base.TargetAttribute;
        set => base.TargetAttribute = value;
    }

    /// <summary>
    /// Gets the raw object of <see cref="ReplacedSkill" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("replacedSkill")]
    public Skill RawReplacedSkill
    {
        get => base.ReplacedSkill as Skill;
        set => base.ReplacedSkill = value;
    }

    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Configuration.Skill ReplacedSkill
    {
        get => base.ReplacedSkill;
        set => base.ReplacedSkill = value;
    }

    /// <inheritdoc />
    public override MUnique.OpenMU.DataModel.Configuration.MasterSkillDefinition Clone(MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        var clone = new MasterSkillDefinition();
        clone.AssignValuesOf(this, gameConfiguration);
        return clone;
    }
    
    /// <inheritdoc />
    public override void AssignValuesOf(MUnique.OpenMU.DataModel.Configuration.MasterSkillDefinition other, MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        base.AssignValuesOf(other, gameConfiguration);
        this.Id = other.GetId();
    }

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    /// <inheritdoc/>
    public MasterSkillDefinition Convert() => this;
}

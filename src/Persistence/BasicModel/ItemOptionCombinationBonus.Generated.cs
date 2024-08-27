// <copyright file="ItemOptionCombinationBonus.Generated.cs" company="MUnique">
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
/// A plain implementation of <see cref="ItemOptionCombinationBonus"/>.
/// </summary>
public partial class ItemOptionCombinationBonus : MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionCombinationBonus, IIdentifiable, IConvertibleTo<ItemOptionCombinationBonus>
{
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="Requirements" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("requirements")]
    public ICollection<CombinationBonusRequirement> RawRequirements { get; } = new List<CombinationBonusRequirement>();
    
    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement> Requirements
    {
        get => base.Requirements ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.Items.CombinationBonusRequirement, CombinationBonusRequirement>(this.RawRequirements);
        protected set
        {
            this.Requirements.Clear();
            foreach (var item in value)
            {
                this.Requirements.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw object of <see cref="Bonus" />.
    /// </summary>
    [System.Text.Json.Serialization.JsonPropertyName("bonus")]
    public PowerUpDefinition RawBonus
    {
        get => base.Bonus as PowerUpDefinition;
        set => base.Bonus = value;
    }

    /// <inheritdoc/>
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Attributes.PowerUpDefinition Bonus
    {
        get => base.Bonus;
        set => base.Bonus = value;
    }

    /// <inheritdoc />
    public override MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionCombinationBonus Clone(MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
    {
        var clone = new ItemOptionCombinationBonus();
        clone.AssignValuesOf(this, gameConfiguration);
        return clone;
    }
    
    /// <inheritdoc />
    public override void AssignValuesOf(MUnique.OpenMU.DataModel.Configuration.Items.ItemOptionCombinationBonus other, MUnique.OpenMU.DataModel.Configuration.GameConfiguration gameConfiguration)
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
    public ItemOptionCombinationBonus Convert() => this;
}

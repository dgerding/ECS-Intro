using System.Reflection.Emit;
using Unity.Entities;

/// <summary>
/// Components are always structs, which are value types readily arranged in memory
/// </summary>
/// <remarks>
/// Implementing IComponentData future-proofs your components, since IComponentData 
/// is an Interface specified by Unity.Entities. F-12 into IComponentData to 
/// see for yourself.
/// </remarks>
public struct HeightComponent : IComponentData
{
    /// <summary>
    /// A float value we'll be able to use to control the height value of game Entities,
    /// using Systems of Jobs.
    /// </summary>
    public float height;
}

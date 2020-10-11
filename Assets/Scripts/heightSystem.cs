using UnityEngine;
using Unity.Entities;

/// <summary>
/// Implementing ComponentSystem means this code runs independently of the legacy GameObjects, MonoBehavior practice.
/// </summary>
/// <remarks>
/// This code is like (part) of a MonoBehavior. Note the similar OnUpdate point of entry.
/// </remarks>
public class HeightSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        // Iterate through all entities containing a LevelComponent
        Entities.ForEach((ref HeightComponent heightComponent) =>
        {
            // Increment level by 1 per second
            heightComponent.height += 1f * Time.DeltaTime;
        });
    }

}

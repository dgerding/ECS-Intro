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
    /// <summary>
    /// OnUpdate, overridden from the ComponentSystem base class, is called every frame, like a MonoBehavior Update method.
    /// </summary>
    protected override void OnUpdate()
    {
        
        //Note that we're using the ECS Entities version of "ForEach"
        //and that the value is passed in by reference so that 
        //changes in the body of the loop are effected on the actual,
        //referenced heightComponent that exists in memory outside 
        //the loop.
        Entities.ForEach((ref HeightComponent heightComponent) =>
        {
            // Increment level by 1 per second
            //(Also note the new required casing for DeltaTime)
            heightComponent.height += 1f * Time.DeltaTime;
        });
    }

}

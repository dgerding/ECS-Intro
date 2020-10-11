using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

/// <summary>
/// A classic Monobehavior implementation is used to instantiate a single HeightComponent and register it with the World.Active.EntityManager.
/// </summary>
public class SingleHeightEntityAtStart : MonoBehaviour
{
    // Create our HeightEntity when the Scene starts and before updates begin.

    [SerializeField] private Mesh mesh;
    [SerializeField] private Material material;

    void Start()
    {
        
        //Note: In older examples you'll see "World.Active.EntityManager" - It's been deprecated. DefaultGameObjectInjectionWorld is the correct alternative in nearly all cases.
        //The World's EntityManager manages component instances.
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        //Use the CreateEntity method, passing the **type** of desired component - not an instance that holds any "height" values yet.
        Entity entity = entityManager.CreateEntity(typeof(HeightComponent));

        //Finally, pass an entity instance, "typed" as HeightComponent in a property behind the scenes,
        //and an actual HeightComponent instance, to the EntityManager's SetComponentData method.
        //This registers the entity instance and also sets the initial value for the corresponding ("bound") HeightComponent instance.
        entityManager.SetComponentData(entity, new HeightComponent { height = 10 });

        //All of this work is enforce organizational and data structure requirements with enough rigor
        //to be able to spread work (behaviors) over many instances of these kinds of data using many threads!
    }

    
}

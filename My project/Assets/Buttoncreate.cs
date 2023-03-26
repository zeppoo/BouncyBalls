using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttoncreate : MonoBehaviour
{
    Collider coll;
    // Start is called before the first frame update
    public void CreateBouncyball()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        coll = sphere.GetComponent<Collider>();
        sphere.transform.position = new Vector3(Random.Range(0f, 2f), 5f, Random.Range(0f, 2f));
        Rigidbody rb = sphere.AddComponent<Rigidbody>();
        PhysicMaterial material = new PhysicMaterial();
        material.bounciness = 1f;
        coll.material = material;
    }
}

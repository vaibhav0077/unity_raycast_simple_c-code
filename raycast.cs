
using JetBrains.Annotations;
using UnityEngine;

public class raycast : MonoBehaviour
{
      public float x = 5, y = 5, z = 5;
      void Start()
    {
        
}

    void Update()
    {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                  Debug.DrawLine(transform.position, transform.TransformDirection(Vector3.forward));
            }
            else
            {
                  
                  Vector3 desti = new Vector3(x,y,z);
                  Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 50, Color.yellow);
                  Debug.DrawLine(transform.position, desti);
            }
                        
            

    }
}

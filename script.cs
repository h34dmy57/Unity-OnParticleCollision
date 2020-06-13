using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folhas : MonoBehaviour
{
    // Start is called before the first frame update

    ParticleSystem ps;

    void Start()
    {
        ps = GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Colidiu");
        if (other.CompareTag("Shuriken"));
        {
            ps.Emit(20);
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log(collision.collider);
    //    if (collision.collider.CompareTag("Shuriken"))
    //    {
    //        ps.Emit(10);
    //   }
    //}
}

    //private void OnTriggerEnter(Collision col)
    //{
    //    Debug.Log("Colidiu");
    //    if (Collision.col.CompareTag("Shuriken"))
    //    {
    //        ps.Emit(1);
    //    }
    //}
//}

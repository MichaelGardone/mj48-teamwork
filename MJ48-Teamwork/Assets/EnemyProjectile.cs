using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            //dodamagetoplayer
            Destroy(gameObject);
            collision.transform.GetComponent<Player>().health -= 5;
        }
    }
}

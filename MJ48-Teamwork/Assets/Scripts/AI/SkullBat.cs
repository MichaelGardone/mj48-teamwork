using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullBat : MonoBehaviour
{
    // Start is called before the first frame update
    Player player;
    [SerializeField] GameObject projectile;
    [SerializeField] float projectileRange;
    [SerializeField] float meleeRange;
    [SerializeField] float attackFrequency;
    private float timer;
    void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distToPlayer <= meleeRange)
        {
            //do damage
        }
        else if(distToPlayer <= projectileRange)
        {

        }
        timer += Time.deltaTime;
    }

    private void DoMeleeAttack()
    {
        player.health -= 20;
    }
    private void DoProjectileAttack()
    {
        if(timer >= attackFrequency)
        {
            //spawn projectile with the player as the target
            EnemyProjectile p = GameObject.Instantiate(projectile,transform.position,Quaternion.identity).GetComponent<EnemyProjectile>();
            p.GetComponent<Rigidbody2D>().velocity = Vector3.Normalize(player.transform.position - transform.position) * 2;
            timer = 0;
        }
        
    }
}

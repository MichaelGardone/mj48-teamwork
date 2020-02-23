using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : IItem
{

    public int id = 0;

    private void Start()
    {
        itemType = ItemType.KEY;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            collision.gameObject.GetComponent<Player>().AddItem(this);
            Destroy(gameObject);
        }

        if(collision.gameObject.GetComponent<Familiar>())
        {
            collision.gameObject.GetComponent<Familiar>().Pickup(this);

            gameObject.transform.parent = collision.gameObject.transform;
            gameObject.transform.localPosition = new Vector3(0, 0, -1);
            gameObject.transform.localScale *= 0.5f;
            gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }

}

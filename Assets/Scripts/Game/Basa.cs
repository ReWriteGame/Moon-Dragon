using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Basa : MonoBehaviour
{
    public UnityEvent getItemEvent;
    public UnityEvent getToxicEvent;


   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Toxic>())
        {
            getToxicEvent?.Invoke();
            collision.gameObject.GetComponent<Destroyable>().Destroy(0.5f);

        }
        if (collision.gameObject.GetComponent<Item>())
        {
            getItemEvent?.Invoke();
            collision.gameObject.GetComponent<Destroyable>().Destroy(0.5f);
        }

    }
}

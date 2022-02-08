using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Toxic : MonoBehaviour
{
    public UnityEvent touchBasaEvent;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<Basa>())
        touchBasaEvent?.Invoke();
    }
}

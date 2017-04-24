using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class DynamicTrigger : MonoBehaviour
{
    public DynamicTriggerEvent triggers;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            this.triggers.Invoke(collider);
        }
    }

    [Serializable]
    public class DynamicTriggerEvent : UnityEvent<Collider2D>
    {
        public DynamicTriggerEvent()
        {
        }
    }
}

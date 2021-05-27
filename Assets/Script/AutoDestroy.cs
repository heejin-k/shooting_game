using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}

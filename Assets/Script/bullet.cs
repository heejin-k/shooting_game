using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    [SerializeField] ParticleSystem hitParticlePrefab;

    void Start()
    {
        var velocity = speed * transform.forward;
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitBullet");

        Instantiate(hitParticlePrefab, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}

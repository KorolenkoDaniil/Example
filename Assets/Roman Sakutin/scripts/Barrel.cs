using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;
    [SerializeField] private ParticleSystem _effect;

    private List<Rigidbody> GetExploableObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> barrels = new();

        foreach(Collider hit in hits)
            if (hit.attachedRigidbody != null) 
                barrels.Add(hit.attachedRigidbody); 
        
        return barrels; 
    }

    private void OnMouseUpAsButton()
    {
        Expload();
        Instantiate(_effect, transform.position, transform.rotation);
        Destroy(gameObject);
    }


    private void Expload()
    {
        foreach (Rigidbody exploadableObject in GetExploableObjects())
            exploadableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }
}

using UnityEngine;


public class bullet : MonoBehaviour
{
    public int bulletDamage = 10;

    void OnCollisionEnter(Collision collision)
    {
        PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
        if(ph != null){
            ph.TakeDamage(bulletDamage);
        }
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = true;
        //Destroy(gameObject,3);
        //The Time to be quicker
        Destroy(gameObject,1);
    }
}

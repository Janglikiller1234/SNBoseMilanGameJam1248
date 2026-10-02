using UnityEngine;


public class bullet : MonoBehaviour
{
    public int bulletDamage = 10;
    public int defensePercentage = 0;

    void OnCollisionEnter(Collision collision)
    {
        PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
        if(ph != null){
            float totalDamage = bulletDamage - ((bulletDamage*defensePercentage)/100);
            ph.TakeDamage(Mathf.RoundToInt(totalDamage));
        }
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.useGravity = true;
        //Destroy(gameObject,3);
        //The Time to be quicker
        Destroy(gameObject,1);
    }
}

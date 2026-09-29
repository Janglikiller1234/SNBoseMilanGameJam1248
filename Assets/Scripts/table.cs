using UnityEngine;

public class table : MonoBehaviour
{
    public GameObject storeMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            FindAnyObjectByType<playerMovement>().canMove = false;
            storeMenu.SetActive(true);
            Debug.Log("You activated the inventory menu");
        }
    }
}

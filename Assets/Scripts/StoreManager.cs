using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public GameObject errorMessage;
    public MoneyManager moneyManager;
    public int _playerMoney;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        FindAnyObjectByType<playerMovement>().canMove = true;
        FindAnyObjectByType<table>().storeMenu.SetActive(false);
    }
}

using UnityEngine;

public class StoreElement : MonoBehaviour
{
    public int _cost;
    public GameObject errorMessage;
    public MoneyManager playerManager;
    public int _playerMoney;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerManager.playerMoney = _playerMoney;  
    }


}

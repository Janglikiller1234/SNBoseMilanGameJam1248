using UnityEngine;

public class StoreElement : MonoBehaviour
{
    public int _cost;
    public GameObject errorMessage;
    public MoneyManage playerManager;
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

    public void PurchaseItem(int i)
    {
        if (_playerMoney >= _cost)
        {
            playerManager.playerMoney -= CalcCost(i);
        }
        else
        {
            errorMessage.SetActive(true);
        }
        int a = i;
        Debug.Log("The current selected item is " + a.ToString() + " and the cost is " + CalcCost(i).ToString());
    }

    int CalcCost(int i)
    {
        switch (i)
        {
            case 0:
                return 100;
            case 1:
                return 100;
            case 2:
                return 100;
            case 3:
                return 100;
            case 4:
                return 100;
            case 5:
                return 100;
            case 6:
                return 100;
            case 7:
                return 100;
            default:
                return 0;
        }
    }
}

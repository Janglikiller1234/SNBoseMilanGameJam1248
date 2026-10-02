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
        _playerMoney = Mathf.RoundToInt(GetComponent<MoneyManager>().playerMoney);
    }

    public void PurchaseItem(int i)
    {
        int _cost = CalcCost(i);
        if (_playerMoney >= _cost)
        {
            GetComponent<MoneyManager>().playerMoney -= CalcCost(i);
            AddEffect(i);
            Debug.Log("The current selected item is " + i.ToString() + " and the cost is " + CalcCost(i).ToString());
        }
        else
        {
            errorMessage.SetActive(true);
        }  
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

    public void AddEffect(int i)
    {
        switch (i)
        {
            case 0:
                //FindAnyObjectByType<PlayerHealth>().HealPercentage(10);
                FindAnyObjectByType<PlayerHealth>().Heal(20);
                break;
            case 1:
                FindAnyObjectByType<PlayerHealth>().Heal(60);
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                FindAnyObjectByType<Enemy>().defensePercentage=10;
                break;
            case 5:
                FindAnyObjectByType<Enemy>().defensePercentage=25;
                break;
            case 6:
                FindAnyObjectByType<Enemy>().attackPercentage=20;
                break;
            case 7:
                FindAnyObjectByType<Enemy>().attackPercentage=40;
                break;
            default:
                break;
        }
    }

    public void Back()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        FindAnyObjectByType<playerMovement>().canMove = true;
        FindAnyObjectByType<table>().storeMenu.SetActive(false);
    }

    public void ErrorBack()
    {
        Time.timeScale = 0f;
        FindAnyObjectByType<playerMovement>().canMove = true;
        errorMessage.SetActive(false);
    }
}

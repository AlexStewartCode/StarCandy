using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManage : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Money;
    public TMPro.TextMeshProUGUI Food;
    public TMPro.TextMeshProUGUI Material;
    public Button money;
    public Button food;
    public Button mine;
    private int moneyMakers = 0;
    private int foodConsumers = 0;
    private int rockCollectors = 0;
    private float mon;
    private float fud;
    private float rock;

    // Start is called before the first frame update
    void Start()
    {
        money.onClick.AddListener(GetMoney);
        food.onClick.AddListener(GetFood);
        mine.onClick.AddListener(GetRock);
    }

    void GetMoney()
    {
        moneyMakers++;
    }

    void GetFood()
    {
        foodConsumers++;
    }

    void GetRock()
    {
        rockCollectors++;
    }

    // Update is called once per frame
    void Update()
    {
        mon += (moneyMakers * Time.deltaTime);
        fud += (foodConsumers * Time.deltaTime);
        rock += (rockCollectors * Time.deltaTime);
        Money.text = ((int)mon).ToString();
        Food.text = ((int)fud).ToString();
        Material.text = ((int)rock).ToString();
    }
}

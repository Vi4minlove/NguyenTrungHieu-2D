using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinTotal;
    public static int currentCoins = 0;
    private void Start()
    {

    }
    public void Update()
    {
        coinTotal.text = currentCoins.ToString();
    }
    private void Awake()
    {
        currentCoins = PlayerPrefs.GetInt("currentCoins",0);
    }
}

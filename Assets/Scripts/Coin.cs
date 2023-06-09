using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    private int CoinCol = 0;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI coinTextDead;

    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Coin")
        {
            CoinCol++;
            coinText.text = CoinCol.ToString();
            coinTextDead.text = CoinCol.ToString();
            CoinCounter.currentCoins++;
            AudioManager.instance.Play("Coins");
            PlayerPrefs.SetInt("currentCoins", CoinCounter.currentCoins);
            Destroy(collision.gameObject);
        }
    }
}

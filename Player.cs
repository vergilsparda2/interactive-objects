using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //хранит префаб огненного шара
    public GameObject fireBall;
    //хранит местоположение точки вылета
    public Transform attackPoint;
    //здоровье игрока   
    private int health = 10;
    //хранит данные о количестве собранных монет
    private int coins;
    public void CollectCoins()
    {
      coins = coins + 1;
        print("монеты"+coins);
    }
    public void TakeDamage(int damage)
    {
        health = health - damage;
        print(health);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireBall,attackPoint.position, attackPoint.rotation);
        }
        
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //������ ������ ��������� ����
    public GameObject fireBall;
    //������ �������������� ����� ������
    public Transform attackPoint;
    //�������� ������   
    private int health = 10;
    //������ ������ � ���������� ��������� �����
    private int coins;
    public void CollectCoins()
    {
      coins = coins + 1;
        print("������"+coins);
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

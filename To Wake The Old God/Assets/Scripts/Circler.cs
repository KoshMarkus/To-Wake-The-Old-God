using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circler : MonoBehaviour
{
    Rigidbody2D rb; //Физическая модель
    int [,] directions;
    public float speed; //Множитель скорости
    public int i; //счётчик стороны

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        directions = new int[,] { {0, 3}, {-3, 0}, {0, -3}, {3, 0} };
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(directions[i, 0] * speed, directions[i, 1] * speed); //Скорость персонажа
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            if (i < 3)
            {
                ++i;
            } else
            {
                i = 0;
            }
        }
    }
}
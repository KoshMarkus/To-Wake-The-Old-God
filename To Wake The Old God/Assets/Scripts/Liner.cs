using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Liner : MonoBehaviour
{
    Rigidbody2D rb; //Физическая модель
    int[,] directionsVertical;
    int[,] directionsHorizontal;
    public float speed; //Множитель скорости
    public bool vertical; //Вертикально или горизонтально он ходит
    int i;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (vertical)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            gameObject.transform.Rotate(Vector3.forward * -90);
            rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }

        directionsVertical = new int[,] { { 0, 3 }, { 0, -3 }};
        directionsHorizontal = new int[,] { { -3, 0 }, { 3, 0 } };
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (vertical)
        {
            rb.velocity = new Vector2(directionsVertical[i, 0] * speed, directionsVertical[i, 1] * speed); //Скорость персонажа
        } 
        else
        {
            rb.velocity = new Vector2(directionsHorizontal[i, 0] * speed, directionsHorizontal[i, 1] * speed); //Скорость персонажа
        }   
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Wall"))
        {
            if (i < 1)
            {
                ++i;
            }
            else
            {
                i = 0;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Cultist : MonoBehaviour
{
    [SerializeField] private FieldOfView fieldOfView; //надо почитать про это подробнее

    public AudioClip soulGasp;
    public AudioClip dzin;
    public AudioClip nomnom;
    public AudioClip KindaWinSound;
    public AudioClip LoseSound;

    Tilemap fog;
    public GameObject fogGameObject;

    Tilemap salt;
    public GameObject saltGameObject;

    public GameObject SaltPrefab;

    Rigidbody2D rb; //Физическая модель
    public float speed; //Множитель скорости

    public bool inSafeArea;

    public int saltCount;

    public void Gasp()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(soulGasp);
    }

    public void Dzin()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(dzin);
    }

    public void Lose()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(LoseSound);
    }

    public void KindaWin()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(KindaWinSound);
    }

    public void Win()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(nomnom);
    }

    public void NomNom()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(nomnom);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inSafeArea = true;
        saltCount = 0;

        salt = saltGameObject.GetComponent<Tilemap>();
        fog = fogGameObject.GetComponent<Tilemap>();
    }

    void FixedUpdate()
    {

        Vector2 moveDirection = rb.velocity;
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }


        fieldOfView.SetOrigin(transform.position);

        if (saltCount == 0 && !inSafeArea)
        {
            Instantiate(SaltPrefab, gameObject.transform.position, Quaternion.identity);
        }

        Move();
    }

    void Move()
    {
        float y = Input.GetAxisRaw("Vertical"); //Для того, чтобы понять, нажимаем ли мы вверх или вниз
        float x = Input.GetAxisRaw("Horizontal"); //Для того, чтобы понять, нажимаем ли мы влево или вправо

        rb.velocity = new Vector2(x * speed, y * speed); //Скорость персонажа
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 hitPosition = Vector3.zero;

        if (collision.gameObject.CompareTag("FogOfWar"))
        {
            foreach (ContactPoint2D hit in collision.contacts)
            {
                hitPosition.x = hit.point.x - 0.01f * hit.normal.x;
                hitPosition.y = hit.point.y - 0.01f * hit.normal.y;

                fog.SetTile(fog.WorldToCell(hitPosition), null);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("SafeArea"))
        {
            inSafeArea = true;

        }

        if (col.gameObject.CompareTag("Salt"))
        {
            speed = 4;
        }

        if (col.gameObject.CompareTag("Salt") || col.gameObject.CompareTag("NewSalt"))
        {
            ++saltCount;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("SafeArea"))
        {
            inSafeArea = false;
            GameObject.Find("Help").GetComponent<Animator>().SetTrigger("LeftSafeZone");
        }

        if (col.gameObject.CompareTag("Salt"))
        {
            speed = 2;
        }

        if (col.gameObject.CompareTag("Salt") || col.gameObject.CompareTag("NewSalt"))
        {
            --saltCount;
        }
    }
}

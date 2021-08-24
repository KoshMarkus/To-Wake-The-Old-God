using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    public bool beenHit = false;
    public float timeRemaining;

    GameMaster GameMaster;

    void Start()
    {
        GameMaster = GameObject.Find("GameMaster").GetComponent<GameMaster>();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            GameObject.Find("Cultist").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            beenHit = false;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemy") && beenHit == false)
        {
            GameObject.Find("Cultist").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 130f/225f);
            GameObject.Find("Cultist").GetComponent<Cultist>().Dzin();
            timeRemaining = 2;
            beenHit = true;
            GameMaster.Hurt();
        }

    }
}

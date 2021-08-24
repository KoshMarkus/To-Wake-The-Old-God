using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBottle : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}

    public void SoulCnahge(int souls)
    {
        switch (souls)
        {
            case 0:
                gameObject.transform.Find("State1").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State2").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State3").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State4").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                break;
            case 1:
                gameObject.transform.Find("State1").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
            case 2:
                gameObject.transform.Find("State1").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State2").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
            case 3:
                gameObject.transform.Find("State2").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State3").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
            case 4:
                gameObject.transform.Find("State3").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                gameObject.transform.Find("State4").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
        }
    }

    public void HealthChange(int health)
    {
        switch (health)
        {
            case 2:
                gameObject.transform.Find("Break1").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
            case 1:
                gameObject.transform.Find("Break2").gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 1);
                break;
            case 0:
                Destroy(GameObject.Find("FieldOfView"));
                GameObject.Find("HurtReciever").GetComponent<Collider2D>().enabled = false;
                GameObject.Find("Win").GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                GameObject.Find("Cultist").GetComponent<Cultist>().Win();
                Destroy(gameObject);
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : MonoBehaviour
{

    //Когда коллайдеры культиста и души сталкиваются
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cultist"))
        {
            GameObject.Find("Cultist").GetComponent<Cultist>().Gasp();
            GameObject.Find("GameMaster").GetComponent<GameMaster>().SoulPickedUp(); 
            Destroy(gameObject);
        }
    }

}

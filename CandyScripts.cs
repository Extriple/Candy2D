using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScripts : MonoBehaviour
{
    void Start()
    {
        

    }

    void Update()
    {
        

    }
    //Funckja, która wprowadza interakcje za kazdym razem, gdy cukierki spadną na naszego stworka
     void OnTriggerEnter2D(Collider2D collider)
    {
        //Pamietaj, żeby zaznaczyć w Unity --> Player ----> Tag ---> Player
        if (collider.gameObject.tag == "Player")
        {
            //Inkrementacja punktów
           
            Destroy(gameObject);
            GameMenager.instance.IncrementalScore();
        }

        //Ustalamy granice spadania cukierków, które nie złapie stworek. Po dotknięciu fikcyjnej granicy cukierki zostaną zniszczone
        else if (collider.gameObject.tag =="Boundary")
        {
            //Dekrementacja pumtków życia
            GameMenager.instance.DecreaseLife();
            Destroy(gameObject);
            

        }

    }
}







using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public bool CanMove = true;

    //Maksymalna pozycja poruszania sie po mapie w prawo i lewo
    [SerializeField]
    float maxPos;

    //Ten atrybut będzie dostepny dla całego edytora.
    [SerializeField]
    float moveSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        if (CanMove)
        {
            Move();
        }
    }

    private void Move()
    {
        //Funcja Nadaje obiektowi możwliość poruszania się
        float inputX = Input.GetAxis("Horizontal");

        //Ustawiamy poruszanie  
        transform.position += Vector3.right * inputX * moveSpeed * Time.deltaTime;

        //Funcja określająca maksymalną stefę, w której obiekt może sie poruszać 
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);

        //Ustawianie max pozycji obiektu
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);



    }
}

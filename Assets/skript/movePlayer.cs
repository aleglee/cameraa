using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movePlayer : MonoBehaviour
{
    // т.к. логика движения изменилась мы выставили меньшее и более стандартное значение
    public float Speed = 5f;
 
    public Rigidbody _rb;
 
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
 
 
    void FixedUpdate()
    {
        // в даном случае допустимо использовать это здесь, но можно и в Update.
        // но раз уж вызываем здесь, то 
        // двигать будем используя множитель fixedDeltaTimе 
        MovementLogic();
    }
 
    private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
 
        float moveVertical = Input.GetAxis("Vertical");
 
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
 
        // что бы скорость была стабильной в любом случае
        // и учитывая что мы вызываем из FixedUpdate мы умножаем на fixedDeltaTimе
        transform.Translate(movement * Speed * Time.fixedDeltaTime);
    }
}
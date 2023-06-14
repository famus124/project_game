using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_event : MonoBehaviour
{
    private CharacterController controller;
    public int playerSpeed;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }
}

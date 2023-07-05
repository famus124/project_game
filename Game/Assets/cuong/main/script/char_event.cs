using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class char_event : MonoBehaviour
{
    private CharacterController controller;
    public int playerSpeed;
    private double health;
    public double base_health = 100;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        set_player_health(base_health);
    }

    
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        controller.Move(move * Time.deltaTime * playerSpeed);
    }

    public void set_player_health(double val)
    {
        health = val;
    }

    public void change_health(double val)
    {
        health += val;
    }

}

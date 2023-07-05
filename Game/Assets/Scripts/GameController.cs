using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    char_event Char;

    void Start()
    {
        Char = FindObjectOfType<char_event>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_event : MonoBehaviour
{
    // Start is called before the first frame update
    char_event ThePlayer;
    void Start()
    {
        ThePlayer = FindObjectOfType<char_event>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            ThePlayer.change_health(-5.0);
            Debug.Log("Va cham");
        }
    }

}

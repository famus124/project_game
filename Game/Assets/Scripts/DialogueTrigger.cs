using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    void Start() { 
    }
    void Update() { }

    public class Message
    {
        public int actorID;
        public string message;
    }

    public class Actor
    {
        public string name;
    }

}

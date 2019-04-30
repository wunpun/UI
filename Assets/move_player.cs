using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_player : MonoBehaviour
{
   public void move()
    {
        transform.position = GameObject.Find("go").transform.position;
    }
}

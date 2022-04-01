using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositioning : MonoBehaviour
{
    public GameObject Player;
    void Start()
    {
        this.transform.position = Player.transform.position;
    }

}

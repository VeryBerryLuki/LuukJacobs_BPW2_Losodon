using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainPosition : MonoBehaviour
{
    public GameObject Rain;
    public GameObject Player;
    public Vector3 RainHeight;

    // Update is called once per frame
    void Update()
    {
        Rain.transform.position = Player.transform.position + RainHeight;
    }
}

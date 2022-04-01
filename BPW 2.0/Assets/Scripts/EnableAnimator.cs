using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAnimator : MonoBehaviour
{
    public Animator ToBeAnimated;
    // Start is called before the first frame update
    void Start()
    {
        ToBeAnimated.enabled = true;
    }
}

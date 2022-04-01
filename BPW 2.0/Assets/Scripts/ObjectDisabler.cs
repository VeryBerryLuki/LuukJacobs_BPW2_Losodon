using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDisabler : MonoBehaviour
{
    public GameObject[] ToBeDisabled;
    public GameObject[] ToBeEnabled;
    private void Start()
    {
        for (int i = 0; i < ToBeDisabled.Length; i++)
        {
            ToBeDisabled[i].SetActive(false);
        }
        for (int i = 0; i < ToBeEnabled.Length; i++)
        {
            ToBeEnabled[i].SetActive(true);
        }
    }
}

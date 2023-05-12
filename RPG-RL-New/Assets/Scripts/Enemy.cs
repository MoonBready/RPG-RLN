using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, Interactable
{
    public void Interact()
    {
        Debug.Log("Battle");
    }
}

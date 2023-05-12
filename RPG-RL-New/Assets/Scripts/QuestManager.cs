using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public string questName;
    public string description;
    public Goal goal;
    public bool completed;
    public List<string> rewards;

    public virtual void Complete()
    {
        Debug.Log("Completed");
        GiveReward();
    }

    public void GiveReward()
    {
        Debug.Log("Turn in");
        foreach(string item in rewards)
        {
            Debug.Log("Reward");
        }

        Destroy(this);
    }
}

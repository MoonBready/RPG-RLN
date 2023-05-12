using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal
{
    public int countNeeded;
    public int countCurrent;
    public bool completed;
    public QuestManager quest;

    public void Increment(int amount)
    {
        countCurrent = Mathf.Min(countCurrent + 1, countNeeded);

        if(countCurrent >= countNeeded && !completed)
        {
            this.completed = true;
            Debug.Log("completed");
            quest.Complete();
        }
    }

}

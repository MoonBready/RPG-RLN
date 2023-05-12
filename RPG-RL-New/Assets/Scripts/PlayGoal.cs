using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGoal : Goal
{
    public int catID;

    public PlayGoal(int amountNeeded, int catID, QuestManager quest)
    {
        countCurrent = 0;
        countNeeded = amountNeeded;
        completed = false;
        this.quest = quest;
        this.catID = catID;
    }

    void CatInteracted(int catID)
    {
        if (this.catID == catID)
        {
            Increment(1);
        }
    }
}

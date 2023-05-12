using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayCatQuest : QuestManager
{
    private void Awake()
    {
        questName = "Your Old Friend";
        description = "Play with your cats";
        rewards = new List<string>() { "Remembrance", "+5 Happiness"};
        goal = new PlayGoal(2, 0, this);
    }

    public override void Complete()
    {
        base.Complete();
    }
}

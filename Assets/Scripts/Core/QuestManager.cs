using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    private HashSet<string> completedQuests = new HashSet<string>();

    void Awake()
    {
        Instance = this;
    }

    public void CompleteQuest(string questID)
    {
        if (!completedQuests.Contains(questID))
        {
            completedQuests.Add(questID);
            Debug.Log("Quest Completed: " + questID);
        }
    }

    public bool IsCompleted(string questID)
    {
        return completedQuests.Contains(questID);
    }
}
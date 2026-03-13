using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject letterUI;
    public GameObject promptUI;

    public string questID;
    public int emotionGain = 0;

    bool playerNearby = false;

    public void Interact()
    {
        if (letterUI != null)
            letterUI.SetActive(true);

        if (!string.IsNullOrEmpty(questID))
            QuestManager.Instance.CompleteQuest(questID);

        if (emotionGain != 0)
            EmotionManager.Instance.AddEmotion(emotionGain);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;

            if (promptUI != null)
                promptUI.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;

            if (promptUI != null)
                promptUI.SetActive(false);
        }
    }

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            if (letterUI != null)
                letterUI.SetActive(true);

            if (promptUI != null)
                promptUI.SetActive(false);

            if (!string.IsNullOrEmpty(questID))
                QuestManager.Instance.CompleteQuest(questID);

            if (emotionGain != 0)
                EmotionManager.Instance.AddEmotion(emotionGain);

            Destroy(gameObject);
        }
    }
}
using UnityEngine;

public class EmotionManager : MonoBehaviour
{
    public static EmotionManager Instance;

    [Range(0, 100)]
    public int closeness = 50;

    void Awake()
    {
        Instance = this;
    }

    public void AddEmotion(int amount)
    {
        closeness = Mathf.Clamp(closeness + amount, 30, 100);
        Debug.Log("Emotion Level: " + closeness);
    }
}
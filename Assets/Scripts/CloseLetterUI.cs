using UnityEngine;

public class CloseLetterUI : MonoBehaviour
{
    public GameObject letterUI;

    public void CloseUI()
    {
        letterUI.SetActive(false);
    }
}
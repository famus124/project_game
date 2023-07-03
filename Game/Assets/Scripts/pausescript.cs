using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pausescript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject resumeButton;
    public void clickPause()
    {
        Time.timeScale = 0f;
        resumeButton.SetActive(true);
    }
    public void clickResume()
    {
        Time.timeScale = 1f;
        resumeButton.SetActive(false);
    }
}

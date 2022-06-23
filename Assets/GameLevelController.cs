using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLevelController : MonoBehaviour
{
    [SerializeField] Image easy;
    [SerializeField] Image medium;
    [SerializeField] Image hard;

    [SerializeField] Sprite unTicked;
    [SerializeField] Sprite ticked;

    [SerializeField] GameObject levelObject;
    private void Start()
    {
        levelObject.SetActive(false);

        if (PlayerPrefs.GetInt("level") <= 0)
        {
            SetEasyLevel();
        }

        UpdateLevel(PlayerPrefs.GetInt("level"));
    }

    public void SetEasyLevel()
    {
        PlayerPrefs.SetInt("level", 1);
        UpdateLevel(1);
    }

    public void SetMediumLevel()
    {
        PlayerPrefs.SetInt("level", 2);
        UpdateLevel(2);
    }

    public void SetHardLevel()
    {
        PlayerPrefs.SetInt("level", 3);
        UpdateLevel(3);
    }

    public void UpdateLevel(int level)
    {
        easy.color = Color.white;
        medium.color = Color.white;
        hard.color = Color.white;

        if (level == 1)
        {
            easy.color = Color.green;
        }
        else if (level == 2)
        {
            medium.color = Color.green;
        }
        else if (level == 3)
        {
            hard.color = Color.green;
        }

        OpenLevel(false);
    }

    public void OpenLevel(bool isEnable)
    {
        levelObject.SetActive(isEnable);
    }
}

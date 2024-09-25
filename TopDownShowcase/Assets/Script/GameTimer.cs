using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    float timer = 0;
    [SerializeField]
    float gameLength = 20f;
    [SerializeField]
    string levelToLoad = "Win";
    [SerializeField]
    Image clock;
    // Start is called before the first frame update
    void Start()
    {
        clock.fillAmount = timer / gameLength;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        clock.fillAmount = timer / gameLength;
        if(timer >= gameLength)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}

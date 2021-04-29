using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    private Transform entrycontainer;
    private Transform entrytemplate;

    private void Awake()
    {
        entrycontainer = transform.Find("HighScoreEntryContainer");
        entrytemplate = entrycontainer.Find("HighScoreEntryTemplate");

        entrytemplate.gameObject.SetActive(false);

        float templateHeight = 30f;
        for (int i = 0; i < 10; i++)
        {
            Transform entryTransform = Instantiate(entrytemplate, entrycontainer);
            RectTransform entryReactTransform = entryTransform.GetComponent<RectTransform>();
            entryReactTransform.anchoredPosition = new Vector2(0, -templateHeight * i);

            int rank = i + 1;
            string rankString;
            switch (rank) {

                default:
                    rankString = rank + "TH"; break;
                case 1: rankString = "1ST"; break;
                case 2: rankString = "2ND"; break;
                case 3: rankString = "3RD"; break;
                  }
            entryTransform.Find("posText").GetComponent<Text>().text = rankString;

            int score = Random.Range(0, 10000);
            entryTransform.Find("scoreText").GetComponent<Text>().text = score.ToString();

            string name = "AAA";
            entryTransform.Find("nameText").GetComponent<Text>().text = "";


        }
    }
}

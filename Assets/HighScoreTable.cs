//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class HighScoreTable : MonoBehaviour
//{
//    private Transform entryContainer;
//    private Transform entryTemplate;
//    private List<HighscoreEntry> highscoreEntryList;
//    private List<Transform> highscoreEntryTransformList;

//    private void Awake()
//    {
//        entryContainer = transform.Find("HighscoreEntryContainer");
//        entryTemplate = entryContainer.Find("highscoreEntry");

//        entryTemplate.gameObject.SetActive(false);

//        highscoreEntryList = new List<HighscoreEntr>
        
//    }
//    private void CreateHighscoreEntryTransform(HighscoreEntry highscoreEntry, Transform container, List<Transform>transformList)
//    {
//        float templateHeight = 30f;
//        Transform entryTransform = Instantiate(entryTemplate, container);
//        RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
//        entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * transformList.Count);
//        entryTransform.gameObject.SetActive(true);

//        int rank = transformList.Count + 1;
//        string rankString;
//        switch (rank)
//        {
//            default:
//                rankString = rank + "TH"; break;
//            case 1: rankString = "1ST"; break;
//            case 2: rankString = "2ND"; break;
//            case 3: rankString = "3RD"; break;
//        }
//        entryTransform.Find("Pos").GetComponent<Text>().text = rankString;
//        int score = highscoreEntry.score;
//        entryTransform.Find("Score").GetComponent<Text>().text = score.ToString();
//        string name = highscoreEntry.name;
//        entryTransform.Find("Name").GetComponent<Text>().text = name;

//        transformList.Add(entryTransform);
//    }

//    private class HighscoreEntry
//    {
//        public int score;
//        public string name;
//    }

//}

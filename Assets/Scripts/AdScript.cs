using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrazyGames;

public class AdScript : MonoBehaviour
{
    public void AdWatch()
    {
        CrazyAds.Instance.beginAdBreak();
    }
}

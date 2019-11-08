using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Transform player;
    public Text score; 

    // Update is called once per frame
    void Update()
    {
        score.text = (21 + player.position.z).ToString("0");
    }
}

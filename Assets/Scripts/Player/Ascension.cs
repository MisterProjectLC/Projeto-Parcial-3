using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascension : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    CanvasGroup canvasGroupWhite;
    [SerializeField]
    CanvasGroup canvasGroupText;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > 5f)
        {
            canvasGroupWhite.alpha = Mathf.Lerp(0f, 1f, Mathf.Clamp01((player.transform.position.y - 5f)/ 40f));
            canvasGroupText.alpha = Mathf.Lerp(0f, 1f, Mathf.Clamp01((player.transform.position.y - 40f) / 10f));
        }
    }
}

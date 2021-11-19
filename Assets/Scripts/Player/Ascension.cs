using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascension : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    CanvasGroup canvasGroup;

    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > 5f)
        {
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, Mathf.Clamp01((player.transform.position.y - 5f)/ 10f));
        }
    }
}

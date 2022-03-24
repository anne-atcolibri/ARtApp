using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LikeCount : MonoBehaviour
{
    public Text likeText;

    int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        likeText.text = counter.ToString();
    }

    public void AddLike() {
	counter += 1;
	likeText.text = counter.ToString();
    }
}

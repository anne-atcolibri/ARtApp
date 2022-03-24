using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LikeButton : MonoBehaviour
{
	void Start() {
	var colors = GetComponent<Button> ().colors;
        colors.normalColor = Color.red;
        GetComponent<Button> ().colors = colors;
	}
}

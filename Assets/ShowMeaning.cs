using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowMeaning : MonoBehaviour {
    public GameObject term;

	// Update is called once per frame
	void Update () {
		if (term.transform.childCount > 3)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
	}
}

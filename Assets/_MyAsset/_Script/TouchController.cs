using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchController : MonoBehaviour {
    public GameObject GObject;
    public void OnMouseDown()
    {
        GObject.SetActive(true);
    }
}

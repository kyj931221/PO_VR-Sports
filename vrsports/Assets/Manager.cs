using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public void StartGame(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
}

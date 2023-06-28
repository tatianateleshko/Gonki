using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    [SerializeField] private string SceneName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneName);
    }
}

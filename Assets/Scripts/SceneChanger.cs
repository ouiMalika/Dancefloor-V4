using UnityEngine;
using UnityEngine.SceneManagement;
using ArenaUnity.Components;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    private string sceneName; // Name of the scene to load, can be set in the Inspector

    void Start()
    {
        // Ensure the game object has an ArenaClickListener component
        var clickListener = gameObject.AddComponent<ArenaClickListener>();
        clickListener.OnEventCallback += OnButtonClick;
    }

    private void OnButtonClick(string eventType, string msg)
    {
        if (eventType == "mousedown")
        {
            // Change to the specified scene
            if (!string.IsNullOrEmpty(sceneName))
            {
                SceneManager.LoadScene(sceneName);
            }
            else
            {
                Debug.LogError("Scene name is not set!");
            }
        }
    }
}

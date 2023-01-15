// using UnityEngine;

// public class LoadingManager : MonoBehaviour
// {
//     if(Input.GetKeyDown(KeyCode.F))
//     SceneManager.LoadScene(Level1);
// }

using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(1);
        }
    }
}

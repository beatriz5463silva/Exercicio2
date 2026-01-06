using UnityEngine;
using UnityEngine.SceneManagement;

public class inicio : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+ 1);
    }
}

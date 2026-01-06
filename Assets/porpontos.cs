using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class porpontos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody jogador;
    public TMP_Text contar;
    public AudioSource som;
    public AudioClip musicama;
    public AudioClip musicaboa;

    private void OnCollisionEnter(Collision quem)
    {
       if (quem.gameObject.tag == "moedasboas")
        {

            som.PlayOneShot(musicaboa);
            quem.gameObject.active = false;
   
        }
        else if (quem.gameObject.tag == "cubinhos")
        {
            som.PlayOneShot(musicama);
        }
    }

            void Start()
            {

            }

    // Update is called once per frame
    void Update()
    {

        
        jogador.AddForce(0, 0, 10);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            jogador.AddForce(-3, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            jogador.AddForce(3, 0, 0);
        } 


    }

}

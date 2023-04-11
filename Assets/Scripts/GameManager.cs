using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace RayWenderlich.SpaceInvadersUnity
{
    public class GameManager : MonoBehaviour
    {
        

        [SerializeField]
        private AudioSource sound;

        internal void PlaySound(AudioClip clip) => sound.PlayOneShot(clip);


        //singleton паттерн

        internal static GameManager instance;
        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }

            else if(instance !=  this)
            {
                Destroy(gameObject);
            }
        }

    }
}
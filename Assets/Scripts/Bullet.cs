using UnityEngine;

namespace RayWenderlich.SpaceInvadersUnity
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private float speed = 200f;
        [SerializeField]
        private float lifeTime = 5f;

        //уничтожение игрового объекта-пули
        internal void DestroySelf()
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

        //автоматическое уничтожение по истечении времени
        private void Awake()
        {
            Invoke("DestroySelf", lifeTime);
        }

        private void Update()
        {
            transform.Translate(speed*Time.deltaTime * Vector2.up); //перемещение пули со скоростью spee каждый кадр вверх
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            DestroySelf();  
        }
    }
}

using UnityEngine;

namespace RayWenderlich.SpaceInvadersUnity
{
    public class CannonControl : MonoBehaviour
    {
        //-----------перемещение----------------------------
        [SerializeField]
        private float speed = 400f;
        //-----------стрельба -----------------------------------
        [SerializeField]
        private Transform muzzle; //позиция дула
        [SerializeField]
        private AudioClip shooting;
        [SerializeField]
        private float coolDownTime = 0.5f;
        [SerializeField]
        private Bullet bulletPrefab;
        private float shootTimer;


        private void Update()
        {
            //-----------перемещение----------------------------
            if (Input.GetKey(KeyCode.D))
                transform.Translate(speed*Time.deltaTime, 0, 0);
            else if (Input.GetKey(KeyCode.A))
                transform.Translate(-speed*Time.deltaTime, 0, 0);
            //-----------стрельба -----------------------------------
            shootTimer += Time.deltaTime;
            if (shootTimer > coolDownTime && Input.GetKey(KeyCode.Space))
            {
                shootTimer = 0f;
                Instantiate(bulletPrefab, muzzle.position, Quaternion.identity);
                GameManager.instance.PlaySound(shooting);
            }


        }
}
using UnityEngine;

namespace MiniGame1.ObjectPooling
{
    public class BulletPooling : GenericPool<Proyectile>
    {
        [Header("Bullet Pooling Settings")] [SerializeField]
        private Transform spawnBullet;

        protected override void OnTakeFromPool(Proyectile item)
        {
            base.OnTakeFromPool(item);
            item.SetPool(Pool);
        }

        public void SpawnBullet()
        {
            Proyectile bullet = Pool.Get();
            bullet.transform.position = spawnBullet.position;
        }
    }
}
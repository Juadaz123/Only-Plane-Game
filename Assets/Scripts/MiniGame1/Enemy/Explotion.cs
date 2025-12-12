using UnityEngine;
using UnityEngine.Pool;

namespace Enemy.Enemy
{
    public class Explotion : MonoBehaviour
    {
        private IObjectPool<Explotion> _pool;
        
        public void SetPool(IObjectPool<Explotion> pool)
        {
            _pool = pool;
        }

        private void OnEnable()
        {
            Invoke("ReturnToPool", 1f);
        }

        public void ReturnToPool()
        {
            _pool.Release(this);
            
        }

    }
}
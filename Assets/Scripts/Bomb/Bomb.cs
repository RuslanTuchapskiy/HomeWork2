using UnityEngine;

public class Bomb : MonoBehaviour
{
     [SerializeField] private float _damage;
     
     public float Damage => _damage;
}

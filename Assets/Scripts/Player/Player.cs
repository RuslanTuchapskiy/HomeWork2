using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private float _healthPoint;
    
    private float _score;

    private void Start() => _healthText.text = _healthPoint.ToString();

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);

            _score += coin.Value;
            _scoreText.text = _score.ToString();
        }
        else if (other.TryGetComponent(out Bomb bomb))
        {
            if (_healthPoint > 0f)
            {
                Destroy(bomb.gameObject);
                _healthPoint-=bomb.Damage;
                _healthText.text = _healthPoint.ToString();

                if (_healthPoint <= 0f)
                    Destroy(gameObject);
            }
        }
    }
}

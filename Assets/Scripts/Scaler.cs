using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _frequency = 1;
    [SerializeField] private float _amplituda = 1;

    private Vector3 _startScale;
    private float _referenceValue = 1;

    private void Start()
    {
        _startScale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale = _startScale * (Mathf.Sin(Time.time * _frequency) * _amplituda + _referenceValue);
    }
}

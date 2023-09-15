using UnityEngine;

public class SinMover : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _distance = 1;

    private void Update()
    {
        transform.localPosition = new Vector3(0, 0, Mathf.Sin(Time.time * _speed)) * _distance;
    }
}

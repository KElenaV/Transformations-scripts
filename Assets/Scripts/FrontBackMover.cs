using UnityEngine;

public class FrontBackMover
    : MonoBehaviour
{
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _minDistance;
    [SerializeField] private float _maxDistance;

    private void Update()
    {
        float distance = transform.position.z;

        if (distance <= _minDistance)
        {
            ChangeDirection(_minDistance);
        }
        else if(distance >= _maxDistance)
        {
            ChangeDirection(_maxDistance);
        }

        transform.Translate(0, 0, _speed * Time.deltaTime);
    }

    private void ChangeDirection(float currentDistance)
    {
        transform.position = new Vector3(0,0,currentDistance);
        _speed *= -1;
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EntitySpawner : MonoBehaviour
{
    [SerializeField]
    private Path _path = null;

    [SerializeField]
    private PathFollower _pathFollower = null;

    [SerializeField]
    private float _waitingTimeBetweenEntities = 1f;

    private float _currentWaitingTime = 0;

    private void Start()
    {
        _currentWaitingTime = _waitingTimeBetweenEntities;
    }

    private void Update()
    {
        _currentWaitingTime += Time.deltaTime;
        if (_currentWaitingTime >= _waitingTimeBetweenEntities)
        {
            CreateEntity();
            _currentWaitingTime = 0;
        }
    }

    void CreateEntity()
    {
        PathFollower pathFollower = Instantiate(_pathFollower, transform);
        pathFollower.transform.position = _path.GetWaypoint(0);
        pathFollower.SetPath(_path);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]float _speed=2f;
        private void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * _speed, 0);

    }
}

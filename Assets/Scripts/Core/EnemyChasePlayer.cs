
using System;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    private Transform _player;

    private void Start()
    {
        _player = Player.instance.transform;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, _player.position) > 2f)
        {
            this.transform.position = Vector2.MoveTowards(transform.position, _player.position, (2f / 3f) * Time.deltaTime);
        }
    }
}

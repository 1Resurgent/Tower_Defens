using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

namespace Project.Skript.Towers
{
    /// <summary>
    /// 1) Взять всех врагов +
    /// 2) Найти врага, самого ближайшего к башне и чтобы он был в радиусе атаки +
    /// 3) Начинаем атаковать врага
    /// 4) Спавним пулю и говорим ей лететь во врага
    /// 5) Каждый кадр игры мы двигаем пулю к врагу
    /// 6) Когда пуля долетела, мы убиваем врага и уничтожаем пулю
    /// 7) Вернёмся к 1)
    /// </summary>
    public class Tower : MonoBehaviour
    {
        [SerializeField] private float AttackRange;
        [SerializeField] private float Cooldown;

        private void Start()
        {
            StartCoroutine(AttackProcess());
        }

        private IEnumerator AttackProcess()
        {
            while (true)
            {
                var enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None).ToList();
                var enemiesInRange = new List<Enemy>();
                foreach (var enemy in enemies)
                {
                    if (Vector3.Distance(transform.position, enemy.transform.position) < AttackRange)
                    {
                        enemiesInRange.Add(enemy);
                    }
                }

                Enemy closestEnemy = null;
                float closestDistance = float.MaxValue;

                foreach (var enemy in enemiesInRange)
                {
                    var distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                    if (distanceToEnemy < closestDistance)
                    {
                        closestDistance = distanceToEnemy;
                        closestEnemy = enemy;
                    }
                }

                if (closestEnemy == null)
                {
                    yield return null;
                }
                else
                {
                    Destroy(closestEnemy.gameObject);
                    yield return new WaitForSeconds(Cooldown);
                }

            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(transform.position, AttackRange);
        }
    }
}
﻿using System;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrew.Components.Health
{
    public class HealthComponent : MonoBehaviour
    {
        [SerializeField] private int _health;
        [SerializeField] private UnityEvent _onDamage;
        [SerializeField] private UnityEvent _onHeal;
        [SerializeField] public UnityEvent _onDie;
        [SerializeField] public HealthChangeEvent _onChange;
        [SerializeField] private bool _immune;

        public int Health => _health;

        public bool Immune
        {
            get => _immune;
            set => _immune = value;
        }

        public void ModifyHealth(int healthDelta)
        {
            if (healthDelta < 0 && Immune) return;
            if (_health <= 0) return;

            _health += healthDelta;
            _onChange?.Invoke(_health);

            if (healthDelta < 0)
            {
                _onDamage?.Invoke();
            }

            if (healthDelta > 0)
            {
                _onHeal?.Invoke();
            }

            if (_health <= 0)
            {
                _onDie?.Invoke();
            }
        }

#if UNITY_EDITOR
        [ContextMenu("Update Health")]
        private void UpdateHealth()
        {
            _onChange?.Invoke(_health);
        }
#endif

        public void SetHealth(int health)
        {
            _health = health;
        }

        private void OnDestroy()
        {
            _onDie.RemoveAllListeners();
        }

        [Serializable]
        public class HealthChangeEvent : UnityEvent<int>
        {
        }
    }
}
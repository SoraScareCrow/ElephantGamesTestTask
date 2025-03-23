using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimAndSoundOnClick : MonoBehaviour
{
    [Header("Анимация")]
    public Animator animator;
    public string animationStateName;

    [Header("Звук")]
    public AudioSource audioSource; 
    public AudioClip audioClip;

    [Header("Визуальный эффект")]
    public GameObject attackEffectPrefab;        // Префаб эффекта (вспышка, частицы и т.д.)
    public Transform effectSpawnPoint;           // Точка появления эффекта
    public float effectDestroyDelay = 2f;        // Через сколько секунд уничтожить эффект
    public float effectDelay = 0.5f;              // Задержка перед эффектом

    void OnMouseDown()
    {
        Debug.Log("Есть!");

        // Запускаем анимацию
        if (animator != null && !string.IsNullOrEmpty(animationStateName))
            animator.Play(animationStateName);

        // Проигрываем звук
        if (audioSource != null && audioClip != null)
            audioSource.PlayOneShot(audioClip);

        // Запускаем задержку перед эффектом
        if (attackEffectPrefab != null && effectSpawnPoint != null)
            StartCoroutine(SpawnEffectWithDelay());
    }

    IEnumerator SpawnEffectWithDelay()
    {
        yield return new WaitForSeconds(effectDelay);

        GameObject effect = Instantiate(attackEffectPrefab, effectSpawnPoint.position, Quaternion.identity);
        Destroy(effect, effectDestroyDelay);
    }
}

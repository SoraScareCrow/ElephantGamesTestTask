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
    public GameObject attackEffectPrefab;        
    public Transform effectSpawnPoint;           
    public float effectDestroyDelay = 2f;       
    public float effectDelay = 0.5f;            

    void OnMouseDown()
    {
        Debug.Log("Есть!");

     
        if (animator != null && !string.IsNullOrEmpty(animationStateName))
            animator.Play(animationStateName);

   
        if (audioSource != null && audioClip != null)
            audioSource.PlayOneShot(audioClip);

     
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

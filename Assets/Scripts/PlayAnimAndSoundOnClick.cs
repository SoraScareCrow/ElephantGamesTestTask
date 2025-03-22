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
    
    void OnMouseDown()
    {
        Debug.Log("Есть!");

        // Запускаем анимацию
        animator.Play(animationStateName);

        // Проигрываем звук
        // PlayOneShot не прерывает аудио, если оно уже идёт, а накладывает поверх
        // Если хотите стопроцентно один звук без наложений — используйте audioSource.Stop() перед Play().
        audioSource.PlayOneShot(audioClip);
    }
}

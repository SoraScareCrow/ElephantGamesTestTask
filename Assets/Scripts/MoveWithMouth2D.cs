using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse2D : MonoBehaviour
{
    [Header("Настройки движения")]
    // Насколько сильно объект будет двигаться по оси X и Y
    public float xFactor = 1.0f;
    public float yFactor = 0.5f;

    void Update()
    {
        // Берём текущие экранные координаты мыши
        Vector3 mouseScreenPos = Input.mousePosition;

        // Переводим экранные координаты в мировые
        // (для этого берём камеру main — по умолчанию основную)
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        // Сохраняем Z, чтобы объект не «улетел» на другой слой
        mouseWorldPos.z = transform.position.z;

        // Применяем «силу» движения по X и Y
        // Чем больше xFactor, тем сильнее смещение по X
        // Чем меньше yFactor, тем слабее движение по Y
        mouseWorldPos.x *= xFactor;
        mouseWorldPos.y *= yFactor;

        // Обновляем позицию нашего объекта
        transform.position = mouseWorldPos;
    }
}


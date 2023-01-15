using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteraction : MonoBehaviour
{
    [SerializeField] private float _range = 10.0f;

    private Interactable _task;

    // Update is called once per frame
    void Update()
    {
        Interactable newTask = null;
        Interactable[] targetsList = FindObjectsOfType<Interactable>();

        foreach (Interactable task in targetsList)
        {
            float distance = Vector3.Distance(transform.position, task.transform.position);

            if (distance > _range) {
                continue;
            }

            newTask = task;
            UIController.instance.currentTask = _task;

            break;
        }


        if (UIController.instance.currentTask != newTask
            && UIController.instance.currentTask != null) {
            UIController.instance.currentTask.Use(false);
        }

        _task = newTask;
        UIController.instance.currentTask = _task;
    }
}

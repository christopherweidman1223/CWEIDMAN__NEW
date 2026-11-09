using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        Debug.Log("Something entered the goal: " + collidedWith.name);

        if (collidedWith.CompareTag(gameObject.tag))
        {
            isSolved = true;

            Light[] lights = GetComponentsInChildren<Light>();

            foreach (Light light in lights)
            {
                light.enabled = false;
            }

            Destroy(collidedWith);
            Debug.Log("Correct ball! Goal completed!");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStats : MonoBehaviour
{
    [Header("Size")]
    [SerializeField] private float currentSize;
    [SerializeField] private float maxSize;
    [SerializeField] private float growthRate; //Base growth rate (modify the growth by the current saturation. Less saturation => slower growth)

    [Header("Speed")]
    [SerializeField] private float currentSpeed;
    [SerializeField] private float maxSpeed;

    [Header("Saturation")]
    [SerializeField] private float currentSaturation;
    [SerializeField] private float maxSaturation;
    [SerializeField] private float saturationDecreaseRate;
    [SerializeField] private enum FoodTypes { meat, vegetables, fruit };
    [SerializeField] private FoodTypes[] edibleFoodTypes;

    [Header("Sleep")]
    [SerializeField] private bool sleeping;
    [SerializeField] private float currentFatigue;
    [SerializeField] private float maxFatigue;
    [SerializeField] private float fatigueIncreaseRate; //How fast the creature gets tired
    [SerializeField] private float fatigueRestorationRate; //How fast the creature regains fatigue while sleeping

    [Header("Sex")]
    [SerializeField] private float sexDrive;
    [SerializeField] private float fertility;
    [SerializeField] private Vector2 amountOfChildrenPerPregnancy;

    [Header("Interactions")]
    [SerializeField] private float communityDrive;
    [SerializeField] private float hostility;

    [Header("Death")]
    [SerializeField] private float currentDecay;
    [SerializeField] private float decayRate;
}

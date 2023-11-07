using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    protected Vector3 chidleScale = new Vector3(0.5f,0.5f,0.5f);

    [SerializeField]
    protected SpeciesType species;

    [SerializeField]
    protected Status status;
}

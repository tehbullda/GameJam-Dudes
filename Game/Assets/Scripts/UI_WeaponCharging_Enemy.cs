using UnityEngine;
using System.Collections;

public class UI_WeaponCharging_Enemy : MonoBehaviour
{
    public AudioClip[] CannonFire;
    public AudioClip[] CannonMiss;
    private int currentCharge = 0;
    public GameObject EnemyTarget;
    public GameObject CannonImpactObjectType;
    // Use this for initialization
    void Start()
    {
        currentCharge = 0;
    }

    // Update is called once per frame
    public float percentage;
    void Update()
    {
        if (Globals.eState == Globals.GameState.ENCOUNTER && !Globals.GamePaused && Globals.eEncounter == Globals.EncounterType.BOAT)
        {
            ++currentCharge;
            if (currentCharge >= 100)
            {
                currentCharge = 0;
                if (CannonFire.Length > 0)
                {
                    int iSoundNr = Random.Range(0, CannonFire.Length);
                    if (CannonFire[iSoundNr])
                    {
                        audio.clip = CannonFire[iSoundNr];
                        audio.Play();
                    }
                }
                float AttackAccuracy = Random.Range(0.0f, 1.0f);
                if (AttackAccuracy > Globals.Evasion)
                {
                    Globals.PlayerHP -= 10;

                    Vector3 impactEffectOffset = EnemyTarget.transform.position;
                    impactEffectOffset.x += Random.Range(-0.5f, 0.5f);
                    impactEffectOffset.y += Random.Range(-0.5f, 0.5f);
                    impactEffectOffset.z = CannonImpactObjectType.transform.position.z;
                    Instantiate(CannonImpactObjectType, impactEffectOffset, CannonImpactObjectType.transform.rotation);
                }
                else
                {
                    if (CannonMiss.Length > 0)
                    {
                        int iSoundNr = Random.Range(0, CannonMiss.Length);
                        if (CannonMiss[iSoundNr])
                        {
                            audio.clip = CannonMiss[iSoundNr];
                            audio.Play();
                        }
                    }
                }
            }
            //Scale from 0 to 0.923
            //Position from -4.77 to 0.04
            percentage = currentCharge / 100.0f;
            float nextpos = 4.81f * percentage;
            nextpos -= 4.77f;
            float nextscale = 0.923f * percentage;
            if (nextscale < 0.0f)
            {
                nextscale = 0.0f;
            }
            if (nextscale > 0.923f)
            {
                nextscale = 0.923f;
            }
            if (nextpos > 0.04f)
            {
                nextpos = 0.04f;
            }
            else if (nextpos < -4.77f)
            {
                nextpos = -4.77f;
            }

            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, nextscale);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, nextpos);

            if (gameObject.layer != 5 && Globals.bCrowsnestManned)
            {
                gameObject.layer = 5;
            }

        }
        else
        {
            if (gameObject.layer != 8)
            {
                gameObject.layer = 8;
            }
        }
    }
}

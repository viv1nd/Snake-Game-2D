using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shieldpowerup : Eatable
{
    public override void OnDigest()
    {
        GameManager.Instance.Sheild();
        base.OnDigest();

    }
}

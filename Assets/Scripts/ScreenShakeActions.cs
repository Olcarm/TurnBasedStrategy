using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeActions : MonoBehaviour
{
    
    private void Start() {
        ShootAction.OnAnyShoot += ShootAction_OnAnyShoot;
        GrenadeProjectile.OnAnyGrenadeExploded += GrenadeProjectile_OnAnyGrenadeExploded;
        SwordAction.OnAnySwordHit += SwordAction_OnAnySwordhit;
    }

    private void SwordAction_OnAnySwordhit(object sender, EventArgs e)
    {
        ScreenShake.Instance.Shake(2f);
    }

    private void ShootAction_OnAnyShoot(object sender, EventArgs e){
        ScreenShake.Instance.Shake();
    }
    private void GrenadeProjectile_OnAnyGrenadeExploded(object sender, EventArgs e){
        ScreenShake.Instance.Shake(5f);
    }


}

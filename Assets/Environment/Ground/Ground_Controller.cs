using UnityEngine;
using System.Collections;

public class Ground_Controller : BaseClass {
    public Color overlay_color_on_enemy_hit;
    void HitByEnemy()
    {
        LoseLife();
        Color old_color = GetColor();
        Color new_color = MixColor(overlay_color_on_enemy_hit, old_color, 0.5f);
        SetTemporaryColor(new_color, 0.2f);
    }
}

using UnityEngine;
using System.Collections;

public class Ground_Controller : BaseClass {
    public Color overlay_flash_color;
    void Flash()
    {
        Color old_color = GetColor();
        Color new_color = MixColor(overlay_flash_color, old_color, 0.5f);
        SetTemporaryColor(new_color, 0.2f);
    }
}

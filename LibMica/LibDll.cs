﻿using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LibMica
{
    public static class LibDll
    {
        #region Dll Import

        [DllImport("dwmapi.dll")]
        internal static extern IntPtr DwmSetWindowAttribute(IntPtr hwnd, DwmSetWindowAttributeFlags dwAttribute, ref int pvAttribute, int cbAttribute);

        #endregion

        #region Dll Enum

        public enum DwmSetWindowAttributeFlags
        {
            DWM_NCRENDERING_ENABLED,
            DWM_NCRENDERING_POLICY,
            DWM_TRANSITIONS_FORCEDISABLED,
            DWM_ALLOW_NCPAINT,
            DWM_CAPTION_BUTTON_BOUNDS,
            DWM_NONCLIENT_RTL_LAYOUT,
            DWM_FORCE_ICONIC_REPRESENTATION,
            DWM_FLIP3D_POLICY,
            DWM_EXTENDED_FRAME_BOUNDS,
            DWM_HAS_ICONIC_BITMAP,
            DWM_DISALLOW_PEEK,
            DWM_EXCLUDED_FROM_PEEK,
            DWM_CLOAK,
            DWM_CLOAKED,
            DWM_FREEZE_REPRESENTATION,
            DWM_PASSIVE_UPDATE_MODE,
            DWM_USE_HOSTBACKDROPBRUSH,
            DWM_USE_IMMERSIVE_DARK_MODE = 20,
            DWM_WINDOW_CORNER_PREFERENCE = 33,
            DWM_BORDER_COLOR,
            DWM_CAPTION_COLOR,
            DWM_TEXT_COLOR,
            DWM_VISIBLE_FRAME_BORDER_THICKNESS,
            DWM_SYSTEMBACKDROP_TYPE,
            DWM_LAST,
            DWM_MICA_EFFECT = 1029
        };

        #endregion

        #region MSDN

        public static bool CalcIsColorLight(Color clr)
        {
            return (((5 * clr.G) + (2 * clr.R) + clr.B) > (8 * 128));
        }

        public static Color CalcTransparentColor(Color Clr)
        {
            return (Clr.R != Clr.B) ? Clr : Color.FromArgb(Clr.ToArgb() | 0x1);
        }

        #endregion


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ClickableTransparentOverlay;
using ImGuiNET;

namespace Menu
{
    public class Renderer : Overlay
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(int vKey);

        // bols for checkboxes
        public bool unlimatedAmmo = false;
        public bool cords = false;
        public bool infiniteHealth = false;
        public bool noRecoil = false;
        public bool rapidFire = false;
        bool showWindow = true;
        public bool fovCircle = false;



        protected override void Render()
        {
            if (GetAsyncKeyState(0xA1) < 0)
            {
                showWindow = !showWindow;
                Thread.Sleep(200);
            }

            if (showWindow)
            {
                // show window


                ImGui.Begin("Menu");
                ImGui.Checkbox("unlimatedAmmo", ref unlimatedAmmo);
                ImGui.Checkbox("cords", ref cords);
                ImGui.Checkbox("infiniteHealth", ref infiniteHealth);
                ImGui.Checkbox("noRecoil", ref noRecoil);
                ImGui.Checkbox("rapidFire/Burst", ref rapidFire);
                ImGui.Checkbox("fovCircle", ref fovCircle);

                if (ImGui.Button("Exit"))
                {
                    Environment.Exit(0);

                }
            }






        }





    }
}
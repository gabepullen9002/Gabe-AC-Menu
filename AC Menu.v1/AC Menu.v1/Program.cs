using ImGuiNET;
using Menu;
using Swed32;
using System.Net.Sockets;
using System.Runtime.InteropServices;




Renderer renderer = new Renderer();
renderer.Start().Wait();






// getting process and modulebase
Swed swed = new Swed("ac_client");
IntPtr moduleBase = swed.GetModuleBase("ac_client.exe");

// intructions for cheats
IntPtr ammoIntruction = moduleBase + 0xC73EF;
IntPtr cordsIntruction = moduleBase + 0xC0A43;
IntPtr healthIntruction = moduleBase + 0x1C223;
IntPtr rapidfireIntruction = moduleBase + 0xCB795;
IntPtr norecoilIntruction = moduleBase + 0xC2EC3;







// while true loop for cheats
while (true)
{
    if (renderer.unlimatedAmmo)
    {
        swed.WriteBytes(ammoIntruction, "90 90");
    }
    else
    {
        swed.WriteBytes(ammoIntruction, "FF 08 8D 44 24 1C");
    }

    if (renderer.cords)
    {
        swed.WriteBytes(cordsIntruction, "90 90 90");
        Console.WriteLine(cordsIntruction);

    }

    if (renderer.infiniteHealth)
    {
        swed.WriteBytes(healthIntruction, "90 90 90");

    }
    else
    {
        swed.WriteBytes(healthIntruction, "29 73 04 8B C6 5E");
    }

    if (renderer.rapidFire)
    {
        swed.WriteBytes(rapidfireIntruction, "90 90 90 90 90 90");
    }
    else
    {
        swed.WriteBytes(rapidfireIntruction, "89 9D EC 01 00 00 5D 5B C3 CC CC");
    }

    if (renderer.noRecoil)
    {
        swed.WriteBytes(norecoilIntruction, "90 90 90 90 90");
    }
    else
    {
        swed.WriteBytes(norecoilIntruction, "F3 0F 11 56 38 F3 0F 5E CC 0F 2F C1 F3 0F 11 4E 40 0F 28 E1");
    }


}
















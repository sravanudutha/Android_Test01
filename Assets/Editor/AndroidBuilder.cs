using UnityEditor;
class AndroidBuilder
{
    static void build()
    {

        // Place all your scenes here
        string[] scenes = {"./Assets/Scene.unity",
                            //"Assets/scenes/S_Login.unity",
                           // "Assets/scenes/S_Help.unity",
                           // "Assets/scenes/S_1.unity",
                           // "Assets/scenes/S_Reward.unity",
                           // "Assets/scenes/S_Credits.unity",
                           // "Assets/scenes/S_Settings.unity",
                            };

        string pathToDeploy = ".";

        BuildPipeline.BuildPlayer(scenes, pathToDeploy, BuildTarget.Android, BuildOptions.None);
    }
}
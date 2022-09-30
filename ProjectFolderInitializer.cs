// Created by: Vincent Taylor
// Date: 30/9/2022
// Reuse and modification is allowed.

namespace PFI
{
    using UnityEditor;

    public static class ProjectFolderInitializer
    {
        private const string SCENES         =       "_SCENES";
        private const string TEST_SCENES    =           "TESTING";
        private const string GAME_SCENES    =           "GAME";
        private const string GRAPHICS       =       "_GRAPHICS";
        private const string MATERIALS      =           "MATERIALS";
        private const string TEXTURES       =           "TEXTURES";
        private const string SHADERS        =           "SHADERS";
        private const string ANIMATIONS     =       "_ANIMATIONS";
        private const string CHAR_ANIMS     =           "CHARACTER";
        private const string OTHER_ANIMS    =           "OTHER";
        private const string AUDIO          =       "_AUDIO";
        private const string MUSIC          =           "MUSIC";
        private const string SFX            =           "SFX";
        private const string PREFABS        =       "_PREFABS";
        private const string SCRIPTS        =       "_SCRIPTS";
        private const string IMPORTS        =       "_IMPORTED ASSETS";


        [MenuItem("Project Folder Initializer/Create All Project Folders", false, 0)]
        private static void CreateAllFolders()
        {
            CreateScenesFolder();
            CreateGraphicsFolder();
            CreateAnimationsFolder();
            CreateAudioFolder();
            CreatePrefabsFolder();
            CreateScriptsFolder();
            CreateImportedAssetsFolder();
        }

        /// <summary>
        /// Creates a new folder in the Unity project Assets folder
        /// </summary>
        /// <param name="NAME">The name of the new folder</param>
        /// <param name="PATH">The file path of the new folder (No "/" at the end, e.g. "Assets/Test")</param>
        private static void CreateFolder(string NAME, string PATH = "Assets")
        {
            if (!AssetDatabase.IsValidFolder($"{PATH}/{NAME}"))
                AssetDatabase.CreateFolder(PATH, NAME);
        }

        #region Individual Folder Creation
        
        [MenuItem("Project Initializer/Create Scenes Folder", false, 11)]
        private static void CreateScenesFolder()
        {
            CreateFolder(SCENES);
            CreateFolder(GAME_SCENES, "Assets/" + SCENES);
            CreateFolder(TEST_SCENES, "Assets/" + SCENES);
        }

        [MenuItem("Project Initializer/Create Graphics Folder", false, 12)]
        private static void CreateGraphicsFolder()
        {
            CreateFolder(GRAPHICS);
            CreateFolder(MATERIALS, "Assets/" + GRAPHICS);
            CreateFolder(TEXTURES, "Assets/" + GRAPHICS);
            CreateFolder(SHADERS, "Assets/" + GRAPHICS);
        }

        [MenuItem("Project Initializer/Create Animations Folder", false, 13)]
        private static void CreateAnimationsFolder()
        {
            CreateFolder(ANIMATIONS);
            CreateFolder(CHAR_ANIMS, "Assets/" + ANIMATIONS);
            CreateFolder(OTHER_ANIMS, "Assets/" + ANIMATIONS);
        }
        
        [MenuItem("Project Initializer/Create Audio Folder", false, 14)]
        private static void CreateAudioFolder()
        {
            CreateFolder(AUDIO);
            CreateFolder(MUSIC, "Assets/" + AUDIO);
            CreateFolder(SFX, "Assets/" + AUDIO);
        }
        
        [MenuItem("Project Initializer/Create Prefabs Folder", false, 15)]
        private static void CreatePrefabsFolder() => CreateFolder(PREFABS);

        [MenuItem("Project Initializer/Create Scripts Folder", false, 16)]
        private static void CreateScriptsFolder() => CreateFolder(SCRIPTS);

        [MenuItem("Project Initializer/Create Imports Folder", false, 17)]
        private static void CreateImportedAssetsFolder() => CreateFolder(IMPORTS);

        #endregion
    }
}
﻿using System;
using Microsoft.Xna.Framework;

namespace Platformer
{
    static public class Values
    {
        #region Main settings
            static public Vector2 resolution = new Vector2(1024, 800);
            static public TimeSpan jumpTimeSpan = new TimeSpan(0, 0, 0, 0, 350);
            static public TimeSpan spawnPlatformTimeSpan = new TimeSpan(0, 0, 0, 0, 200); //milliseconds
            public const float playerVelocity = 100f;
            public const float gravitation = 0.7f;
            public const float playerJump = 15f;
            public const float platformsSpeed = 8f;
            public const float LowerPlatformSpawnValue = 120;
            public const float UpperPlatformSpawnValue = 120;
        #endregion

        #region Sprites settings
            #region Animated items
                #region Menu cat sprite
                    static public readonly Vector2 menuCatPosition = new Vector2(260, 210);
                    static public readonly Point menuCatFrameSize = new Point(500, 456);
                    static public readonly Point menuCatTiles = new Point(6, 7);
                    static public readonly TimeSpan menuCatTimeSpan = new TimeSpan(0, 0, 0, 0, 65); //milliseconds
                #endregion
                #region Player sprite
                    static public readonly Vector2 playerStartPosition = new Vector2(300, 100); 
                    static public readonly Point playerFrameSize = new Point(80, 56);
                    static public readonly Point playerTiles = new Point(3, 2);
                    static public readonly TimeSpan playerTimeSpan = new TimeSpan(0, 0, 0, 0, 50); //milliseconds
                #endregion
                #region Sky
                    static public readonly Point skyFrameSize = new Point(450, 810);
                    static public readonly Point skyTiles = new Point(5, 4);
                    static public readonly TimeSpan skyTimeSpan = new TimeSpan(0, 0, 0, 0, 50); //milliseconds
                #endregion
                #region Paths
                    public const string sptMenuCat = "Sprites/Animated/Menu/Cat";
                    public const string sptPlayer = "Sprites/Animated/Player/Player";
                    public const string sptSky = "Sprites/Animated/Map/Sky";  
                #endregion
            #endregion  
            #region Not animated items
                #region Menu items
                    #region Items
                        static public readonly Vector2 playButtonPosition = new Vector2(220, 675);
                        static public readonly Vector2 exitButtonPosition = new Vector2(420, 675);
                        static public readonly Vector2 scoresButtonPosition = new Vector2(620, 675);
                        static public readonly Vector2 nameTextboxPosition = new Vector2(365, 50);
                    #endregion
                    #region Paths
                        public const string txtBackground = "Sprites/Not Animated/Menu/Background";
                        public const string txtPlayButton = "Sprites/Not Animated/Menu/PlayButton";
                        public const string txtExitButton = "Sprites/Not Animated/Menu/ExitButton";
                        public const string txtScoresButton = "Sprites/Not Animated/Menu/ScoresButton";
                        public const string txtTextbox = "Sprites/Not Animated/Menu/Textbox";
                    #endregion
                #endregion
                #region Map items
                    static public readonly string txtSky = "Sprites/Not Animated/Map/Background";
                    static public readonly string defaultTile = "Sprites/Not Animated/Map/Tile"; //temporally
                    static public readonly string txtPlatform = "Sprites/Not Animated/Map/Platform";
                #endregion
        #endregion
        #endregion

        #region Other settings
            static public Vector2 descriptorPosition = new Vector2(518, 145);
            public const int mapTileSize = 32;
        #endregion

        #region Json paths
            public const string scoresJsonPath = "JsonFiles/Scores/Scores.json";
        #endregion
    }
}

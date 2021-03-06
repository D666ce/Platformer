﻿using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer
{
    public class MenuScreen : Screen
    {
        Sprite background;
        Texture2D txtBackground;

        Sprite playButton;
        Texture2D txtPlayButton;

        Sprite exitButton;
        Texture2D txtExitButton;

        Sprite scoresButton;
        Texture2D txtScoresButton;

        Sprite nameTextbox;
        Texture2D txtTextBox;

        Sprite sptMenuCat;
        Texture2D txtMenuCat;

        Vector2 descriptor;

        string playerName = string.Empty;

        public MenuScreen()
        {
            descriptor = Values.descriptorPosition;
        }

        public override void LoadContent(ContentManager Content, InputManager inputManager)
        {
            base.LoadContent(Content, inputManager);

            txtBackground = content.Load<Texture2D>(Values.txtBackground);
            background = new Sprite(txtBackground);
            background.SetPosition(Vector2.Zero);

            txtPlayButton = content.Load<Texture2D>(Values.txtPlayButton);
            playButton = new Sprite(txtPlayButton);
            playButton.SetPosition(Values.playButtonPosition);

            txtExitButton = content.Load<Texture2D>(Values.txtExitButton);
            exitButton = new Sprite(txtExitButton);
            exitButton.SetPosition(Values.exitButtonPosition);

            txtScoresButton = content.Load<Texture2D>(Values.txtScoresButton);
            scoresButton = new Sprite(txtScoresButton);
            scoresButton.SetPosition(Values.scoresButtonPosition);

            txtTextBox = content.Load<Texture2D>(Values.txtTextbox);
            nameTextbox = new Sprite(txtTextBox);
            nameTextbox.SetPosition(Values.nameTextboxPosition);

            txtMenuCat = content.Load<Texture2D>(Values.sptMenuCat);
            sptMenuCat = new Sprite(txtMenuCat, Values.menuCatFrameSize, Values.menuCatTiles, Values.menuCatTimeSpan);
            sptMenuCat.SetPosition(Values.menuCatPosition);
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            content.Unload();
        }

        public void IsLetterEntered(Keys[] keyArray)
        {
            string toStringKeys;

            foreach (Keys key in keyArray)
            {
                if (inputManager.KeyPressed(key))
                {
                    if (key == Keys.Back && playerName.Length > 0)
                    {
                        playerName = playerName.Remove(playerName.Length - 1, 1);
                        descriptor.X += 7.5f;
                    }
                    else 
                    if (playerName.Length < 6 &&
                             key.GetHashCode() >= 65 &&
                             key.GetHashCode() <= 90 ||
                             key == Keys.OemOpenBrackets ||
                             key == Keys.OemCloseBrackets ||
                             key == Keys.OemQuotes ||
                             key == Keys.OemSemicolon ||
                             key == Keys.OemComma ||
                             key == Keys.OemPeriod)
                    {
                        switch (key.ToString())
                        {
                            case "Q": toStringKeys = "Й"; break;
                            case "W": toStringKeys = "Ц"; break;
                            case "E": toStringKeys = "У"; break;
                            case "R": toStringKeys = "К"; break;
                            case "T": toStringKeys = "Е"; break;
                            case "Y": toStringKeys = "Н"; break;
                            case "U": toStringKeys = "Г"; break;
                            case "I": toStringKeys = "Ш"; break;
                            case "O": toStringKeys = "Щ"; break;
                            case "P": toStringKeys = "З"; break;
                            case "OemOpenBrackets": toStringKeys = "Х"; break;
                            case "OemCloseBrackets": toStringKeys = "Ъ"; break;
                            case "A": toStringKeys = "Ф"; break;
                            case "S": toStringKeys = "Ы"; break;
                            case "D": toStringKeys = "В"; break;
                            case "F": toStringKeys = "А"; break;
                            case "G": toStringKeys = "П"; break;
                            case "H": toStringKeys = "Р"; break;
                            case "J": toStringKeys = "О"; break;
                            case "K": toStringKeys = "Л"; break;
                            case "L": toStringKeys = "Д"; break;
                            case "OemSemicolon": toStringKeys = "Ж"; break;
                            case "OemQuotes": toStringKeys = "Э"; break;
                            case "Z": toStringKeys = "Я"; break;
                            case "X": toStringKeys = "Ч"; break;
                            case "C": toStringKeys = "С"; break;
                            case "V": toStringKeys = "М"; break;
                            case "B": toStringKeys = "И"; break;
                            case "N": toStringKeys = "Т"; break;
                            case "M": toStringKeys = "Ь"; break;
                            case "OemComma": toStringKeys = "Б"; break;
                            case "OemPeriod": toStringKeys = "Ю"; break;
                            default: toStringKeys = Convert.ToString((Keys)key); break;
                        }
                        playerName += toStringKeys;
                        descriptor.X -= 7.5f;
                    }
                }
            }
        }

        public override void Update(GameTime gameTime, Game game)
        {
            inputManager.Update();
            sptMenuCat.Update(gameTime);

            IsLetterEntered(inputManager.KeyState.GetPressedKeys());

            if ((IsClickedOn(playButton) || inputManager.KeyPressed(Keys.Enter)) && (playerName != string.Empty))
            {
                ScreenManager.Instance.AddScreen(new LevelScreen(playerName), inputManager);
            } else 
            if (IsClickedOn(scoresButton))
            {
                ScreenManager.Instance.AddScreen(new ScoresScreen(), inputManager);
            } else 
            if (IsClickedOn(exitButton) || inputManager.KeyPressed(Keys.Escape))
            {
                game.Exit();
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.GraphicsDevice.Clear(Color.Black);
            background.DrawStatic(spriteBatch);
            nameTextbox.DrawStatic(spriteBatch);
            sptMenuCat.DrawAnimated(spriteBatch);
            playButton.DrawStatic(spriteBatch);
            exitButton.DrawStatic(spriteBatch);
            scoresButton.DrawStatic(spriteBatch);
            spriteBatch.DrawString(font, playerName, descriptor, Values.mainColor);

            if (playerName == string.Empty)
            {
                spriteBatch.DrawString(font, "Введите имя игрока!", Values.alertPosition, Values.mainColor);
            }
        }
    }
}

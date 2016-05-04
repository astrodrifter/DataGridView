using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;   // For Color.

namespace DataViewGrid_Example {

    class Player {

        private Random randomNumber = new Random();

        // The first property: the player's name.
        private string name;
        public  string Name {
            get { return name; }
            set { name = value; }
        }

        // The second property: the player's points in the current game.
        private int gamePoints;
        public  int GamePoints {
            get { return gamePoints; }
            set { gamePoints = value; }
        }

        // The third property: the player's highest points in all the games.
        private int highestPoints;
        public  int HighestPoints {
            get { return highestPoints; }
            set { highestPoints = value; }
        }

        // The fourth property: the player's colour.
        private Color playerTokenColour;
        public Color PlayerTokenColour {
            get { return playerTokenColour; }
            set {
                playerTokenColour = value;
                SolidBrush brush = new SolidBrush(playerTokenColour);
                playerTokenImage = new Bitmap(1, 1);
                using (Graphics g = Graphics.FromImage(PlayerTokenImage)) {
                    g.FillRectangle(brush, 0, 0, 1, 1);
                }
            }
        }

        // The fifth property: a DataGridView cannot display a Color directly,
        // but it can display an Image. So, we have a PlayerTokenImage that is
        // set by to match the PlayerTokenColour.
        private Image playerTokenImage;
        public Image PlayerTokenImage {
            get { return playerTokenImage; }
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        public Player(string name) {
            // Initialise the player. We use some random values to simulate those in a real game.
            this.name = name;
            this.gamePoints = randomNumber.Next(0, 100);
            this.highestPoints = randomNumber.Next(0, 1000);
            if (highestPoints < gamePoints) {
                highestPoints = gamePoints;
            }
            this.PlayerTokenColour = GenerateARandomColour();
        }

        /// <summary>
        /// Generates a randomly-chosen colour.
        /// </summary>
        /// <returns>A random colour</returns>
        private Color GenerateARandomColour() {
            const int HIGHEST_COLOUR_VALUE = 255;
            int red = randomNumber.Next(0, HIGHEST_COLOUR_VALUE);
            int green = randomNumber.Next(0, HIGHEST_COLOUR_VALUE);
            int blue = randomNumber.Next(0, HIGHEST_COLOUR_VALUE);
            Color randomColor = Color.FromArgb(red, green, blue);
            return randomColor;
        }
    }
}

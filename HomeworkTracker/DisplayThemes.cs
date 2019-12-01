using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public class DisplayThemes
    {

        private Button[,] themes { get; set; } = new Button[4, 4];
        private System.Drawing.Color primarycolor;
        private System.Drawing.Color secondarycolor;
        private System.Drawing.Color accentcolor;
        private string themeName;

        //0-param constructor
        public DisplayThemes()
        {
            //Creates a blank DisplayThemes
            generateThemes();
        }

        //3 param Constructor. 
        public DisplayThemes(int red, int green, int blue, string ThemeName)
        {
            this.primarycolor = System.Drawing.Color.FromArgb(red, green, blue);
            this.secondarycolor = System.Drawing.Color.FromArgb(red, green+20, blue);
            this.accentcolor = System.Drawing.Color.FromArgb(red, green-20, blue); ;
            this.themeName = ThemeName;
            this.generateThemes();

        }

        //getters
        public System.Drawing.Color getPrimaryColor()
        {
            return this.primarycolor;
        }

        public System.Drawing.Color getSecondaryColor()
        {
            return this.secondarycolor;
        }

        public System.Drawing.Color getAccentColor()
        {
            return this.accentcolor;
        }

        public Button[,] getColorButtons()
        {
            return this.themes;
        }

        //setters
        public void setPrimaryColor(System.Drawing.Color PrimaryColor)
        {
            this.primarycolor = PrimaryColor;
        }

        public void setSecondaryColor(System.Drawing.Color SecondaryColor)
        {
            this.secondarycolor = SecondaryColor;
        }

        public void setAccentColor(System.Drawing.Color AccentColor)
        {
            this.accentcolor = AccentColor;
        }

        // Themes for grid in the ui
        public void generateThemes()
        {
            for(int i = 0; i < this.themes.GetLength(0); i++)
            {
                for(int j = 0; j < this.themes.GetLength(1); j++)
                {
                    this.themes[i, j] = new Button();
                    this.themes[i, j].BackColor = System.Drawing.Color.FromArgb(i * (255 / this.themes.GetLength(0)), 80, j * (255 / this.themes.GetLength(1)));
                    this.themes[i, j].Location = new System.Drawing.Point(i * 60 + 150, j * 60 + 150);
                    this.themes[i, j].Size = new System.Drawing.Size(50, 50);
                    this.themes[i, j].Visible = true;
                    this.themes[i, j].Click += new System.EventHandler(this.UpdateColors);
                }
            }
        }


        public void UpdateColors(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int red = button.BackColor.R;
            int green = button.BackColor.G;
            int blue = button.BackColor.B;
            this.primarycolor = System.Drawing.Color.FromArgb(red, green, blue);
            this.secondarycolor = System.Drawing.Color.FromArgb(red, green+20, blue);
            this.accentcolor = System.Drawing.Color.FromArgb(red, green-20, blue);

        }
    }
}

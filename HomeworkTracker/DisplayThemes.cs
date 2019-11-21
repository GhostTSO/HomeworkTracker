using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker
{
    class DisplayThemes
    {

        private System.Drawing.Color primarycolor;
        private System.Drawing.Color secondarycolor;
        private System.Drawing.Color accentcolor;
        private string themename;

        //0-param constructor
        public DisplayThemes()
        {
            //Creates a blank DisplayThemes
        }

        //3 param Constructor. 
        public DisplayThemes(System.Drawing.Color PrimaryColor, System.Drawing.Color SecondaryColor, System.Drawing.Color AccentColor, string ThemeName)
        {
            this.primarycolor = PrimaryColor;
            this.secondarycolor = SecondaryColor;
            this.accentcolor = AccentColor;
            this.themename = ThemeName;

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
        public void genderateThemes(string ThemeName)
        {
            this.themename = ThemeName;
        }
    }
}

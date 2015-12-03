/// Star Wars - X-wing fighter jet plans
/// Logan Ashbourne
/// 11/27/2015

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing(0, 0, 780, 350);
        }

        private void Xwing(float x, float y, float width, float height)
        {
            // X-Wing fighter jet
          
            try // No errors
            {
                // Variables
                float scaleX = width / 780;
                float scaleY = height / 350;

                // Tools
                Pen xPen = new Pen(Color.DarkGray);
                SolidBrush xBrush = new SolidBrush(Color.DarkRed);
                Font xFont = new Font("STENCIL STD", 8 * scaleY);

                // ********************************************** TEXT ********************************************** \\           
                g.DrawString("Property of\nThe Rebels\nNo.5718", xFont, xBrush, 640 * scaleX + x, 160 * scaleY + y); // Text on back of x-wing
                xFont = new Font("STENCIL STD", 20 * scaleY);                                                        // Font size change
                g.DrawString("X-Wing Fighter Jet", xFont, xBrush, 310 * scaleX + x, 210 * scaleY + y);               // Text under window
                xFont.Dispose();                                                                                     // Dispose font
                xBrush.Color = Color.DarkGray;                                                                       // Changing colour back to dark gray

                // ********************************************** TOP ********************************************** \\
                g.DrawLine(xPen, 50 * scaleX + x, 200 * scaleY + y, 600 * scaleX + x, 100 * scaleY + y);             // Front top part
                g.DrawLine(xPen, 650 * scaleX + x, 125 * scaleY + y, 600 * scaleX + x, 100 * scaleY + y);            // Top after window
            
                // ********************************************* WINDOW ********************************************* \\
                g.DrawLine(xPen, 350 * scaleX + x, 200 * scaleY + y, 300 * scaleX + x, 155 * scaleY + y);            // Window left part
                g.DrawLine(xPen, 350 * scaleX + x, 200 * scaleY + y, 550 * scaleX + x, 193 * scaleY + y);            // Window floor part
                g.DrawLine(xPen, 550 * scaleX + x, 193 * scaleY + y, 500 * scaleX + x, 118 * scaleY + y);            // Window back part

                g.DrawLine(xPen, 350 * scaleX + x, 210 * scaleY + y, 290 * scaleX + x, 157 * scaleY + y);            // Window left part outline
                g.DrawLine(xPen, 350 * scaleX + x, 210 * scaleY + y, 570 * scaleX + x, 203 * scaleY + y);            // Window floor part outline
                g.DrawLine(xPen, 563 * scaleX + x, 193 * scaleY + y, 510 * scaleX + x, 118 * scaleY + y);            // Window back part outline

                g.DrawLine(xPen, 570 * scaleX + x, 203 * scaleY + y, 650 * scaleX + x, 125 * scaleY + y);            // Top part of 2nd back window
                g.DrawLine(xPen, 563 * scaleX + x, 193 * scaleY + y, 640 * scaleX + x, 120 * scaleY + y);            // Bottom part of 2nd back window

                // Person's head
                xBrush.Color = Color.Bisque;                                                                         // Changing colour to skin colour
                g.FillEllipse(xBrush, 450 * scaleX + x, 146 * scaleY + y, 50 * scaleX, 50 * scaleY);                 // Head of person
                xBrush.Color = Color.White;                                                                          // Changing colour to white
                g.FillEllipse(xBrush, 460 * scaleX + x, 156 * scaleY + y, 10 * scaleX, 10 * scaleY);                 // Eye
                xBrush.Color = Color.Red;                                                                            // Changing colour to red
                g.FillEllipse(xBrush, 460 * scaleX + x, 158 * scaleY + y, 5 * scaleX, 5 * scaleY);                   // Pupil
                xBrush.Color = Color.DarkGray;                                                                       // Changing colour back to dark gray

                // ********************************************* DESIGN ********************************************* \\
                g.DrawArc(xPen, 37 * scaleX + x, 197 * scaleY + y, 50 * scaleX, 50 * scaleY, 110, 135);              // Front part of x-wing arc         
                g.DrawLine(xPen, 60 * scaleX + x, 200 * scaleY + y, 60 * scaleX + x, 244 * scaleY + y);              // Line by x-wing arc

                // Engine at back of x-wing
                g.DrawLine(xPen, 740 * scaleX + x, 145 * scaleY + y, 690 * scaleX + x, 125 * scaleY + y);            // Top part of engine
                g.DrawLine(xPen, 740 * scaleX + x, 225 * scaleY + y, 690 * scaleX + x, 245 * scaleY + y);            // Bottom part of engine
                g.DrawLine(xPen, 740 * scaleX + x, 225 * scaleY + y, 740 * scaleX + x, 145 * scaleY + y);            // Middle part of engine

                xPen.Color = Color.DarkRed;                                                                          // Changing colour to dark red
                g.DrawLine(xPen, 750 * scaleX + x, 210 * scaleY + y, 780 * scaleX + x, 220 * scaleY + y);            // Bottom closest rectangle particles from engine
                g.DrawLine(xPen, 750 * scaleX + x, 180 * scaleY + y, 780 * scaleX + x, 180 * scaleY + y);            // Middle closest rectangle particles from engine
                g.DrawLine(xPen, 750 * scaleX + x, 150 * scaleY + y, 780 * scaleX + x, 140 * scaleY + y);            // Top closest rectangle particles from engine
                xPen.Color = Color.DarkGray;                                                                         // Changing colour back to dark gray

                // ******************************************** TOP WING ******************************************** \\
                g.DrawLine(xPen, 680 * scaleX + x, 60 * scaleY + y, 690 * scaleX + x, 125 * scaleY + y);             // First right part of wing
                g.DrawLine(xPen, 650 * scaleX + x, 60 * scaleY + y, 650 * scaleX + x, 125 * scaleY + y);             // First left part of wing
                g.DrawEllipse(xPen, 625 * scaleX + x, 35 * scaleY + y, 75 * scaleX, 25 * scaleY);                    // Oval holding the pole               
                g.DrawLine(xPen, 350 * scaleX + x, 50 * scaleY + y, 625 * scaleX + x, 50 * scaleY + y);              // Pole
                g.FillRectangle(xBrush, 400 * scaleX + x, 45 * scaleY + y, 25 * scaleX, 10 * scaleY);                // Rectangle on pole
                g.DrawLine(xPen, 375 * scaleX + x, 75 * scaleY + y, 405 * scaleX + x, 50 * scaleY + y);              // Bottom line sticking out of rectangle
                g.DrawLine(xPen, 375 * scaleX + x, 25 * scaleY + y, 405 * scaleX + x, 50 * scaleY + y);              // Top line sticking out of rectangle

                // ****************************************** BOTTOM WING ****************************************** \\
                g.DrawLine(xPen, 650 * scaleX + x, 310 * scaleY + y, 650 * scaleX + x, 245 * scaleY + y);            // First left part of wing
                g.DrawLine(xPen, 680 * scaleX + x, 310 * scaleY + y, 690 * scaleX + x, 245 * scaleY + y);            // First right part of wing
                g.DrawEllipse(xPen, 625 * scaleX + x, 310 * scaleY + y, 75 * scaleX, 25 * scaleY);                   // Oval holding the pole
                g.DrawLine(xPen, 350 * scaleX + x, 325 * scaleY + y, 625 * scaleX + x, 325 * scaleY + y);            // Pole
                g.FillRectangle(xBrush, 400 * scaleX + x, 320 * scaleY + y, 25 * scaleX, 10 * scaleY);               // Rectangle on pole          
                g.DrawLine(xPen, 375 * scaleX + x, 350 * scaleY + y, 405 * scaleX + x, 325 * scaleY + y);            // Bottom line sticking out of rectangle
                g.DrawLine(xPen, 375 * scaleX + x, 300 * scaleY + y, 405 * scaleX + x, 325 * scaleY + y);            // Top line sticking out of rectangle

                // ********************************************* BOTTOM ********************************************* \\
                g.DrawLine(xPen, 53 * scaleX + x, 245 * scaleY + y, 650 * scaleX + x, 245 * scaleY + y);             // Floor bottom part  

                // Freeing up memory for rest of animation
                xBrush.Dispose(); // Dispose brush
                xPen.Dispose();   // Dispose pen                
            }
            catch { }             // No errors
        }
    }
}

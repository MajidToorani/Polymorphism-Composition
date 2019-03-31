using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//--------------------------
//Majid Tooranisama
//#7725070
//InClass#4
//July 25, 2018
//--------------------------

namespace Polymorphism1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //design a class object
        public abstract class Shape
        {
            public virtual double Area(){return 0;}
            public virtual string Name(){return null;} 
            public virtual double Volume() {return 0;}
        }
      
        //inheritance
        public class Triangle : Shape  
        {           
            private double tbase ;
            private double height;
 
            //property Accessor Methods 
            public double Tbase
            {
                set { tbase = value; }
                get { return tbase; }
            }
            //property Accessor Methods 
            public double Height
            {
                set { height = value; }
                get { return height; }
            }

            public override double Area()
            {
                return 0.5 * Tbase * Height;
            }
            public override string Name()
            {
                return "Shape:Triangle";
            }
        }

        //inheritance
        public class Circle : Shape
        {
            protected double radius;

            //property Accessor Methods 
            public double Radius
            {
                set { radius = value; }
                get { return radius; }
            }

            public override double Area()
            {
                return Radius * Radius * Math.PI;
            }
            public override string Name()
            {
                return "Shape:Circle";
            }
        }

        //inheritance
        public class Rectangle : Shape
        {
            private double length;
            private double width;

            //property Accessor Methods 
            public double Length
            {
                set { length = value; }
                get { return length; }
            }
            //property Accessor Methods 
            public double Width
            {
                set { width = value; }
                get { return width; }
            }
            public override double Area()
            {
                return Width * Length;                 
            }
            public override string Name()
            {
                return "Shape:Rectangle";
            }
        }
        public class Box : Rectangle
        {
            private double height;
          
            //property Accessor Methods 
            public double Height
            {
                set { height = value; }
                get { return height; }
            }
            //property Accessor Methods 
            public override double Volume()
            {
                return height*Area();
            }
            public override string Name()
            {
                return "Shape:Box";
            }
        }
        public class Pyramid : Triangle
        {
            private double pyramidHeight;
           
            //property Accessor Methods 
            public double PyramidHeight
            {
                set { pyramidHeight = value; }
                get { return pyramidHeight; }
            }
            //property Accessor Methods 
            public override double Volume()
            {
                return (double)1 / 3 * pyramidHeight * Area(); 
            }
            public override string Name()
            {
                return "Shape:Pyramid";
            }
        }
        public class Sphere : Circle
        {
            //property Accessor Methods 
            public override double Volume()
            {
                return (double)4 / 3 * Math.PI * Math.Pow(Radius,3);
            }
            public override string Name()
            {
                return "Shape:Sphere";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Circle myCircle = new Circle();
            Rectangle myRectangle = new Rectangle();
            Triangle myTriangle  = new Triangle();
            Box myBox = new Box();
            Pyramid myPyramid = new Pyramid();
            Sphere mySphere = new Sphere();


            myCircle.Radius = Convert.ToDouble(textBox_radius.Text);
            myRectangle.Length = Convert.ToDouble(textBox_sqLength.Text);
            myRectangle.Width = Convert.ToDouble(textBox_sqWidth.Text);
            myTriangle.Tbase = Convert.ToDouble(textBox_triBase.Text);
            myTriangle.Height= Convert.ToDouble(textBox_triHeight.Text);
            myBox.Height = Convert.ToDouble(textBox_BoxHeight.Text);
            myBox.Length = Convert.ToDouble(textBox_sqLength.Text);
            myBox.Width = Convert.ToDouble(textBox_sqWidth.Text);
            myPyramid.PyramidHeight = Convert.ToDouble(textBox_PyramidHeight.Text);
            myPyramid.Tbase = Convert.ToDouble(textBox_triBase.Text);
            myPyramid.Height = Convert.ToDouble(textBox_triHeight.Text);
            mySphere.Radius = Convert.ToDouble(textBox_SphereRadious.Text);

            Shape[] myShapes = new Shape[6];
            myShapes[0] = myCircle;
            myShapes[1] = myTriangle;
            myShapes[2] = myRectangle;
            myShapes[3] = myBox;
            myShapes[4] = myPyramid;
            myShapes[5] = mySphere;

            outputLabel.Text = "";

            for (int i = 0 ; i < 3 ; i++ ) 
            {
                outputLabel.Text += "\n " + myShapes[i].Name() + " area= " + myShapes[i].Area();
            }
            for (int i = 3; i < 6; i++)
            {
                outputLabel.Text += "\n " + myShapes[i].Name() + " volume= " + myShapes[i].Volume();
            }
        }
    }
}


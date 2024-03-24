using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLibrary
{
    /// <summary>
    /// a class representing a 3 element vector, and providing instance and class methods for working with them
    /// </summary>

    public class Vector3
    {
        /// <summary>
        /// private backing field for the x property
        /// </summary>
        private double _x=0;
        
        /// <summary>
        /// private backing field for the y property
        /// </summary>
        private double _z;

        /// <summary>
        /// constructor for the vector3 class
        /// </summary>
        /// <param name="x">the x- component of the vector</param>
        /// <param name="y">the y- componoent of the vector</param>
        /// <param name="z">the z - compononent of the vector</param>
        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        #region Properties
        /// <summary>
        /// the x component of the vector
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when the value is set to NaN</exception> 
        public double X
        {
            get {
                return _x;
            }
            set {
                if (value == double.NaN) throw new ArgumentException("x must be a number");
                _x = value;
            }

        }
        /// <summary>
        ///the y component of the vector
        /// </summary>
        public double Y { get; set; } = 0;
        /// <summary>
        /// the z componoent of the vector
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when the value is set to NaN</exception> 
        public double Z
        {
            get => _z;
            set
            {
                if (value == double.NaN) throw new ArgumentException("x must be a number");
                _z = value;
            }
        }
       
        /// <summary>
        /// returns the magnitude of this vector
        /// </summary>
        public double Magnitude{
        get{
            return Math.Sqrt(X* X+ Y* Y+ Z* Z);
            }
        }
        #endregion

         #region Methods
        /// <summary>
        /// adds vectpr <paramref name="other"/>
        /// </summary>
        /// <param name="other">the vector to add to this one</param>
        public void Add(Vector3 other)
        {
            this.X =this.X+  other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }
        /// <summary>
        /// subtracts vector <paramref name="other"/>
        /// </summary>
        /// <param name="other">the vecctor to subtract from  this one</param>
        public void Subtract(Vector3 other)
        {
            this.X = this.X - other.X;
            this.Y -= other.Y;
            this.Z -= other.Z;
        }
        /// <summary>
        /// turns the vector into a unit vector
        /// </summary>
        public void Normalize()
        {

            double magnitude = Magnitude;
            X /= magnitude;
            Y /= magnitude;
            Z /= magnitude;
        }
        /// <summary>
        /// calculates the dot product of this vector and  <paramref name="other"/>
        /// </summary>
        /// <param name="other">the vector to multiply with this one</param>
        /// <returns>the dot product</returns>
        public double DotProduct(Vector3 other )
        {
            return this.X * other.X + this.Y * other.Y + this.Z * other.Z;
        }
        /// <summary>
        /// calculates the cross product of this vector and <paramref name="other"/>
        /// </summary>
        /// <param name="other">the vector to multiply with this one</param>
        /// <returns>a vector that is the result of the cross product</returns>
        public Vector3 CrossProdut(Vector3 other)
        {
            
            return new Vector3((this.Y * other.Z - this.Z * other.Y), (this.Z * other.X - this.X * other.Z), (this.X * other.Y - this.Y * other.X));
        }

        #endregion
        #region Static Methods
        /// <summary>
        /// returns a new vector containing the sum of <paramref name="a"/> and <paramref name="b"/>
        /// </summary>
        /// <param name="a">a vector to add </param>
        /// <param name="b">a vector to add</param>
        /// <returns>the vector sum of <paramref name ="a"/> and <paramref name="b"/> </returns>
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }
        /// <summary>
        /// returns a new vector containing the difference of <paramref name="a"/> and <paramref name="b"/>
        /// </summary>
        /// <param name="a">a vector to subtract from</param>
        /// <param name="b">a vector to add to </param>
        /// <returns>the vector difference  of <paramref name ="a"/> and <paramref name="b"/> </returns>
        public static Vector3 Subtract(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        /// <summary>
        /// returns the magnitude of the vector
        /// </summary>
        /// <param name="a">the vector</param>
        /// <returns>the magnitude of <paramref name="a"/></returns>
        public static double Length(Vector3 a) { 
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }
        /// <summary>
        /// returns the scale of a vector
        /// </summary>
        /// <param name="vec">the vector we want to scale</param>
        /// <param name="scale">the magnitude by which we want to scale</param>
        /// <returns>a vector that is the result of scaling <paramref name="vec"/> by <paramref name="scale"/></returns>
        public static Vector3 Scale(Vector3 vec, double scale)
        {
            double x = vec.X * scale;
            double y = vec.Y * scale;
            double z = vec.Z * scale;
            return new Vector3(x, y, z);
        }
        /// <summary>
        /// calculate the dot product of two vectors
        /// </summary>
        /// <param name="a">the first vector</param>
        /// <param name="b">the second vector</param>
        /// <returns>the dot product of <paramref name="a"/> and <paramref name="b"/> </returns>
        public static double DotProduct(Vector3 a, Vector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        /// <summary>
        /// calculate the cross product of two vectors
        /// </summary>
        /// <param name="a">the first vector</param>
        /// <param name="b">the second vector</param>
        /// <returns>the vector  cross product of <paramref name="a"/> and <paramref name="b"/> </returns>
        public static Vector3 CrossProduct(Vector3 a, Vector3 b)
        {
            return new Vector3((a.Y * b.Z - a.Z * b.Y), (a.Z * b.X - a.X * b.Z), (a.X * b.Y - a.Y * b.X));
        }
        /// <summary>
        /// normalizes the vector
        /// </summary>
        /// <param name="a">the vector to normalize</param>
        /// <returns>a normalized <paramref name="a"/></returns>
        public static Vector3 Normalize(Vector3 a)
        {
            double mag = Vector3.Length(a);
            return new Vector3(a.X / mag, a.Y / mag, a.Z / mag);
        }

        #endregion

       

    }
}

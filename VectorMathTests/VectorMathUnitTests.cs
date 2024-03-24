
namespace VectorMathTests
{
    public class VectorMathTest
    {
        [Theory]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 5.0, 7.0)]
        [InlineData(-3.0, 12.343553, 8.0)]
        public void ConstructingAVectorSetsState(double x, double y, double z)
        {
            Vector3 v = new Vector3(x, y, z);
            Assert.Equal(x, v.X);
            Assert.Equal(y, v.Y);
            Assert.Equal(z, v.Z);
        }


        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 6.0, 7.0, 8.6)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, 2.0, -4.0, -1.5)]
        public void AddReturnsVectorSum(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = Vector3.Add(a, b);

            Assert.Equal(cx, c.X);
            Assert.Equal(cy, c.Y);
            Assert.Equal(cz, c.Z);
        }
        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 6.0, 7.0, 8.6)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, 2.0, -4.0, -1.5)]


        public void AddInstanceMethodReturnsVectorSum(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            a.Add(b);
            Assert.Equal(cx, a.X);
            Assert.Equal(cy, a.Y);
            Assert.Equal(cz, a.Z);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 4.0, 3.0, 2.0)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -8.0, 0.0, -1.5)]
        public void SubtractReturnsVectorDifference(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = Vector3.Subtract(a, b);

            Assert.Equal(cx, c.X);
            Assert.Equal(cy, c.Y);
            Assert.Equal(cz, c.Z);
        }


        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 4.0, 3.0, 2.0)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -8.0, 0.0, -1.5)]
        public void SubtractInstanceMethodReturnsVectorDifference(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            a.Subtract(b);
            Assert.Equal(cx, a.X);
            Assert.Equal(cy, a.Y);
            Assert.Equal(cz, a.Z);
        }



        [Theory]
        [InlineData(0.0, 0.0, 0.0, 25.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 5.0, 5.0, 5.3)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -15.0, -10.0, -7.5)]
        [InlineData(2.3, 0.0, -3.5, -2.0, -4.6, 0.0, 7.0)]
        [InlineData(4.0, 8.0, -6.0, 0.5, 2.0, 4.0, -3.0)]
        public void ScaleReturnsScaledVector(double ax, double ay, double az, double scalar, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 c = Vector3.Scale(a, scalar);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.2, 31.96)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -11)]
        public void DotProductReturnsDotProduct(double ax, double ay, double az, double bx, double by, double bz, double actualProduct)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            double computedProduct = Vector3.DotProduct(a, b);
            Assert.Equal(actualProduct, computedProduct, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.2, 31.96)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -11)]
        public void DotProductInstanceReturnsDotProduct(double ax, double ay, double az, double bx, double by, double bz, double actualProduct)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            double computedProduct =a.DotProduct( b);
            Assert.Equal(actualProduct, computedProduct, 12);
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 5.9, -11.2, 5)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -3, -7.5, 16)]
        public void CrossProductReturnsCrossProduct(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            Vector3 c = Vector3.CrossProduct(a, b);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }
        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)]
        [InlineData(5.0, 5.0, 5.3, 1.0, 2.0, 3.3, 5.9, -11.2, 5)]
        [InlineData(-3.0, -2.0, -1.5, 5.0, -2.0, 0.0, -3, -7.5, 16)]
        public void CrossProductInstanceMethodReturnsCrossProduct(double ax, double ay, double az, double bx, double by, double bz, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 b = new Vector3(bx, by, bz);
            a=a.CrossProdut(b);
            Assert.Equal(cx, a.X, 12);
            Assert.Equal(cy, a.Y, 12);
            Assert.Equal(cz, a.Z, 12);
        }


        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(0.0, 1.0, 0.0, 1.0)]
        [InlineData(5.0, 3.6, 2.7, 6.72681202353685)]
        [InlineData(2.0, -2.0, 0.0, 2.82842712474619)]
        [InlineData(1.5, 1.5, 1.5, 2.598076211353316)]

        public void MagnitudePropertyReturnsVectorMagnitude(double ax, double ay, double az, double actualMagnitude)
        {
            Vector3 a = new Vector3(ax, ay, az);
            //double calculatedMagnitude = VectorMath.Magnitude(a);
            Assert.Equal(actualMagnitude, a.Magnitude, 12);
        }


        [Theory]
        [InlineData(0.0, 0.0, 0.0, 0.0)]
        [InlineData(0.0, 1.0, 0.0, 1.0)]
        [InlineData(5.0, 3.6, 2.7, 6.72681202353685)]
        [InlineData(2.0, -2.0, 0.0, 2.82842712474619)]
        [InlineData(1.5, 1.5, 1.5, 2.598076211353316)]

        public void MagnitudeReturnsVectorMagnitude(double ax, double ay, double az, double actualMagnitude)
        {
            Vector3 a = new Vector3(ax, ay, az);
            double calculatedMagnitude = Vector3.Length(a);
            Assert.Equal(actualMagnitude, Vector3.Length(a), 12);
        }



        [Theory]
        [InlineData(0.0, 0.0, 0.0, double.NaN, double.NaN, double.NaN)]
        [InlineData(0.0, 1.0, 0.0, 0.0, 1.0, 0.0)]
        [InlineData(5.0, 3.6, 2.7, 0.743294146247166, 0.53517178529796, 0.40137883897347)]
        [InlineData(2.0, -2.0, 0.0, 0.707106781186547, -0.707106781186547, 0)]
        [InlineData(1.5, 1.5, 1.5, 0.577350269189626, 0.577350269189626, 0.577350269189626)]
        public void NormalizeReturnsNormalizedVector(double ax, double ay, double az, double cx, double cy, double cz)
        {
            Vector3 a = new Vector3(ax, ay, az);
            Vector3 c = Vector3.Normalize(a);
            Assert.Equal(cx, c.X, 12);
            Assert.Equal(cy, c.Y, 12);
            Assert.Equal(cz, c.Z, 12);
        }

        [Theory]
        [InlineData(1,1,1,1 )]
        [InlineData(2,2,2,1)]
        [InlineData(4,8,2,1)]
        [InlineData(0,0,0,double.NaN)]
        public void NormalizeMakesAVectorUnitLength(double x, double y, double z,double expected){

            Vector3 v= new Vector3(x, y, z);
             v.Normalize();
            Assert.Equal(expected,v.Magnitude,12);
            }
      
    }
}
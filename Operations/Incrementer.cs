namespace NetCoreWorkshop_5_4_18.Operations
{
    public class Incrementer
    {
        public void IncrementInteger(int numToIncrement){
            numToIncrement++;
        }
        public void IncrementMyClass(MyClass myClass){
            myClass.MyInteger++;
        }

        public void IncrementByVal(int numToIncrement){
            numToIncrement++;
        }

        public void IncrementByRef(ref int numToIncrement){
            numToIncrement++;
        }
    }
}
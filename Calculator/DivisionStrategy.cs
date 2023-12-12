namespace Strategy{
    public class DivisionStrategy : OperationStrategy{

        override
        public double Calc(double valueOne, double valueTwo){
            return valueOne / valueTwo;
        }
    }
}
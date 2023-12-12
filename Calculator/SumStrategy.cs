namespace Strategy{
    public class SumStrategy : OperationStrategy{

        override
        public double Calc(double valueOne, double valueTwo){
            return valueOne + valueTwo;
        }
    }
}
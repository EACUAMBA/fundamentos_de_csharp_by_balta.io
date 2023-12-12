namespace Strategy{
    public class MultiplicationStrategy : OperationStrategy{

        override
        public double Calc(double valueOne, double valueTwo){
            return valueOne * valueTwo;
        }
    }
}
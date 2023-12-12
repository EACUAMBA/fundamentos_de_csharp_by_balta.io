namespace Strategy{
    public class SubstractionStrategy : OperationStrategy{

        override
        public double Calc(double valueOne, double valueTwo){
            return valueOne - valueTwo;
        }
    }
}
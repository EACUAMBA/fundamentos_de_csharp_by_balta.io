namespace Strategy{
    public class OperationContext{
        public OperationStrategy? Operation {get; set;}

        public double? PerformCalc(double valueOne, double valueTwo){
            if(this.Operation == null){
                System.Console.WriteLine("There is no Strategy for this.");
                return null;
            }
            return Operation!.Calc(valueOne, valueTwo);
        }
    }
}
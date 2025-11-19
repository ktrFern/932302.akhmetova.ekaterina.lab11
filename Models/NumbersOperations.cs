namespace Lab11.Models
{
    public class NumbersOperations
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int Sum => FirstNumber + SecondNumber;
        public int Sub => FirstNumber - SecondNumber;
        public int Mult => FirstNumber * SecondNumber;
        public int Div => SecondNumber == 0 ? 0 : FirstNumber / SecondNumber;
        public bool HasDivisionError => SecondNumber == 0;
    }
}
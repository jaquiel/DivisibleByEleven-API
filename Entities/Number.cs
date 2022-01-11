namespace NPF
{
    public class Number
    {
        public string number { get; set; }

        public bool isMultiple  { get; set; }

        public Number(string number)
        {
            this.number = number;
            this.isMultiple = IsDivisibleByEleven(number);
        }

        private bool IsDivisibleByEleven(string number)
        {
            int n = number.Length;

            int oddSum = 0, 
                evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    oddSum += (number[i] - '0');
                else
                    evenSum += (number[i] - '0');
            }

            return ((oddSum - evenSum)  % 11 == 0);
        }
    }
}

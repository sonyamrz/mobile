namespace wfaGameTrainerAccount
{
    internal class Game
    {
        public int CountCorrect { get; private set; } = 0;
        public int CountWrong { get; private set; } = 0;
        public string CodeText { get; private set; } = "";

        private bool answerCorrect;

        public event EventHandler? Change;

        public int skipCounter = 6;

        public int level = 1;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            skipCounter = 6;
            level = 1;
            DoContinue();
        }

        private void DoContinue()
        {
            Random rnd = new();
            int xValue1 = rnd.Next(20+level);
            int xValue2 = rnd.Next(1, 20+level);
            int symbol = rnd.Next(4);
            int xResult = 0;
            if (symbol == 0)
            {
                xResult = xValue1 + xValue2;
            } else if (symbol == 1)
            {
                xResult = xValue1 - xValue2;
            } else if(symbol == 2)
            {
                xResult = xValue1 * xValue2;
            } else
            {
                xResult = xValue1 / xValue2;
            }
            int xResultNew = xResult;//то, что увидит пользователь
            if (rnd.Next(2) == 1)
            {
                xResultNew += rnd.Next(1, 7) * (rnd.Next(2) == 1 ? 1 : -1);
            }
            if (symbol == 0)
            {
                CodeText = $"{xValue1} + {xValue2} = {xResultNew}";
            }
            else if (symbol == 1)
            {
                CodeText = $"{xValue1} - {xValue2} = {xResultNew}";
            }
            else if (symbol == 2)
            {
                CodeText = $"{xValue1} * {xValue2} = {xResultNew}";
            }
            else
            {
                CodeText = $"{xValue1} : {xValue2} = {xResultNew}";
            }
        
            answerCorrect = xResult == xResultNew;//в answerCorrect запишется xResultNew если он равен xResult
            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if (v == answerCorrect)
            { 
                CountCorrect++;
                if (CountCorrect % 3 == 0)
                {
                    level++;
                }
                //если пользователь 3 раза ответил правильно, увелич сложность
            }
            else
            {
                CountWrong++;
                if (CountWrong % 3 == 0)
                {
                    level--;
                }
            }
            DoContinue();
        }

        public void SkipAnswer()
        {
            skipCounter--;
            if (skipCounter>0) 
            { 
                DoContinue();
            }
            
        }

    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;


namespace ClassicAlgorithms.Properties
{
    public class WinCards
    {
        private int currentRound = -1;
        private int currentMoney = 100;
        private int currentBid = 0;
        private string currenCardPlayed;

        Dictionary<string, int> cardsPlayed = new Dictionary<string, int>();

        public void Solution()
        {
            // If you need initialization code, you can write it here!
            // Do not remove.
        }

        /*
         * Set a bid on the current painting for auction. If you do not wish to bid, 
         * set 0.
         */

        public int setBid()
        {
            int setBid = 0;

            if (currentBid < 25)
                setBid = currentBid + 3;
            else if (currentBid < currentMoney)
                setBid = currentBid + 1;
            else
                setBid = 0;
            return setBid;
        }

        /*
         * Set the starting bid of the painting currently for auction. This number 
         * must be greater than 0.
         */
        public int setInitialBid()
        {

            int setInitialBid = 1;

            if (currentRound == 0)
                setInitialBid = 1;
            else
                setInitialBid = CalculateBid();

            return setInitialBid;
        }

        /*
         * This method will be called at the start of every round. Here, you should 
         * check how much money you have and what the upcoming painting category is.
         */
        public void round_start()
        {
            currentRound++;
            currentMoney = get_curr_money();
            currentBid = getCurrentBid();
            if (cardsPlayed.ContainsKey(currenCardPlayed))
                cardsPlayed[currenCardPlayed]++;
            else
            {
                cardsPlayed.Add(currenCardPlayed, 1);
            }
        }

        int CalculateBid()
        {
            return (int)(currentMoney * 0.10f);
        }

        int get_curr_money() { return 0; }
        int getCurrentBid() { return 0; }
        string getCardCategory() { return null; }
    }
}

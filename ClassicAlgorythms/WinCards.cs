using System;
using System.Collections.Generic;

public class Solution
{
//    private int currentRound;
//    private int currentMoney;
//    private int currentBid;
//    private string currenCardPlayed;

//    Dictionary<string, int> cardsPlayed;

//    public Solution()
//    {
//        currentRound = -1;
//        currentMoney = 100;
//        currentBid = 0;
//        currenCardPlayed = null;
//        cardsPlayed = new Dictionary<string, int>();
//    }

//    /**
//     * Set a bid on the current painting for auction. If you do not wish to bid, 
//     * set 0.
//     */
//    public int SetBid()
//    {
//        int setBid = 0;

//        if (currentRound > 4)
//            setBid = CalculateBid();
//        else
//            setBid = currentBid > currentMoney ? currentMoney : currentBid + 1;

//        return setBid;
//    }

//    /**
//     * Set the starting bid of the painting currently for auction. This number 
//     * must be greater than 0.
//     */
//    public int SetInitialBid()
//    {
//        int setInitialBid = 1;

//        setInitialBid = 30 + cardsPlayed[currenCardPlayed];

//        if (setInitialBid > currentMoney)
//            setInitialBid = currentMoney;

//        return setInitialBid;
//    }

//    /**
//     * This method will be called at the start of every round. Here, you should 
//     * check how much money you have and what the upcoming painting category is.
//     */
//    public void Round_start()
//    {
//        currentRound++;
//        currentMoney = API.Get_curr_money();
//        currentBid = API.GetCurrentBid();
//        currenCardPlayed = API.GetCardCategory();

//        if (cardsPlayed.Count > 0 && cardsPlayed.ContainsKey(currenCardPlayed))
//            cardsPlayed[currenCardPlayed]++;
//        else
//        {
//            if (currenCardPlayed != null)
//                cardsPlayed.Add(currenCardPlayed, 1);
//        }

//    }

//    int CalculateBid()
//    {
//        int bid = currentBid;

//        if (currenCardPlayed != null && cardsPlayed.Count > 0 && cardsPlayed.ContainsKey(currenCardPlayed))
//        {
//            if (currentBid < currentMoney)
//            {
//                bid = (int)((currentBid + cardsPlayed[currenCardPlayed]) * 1.1f);

//                if (bid > currentMoney)
//                    bid = currentMoney;
//            }
//        }
//        else
//        {
//            if (currentBid < currentMoney)
//            {
//                bid = (int)((currentBid + cardsPlayed[currenCardPlayed]) * 1.1f);

//                if (bid > currentMoney)
//                    bid = currentMoney;
//            }
//        }

//        return bid;
//    }
}

using CoreTest.MyLib.Models;
using System.Collections.Generic;

namespace CoreTest.MyLib.Services
{
    public static class ListService
    {
        public static List<MyObject> MyObjects(IGetNumberService getNumberService)
        {
            var TheList = new List<MyObject>();
            for (int i = 0; i < getNumberService.GetNumber(); i++)
            {
                TheList.Add(new MyObject());
            }

            return TheList;
        }
    }
}

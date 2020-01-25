using System;

namespace CoreTest.MyLib.Models
{
    public class MyObject
    {
        public int ObjectID { get; set; }
        public Guid RandomGuid { get; set; }

        public MyObject()
        {
            ObjectID = new Random().Next();
            RandomGuid = Guid.NewGuid();
        }
    }
}

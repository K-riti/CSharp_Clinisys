namespace Events
{
    class SUBSCRIBERSeparator
    {
        public delegate void SUBSCRIBERSeparatedEventHandler();
        public event SUBSCRIBERSeparatedEventHandler? Separated;
        public event SUBSCRIBERSeparatedEventHandler? followed;

        public void Separate()
        {
            if (Separated != null) {
                Separated();
                System.Console.WriteLine("Someone Subscribed");
            }
            else 
                System.Console.WriteLine("Not Subscribed to our channel");
        }
        public void Subscribe()
        {
            if(followed!= null){
               followed();
               System.Console.WriteLine("Someone Followed");
            }
               else
               System.Console.WriteLine("Not followed our newsletter");

        }
    }
}
namespace Events
{
    class channel
    {
        private readonly SUBSCRIBERSeparator xoxo;
        public channel(SUBSCRIBERSeparator qqtes)
        {
             
            this.xoxo = qqtes;
            xoxo.Separated -= Subscriberdecreased;
        }

        public Action Separated { get; internal set; }
        public Action followed { get; internal set; }

        public void Subscriberdecreased()
        {
            System.Console.WriteLine("Someone followed You");
        }
    }
    class newsletter
    {
        private readonly channel ?chnl;
        private SUBSCRIBERSeparator es2;

        public newsletter(channel sportsnews)
        {
            this.chnl = sportsnews;
            chnl.followed += Newsletternotify!;
        }

        public newsletter(SUBSCRIBERSeparator es2)
        {
            this.es2 = es2;
            es2.followed+=Newsletternotify!;
        }

        public void Newsletternotify()
        {
            System.Console.WriteLine("Welcome to our Newsletter");
        }
    }
}
 namespace Events 
 { 
    class Program 
    { 
        static void Main(string[] args) 
        { 
            SUBSCRIBERSeparator ?es1 = new SUBSCRIBERSeparator();

            //es1.Separate();
            channel voila = new channel(es1);
            es1.Subscribe();
            es1.Separate();
            SUBSCRIBERSeparator es2=new SUBSCRIBERSeparator();
            newsletter letter = new newsletter(es2);
            es2.Subscribe();
            es2.Separate();
            
            
            SUBSCRIBERSeparator es3 = new SUBSCRIBERSeparator();
            newsletter x =new newsletter(es3);
            es3.Subscribe();
            es3.Separate();
        }
    }
}
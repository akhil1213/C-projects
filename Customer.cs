namespace PersonAndCustomer
{
    internal class Customer
    {
        private string customer;
        private bool mailList;
        private string message = "You will get mail";
        public Customer(string c, bool m)
        {
            customer = c;
            mailList = m;
        }
        public string getMessage()
        {
            string name = customer.Split(',')[0];
            
            Person obj = new Person(name, customer.Split(',')[1], customer.Split(',')[2]);
            obj.setName(name);
            message += obj.getName();
            message += " and the email is going to be at " + obj.getEmail();
            return message;
        }
        public bool getMailList()
        {
            return mailList;
        }
    }
}
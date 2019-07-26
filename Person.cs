namespace PersonAndCustomer
{
    internal class Person
    {
        string personName, emailAddress, telephone;
        public Person(string p, string e, string t)
        {
            personName = p;
            emailAddress = e;
            telephone = t;
        }
        public void setName(string p)
        {
            personName = p;
        }
        public string getName()
        {
            return personName;
        }
        public string getEmail()
        {
            return emailAddress;
        }
    }
}
using System;

namespace ACM.BL
{
    public class Customer
    {
        ///we add the property
        // make a customer type
        
        public int CustomerId {get;private set;}  // this will be auto generated cant be set by anything outside the class
        public string FirstName {get;set;}
        public string Lastname {get;set;}
        public string EmailAddress {get;set;}

        // make another property
        public string FullName{
            get{
                return Lastname + "," + FirstName;
            }
        }
        


    	

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterTemplate
{
    // This file contains real code but it doesn't do anything other than illustrate 
    // how the classes of the pattern are arranged.  Refer to the appropriate Design Patterns
    // document to see the class diagrams and the 
    public class Client
    {
      Target target = new Adapter();

      public void Main()
      {
        target.Request(); // in a Windows Forms Application this call will likely be the result of 
                          // an event such as a mouse click on a button instead of a call to a method like
                          // this.  See the code in the AdapterDemo project in this Adapter solution.
      }
    }

    public class Target
    {
      public void Request();
    }


    public class Adapter : Target
    {
      Adaptee adaptee = new Adaptee();

      public void Request()
      {
        adaptee.SpecificRequest();
      }
    }

    public class Adaptee
    {
      public void SpecificRequest()
      {
        // Do whatever you need to do here to carry out the request.
      }
    }

}

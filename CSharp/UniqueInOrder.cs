/**
* Level: 6kyu
* Description: 
* Implement the function Get() which takes as argument a sequence and returns a list of items without any elements
* with the same value next to each other and preserving the original order of elements.
*/
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public static class UniqueInOrder
    {
        public static IEnumerable<T> Get<T>(IEnumerable<T> iterable) 
        {
            var uniqueItemsList = new List<T>();
      
            foreach(var element in iterable)
            {
                var nextIsDuplicate = element.Equals(uniqueItemsList.LastOrDefault());
        
                if (!nextIsDuplicate)
                    uniqueItemsList.Add(element);  
            }

            return uniqueItemsList;
        }
    }
}
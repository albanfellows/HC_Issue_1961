using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_Bug
{
    public class QueryType 
    {
        [UseFiltering]
        public IEnumerable<TestObject> TestGet()
        {
            yield return new TestObject { Id = 1, Name = "Test 1" };
            yield return new TestObject { Id = 2, Name = "Test 2" };
            yield return new TestObject { Id = 3, Name = "Test 3" };
            yield return new TestObject { Id = 4, Name = "Fourth Test" };
            yield return new TestObject { Id = 5, Name = "Fifth Test" };
            yield return new TestObject { Id = 6, Name = "Sixth Test" };
            yield return new TestObject { Id = 7, Name = "More Tests" };
        }
    }

    public class TestObject
    {
        [GraphQLNonNullType] public int? Id { get; set; }
        [GraphQLNonNullType] public string Name { get; set; }
    }

}

﻿using GraphQl.SchemaGenerator.Helpers;
using GraphQL.Types;

namespace GraphQl.SchemaGenerator.Wrappers
{ 
    public class KeyValuePairGraphType<TKey, TValue> : ObjectGraphType
        where TKey : GraphType
        where TValue : GraphType
    {
        public KeyValuePairGraphType()
        {
            Name = "KeyValuePair_" + TypeHelper.GetFullName(typeof(TKey)) + "_" + TypeHelper.GetFullName(typeof(TValue));

            Field<TKey>("key");
            Field<TValue>("value");
        }
    }
}

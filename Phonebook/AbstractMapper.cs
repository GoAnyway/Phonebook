﻿namespace Phonebook
{
    public abstract class AbstractMapper<TSource, TDestination>
    {
        public abstract TDestination MapTo(TSource source);
        public abstract TSource MapFrom(TDestination destination);
    }
}
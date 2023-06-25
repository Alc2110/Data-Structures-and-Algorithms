#include "IntegerSet.h"

IntegerSet::IntegerSet()
{
    _elements = new int[10];
    _size = 0;
}

void IntegerSet::add(int n)
{
    if (!contains(n))
    {
        if (_size >= _capacity)
        {
            expand_capacity();
        }
        
        _elements[_size] = n;
        _size++;
    }
}

bool IntegerSet::contains(int n) const
{
    for (int i = 0; i < _size; i++)
    {
        if (_elements[i]==n)
        {
            return true;
        }
    }
    return false;
}

int IntegerSet::get_size() const
{
    return _size;
}

IntegerSet::~IntegerSet()
{
    delete[] _elements; // deallocate dynamically-allocated array
}

void IntegerSet::expand_capacity()
{
    int new_capacity = _capacity * 2;
    int* new_elements = new int[new_capacity];

    // copy elements to the new array
    for (int i = 0; i < _size; ++i)
    {
        new_elements[i] = _elements[i];
    }

    delete[] _elements;  // deallocate the old array
    _elements = new_elements;
    _capacity = new_capacity;
}
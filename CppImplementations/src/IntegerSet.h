#ifndef INTEGERSET_H
#define INTEGERSET_H

class IntegerSet
{
    public:
        IntegerSet();
        void add(int n);
        bool contains(int n) const;
        int get_size() const;
        ~IntegerSet();

    private:
        int* _elements; // pointer to dynamically-allocated array
        int _size;      // current size of the set
        int _capacity;  // maximum capacity of the array

        void expand_capacity();
};

#endif
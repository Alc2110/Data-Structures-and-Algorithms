#ifndef INTEGERLINKEDLIST_H
#define INTEGERLINKEDLIST_H

class IntegerDoublyLinkedList
{
    struct Node
    {
        int data;
        Node* previous;
        Node* next;

        Node(int value)
        {
            data = value;
            previous = nullptr;
            next = nullptr;
        }
    };

    public:
        IntegerDoublyLinkedList();
        void push_back(int value);
        void insert(int value);
        int first();
        int last();
        int count();
        bool contains(int value);
        int maximum();
        ~IntegerDoublyLinkedList();

    private:
        Node* _first;
        Node* _last;
};

#endif
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
        class Iterator
        {
            public:
                Iterator(Node* node);
                int& operator*();
                Iterator& operator++();
                Iterator operator++(int);
                Iterator& operator--();
                Iterator operator--(int);
                bool operator==(const Iterator& other) const;
                bool operator!=(const Iterator& other) const;
                
            private:
                Node* _current_node;
        };

        IntegerDoublyLinkedList();
        void push_back(int value);
        void insert(int value);
        int first();
        int last();
        int count();
        bool contains(int value);
        int maximum();
        Iterator begin();
        Iterator end();
        ~IntegerDoublyLinkedList();

    private:
        Node* _first;
        Node* _last;
};

#endif
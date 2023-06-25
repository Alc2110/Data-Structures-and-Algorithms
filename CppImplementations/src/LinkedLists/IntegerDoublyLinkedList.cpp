#include "IntegerDoublyLinkedList.h"

IntegerDoublyLinkedList::IntegerDoublyLinkedList()
{
    _first = nullptr;
    _last = nullptr;
}

void IntegerDoublyLinkedList::push_back(int value)
{
    Node* new_node = new Node(value);
    if (!_last)
    {
        // list is currently empty
        _first = new_node;
        _last = new_node;
    }
    else
    {
        new_node->previous = _last;
        _last->next = new_node;
        _last = new_node;
    }
}

void IntegerDoublyLinkedList::insert(int value)
{
    Node* new_node = new Node(value);
    if (_first == nullptr)
    {
        // list is currently empty
        _first = new_node;
        _last = new_node;
    }
    else if (value <= _first->data)
    {
        // insert at the beginning
        new_node->next = _first;
        _first->previous = new_node;
        _first = new_node;
    }
    else if (value >= _last->data)
    {
        // insert at the end
        new_node->previous = _last;
        _last->next = new_node;
        _last = new_node;
    }
    else
    {
        // insert in the middle
        Node* current_node = _first;
        while (current_node->next != nullptr && current_node->next->data < value)
        {
            current_node = current_node->next;
        }
        new_node->previous = current_node;
        new_node->next = current_node->next;
        current_node->next->previous = new_node;
        current_node->next = new_node;
    }
}

int IntegerDoublyLinkedList::first()
{
    if (_first!=nullptr)
    {
        return _first->data;
    }
    else
    {
        return 0;
    }
}

int IntegerDoublyLinkedList::last()
{
    if (_last!=nullptr)
    {
        return _last->data;
    }
    else
    {
        return 0;
    }
}

int IntegerDoublyLinkedList::count()
{
    int count = 0;
    if (_first!=nullptr)
    {
        Node* current_node;
        current_node = _first;
        while (current_node->next!=nullptr)
        {
            current_node = current_node->next;

            count++;
        }
        count++; // include first node in count
    }

    return count;
}

bool IntegerDoublyLinkedList::contains(int value)
{
    if (_first!=nullptr)
    {
        Node* current_node;
        current_node = _first;
        while (current_node->next!=nullptr)
        {
            if (current_node->data==value)
            {
                return true;
            }

            current_node = current_node->next;
        }
    }

    return false;
}

int IntegerDoublyLinkedList::maximum()
{
    if (_first==nullptr)
    {
        return 0;
    }
    else
    {
        int max_value = _first->data;
        Node* current_node = _first->next;
        while (current_node)
        {
            if (current_node->data > max_value)
            {
                max_value = current_node->data;
            }

            current_node = current_node->next;
        }

        return max_value;
    }
}

IntegerDoublyLinkedList::Iterator IntegerDoublyLinkedList::begin()
{
    return IntegerDoublyLinkedList::Iterator(_first);
}

IntegerDoublyLinkedList::Iterator IntegerDoublyLinkedList::end()
{
    return IntegerDoublyLinkedList::Iterator(nullptr);
}

IntegerDoublyLinkedList::~IntegerDoublyLinkedList()
{
    // free memory occupied by the list
    Node* current_node = _first;
    while (current_node)
    {
        Node* next_node = current_node->next;
        delete current_node;

        current_node = next_node;
    }
}

IntegerDoublyLinkedList::Iterator::Iterator(Node* node)
{
    _current_node = node;
}

int& IntegerDoublyLinkedList::Iterator::operator*()
{
    return _current_node->data;
}

IntegerDoublyLinkedList::Iterator IntegerDoublyLinkedList::Iterator::operator++(int)
{
    Iterator temp = *this;
    ++(*this);
    return temp;
}

IntegerDoublyLinkedList::Iterator& IntegerDoublyLinkedList::Iterator::operator++()
{
    _current_node = _current_node->next;
    return *this;
}

IntegerDoublyLinkedList::Iterator& IntegerDoublyLinkedList::Iterator::operator--()
{
    _current_node = _current_node->previous;
    return *this;
}

IntegerDoublyLinkedList::Iterator IntegerDoublyLinkedList::Iterator::operator--(int)
{
    Iterator temp = *this;
    --(*this);
    return temp;
}

bool IntegerDoublyLinkedList::Iterator::operator==(const Iterator& other) const
{
    return _current_node == other._current_node;
}

bool IntegerDoublyLinkedList::Iterator::operator!=(const Iterator& other) const 
{
    return !(*this == other);
}
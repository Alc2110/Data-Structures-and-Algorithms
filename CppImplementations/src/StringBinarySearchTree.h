#include <string>

#ifndef STRINGBST_H
#define STRINGBST_H

class StringBinarySearchTree
{
    struct Node
    {
        std::string data;
        Node* left;
        Node* right;

        Node(std::string value)
        {
            data = value;

            left = nullptr;
            right = nullptr;
        }
    };

    public:
        StringBinarySearchTree();
        void insert(std::string value);
        bool exists(std::string value);
        ~StringBinarySearchTree();

    private:
        Node* _root;
        Node* insert_node(Node*& root, const std::string& value);
        bool exists_value(Node* node, const std::string& value);
        void delete_node(Node* node);
};

#endif
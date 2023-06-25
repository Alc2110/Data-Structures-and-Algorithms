#include "StringBinarySearchTree.h"

StringBinarySearchTree::StringBinarySearchTree()
{
    _root = nullptr;
}

void StringBinarySearchTree::insert(std::string value)
{
    insert_node(_root, value);
}

bool StringBinarySearchTree::exists(std::string value)
{
    return exists_value(_root, value);
}

StringBinarySearchTree::~StringBinarySearchTree()
{
    delete_node(_root);
}

StringBinarySearchTree::Node* StringBinarySearchTree::insert_node(Node*& root, const std::string& value)
{
    if (root == nullptr)
    {
        root = new Node(value);
    } 
    else if (value < root->data) 
    {
        root->left = insert_node(root->left, value);
    } 
    else if (value > root->data)
    {
        root->right = insert_node(root->right, value);
    }

    return root;
}

bool StringBinarySearchTree::exists_value(Node* node, const std::string& value)
{
    if (node == nullptr)
    {
        return false;
    } 
    else if (value == node->data)
    {
        return true;
    } 
    else if (value < node->data) 
    {
        return exists_value(node->left, value);
    } 
    else
    {
        return exists_value(node->right, value);
    }
}

void StringBinarySearchTree::delete_node(Node* node)
{
    if (node==nullptr)
    {
        return;
    }

    delete_node(node->left);
    delete_node(node->right);
    delete node;
}
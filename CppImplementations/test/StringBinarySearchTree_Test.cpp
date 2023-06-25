#include <gtest/gtest.h>
#include "../src/StringBinarySearchTree.h"

TEST(StringBinarySearchTree_Tests, insert_and_exists_test)
{
    // arrange
    StringBinarySearchTree* bst = new StringBinarySearchTree();
    bst->insert("Alex");
    bst->insert("Blake");

    // act/assert
    EXPECT_TRUE(bst->exists("Alex"));
    EXPECT_TRUE(bst->exists("Blake"));
    EXPECT_FALSE(bst->exists("John"));
}
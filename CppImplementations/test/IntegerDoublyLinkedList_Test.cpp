#include <gtest/gtest.h>
#include "../src/LinkedLists/IntegerDoublyLinkedList.h"

TEST(IntegerDoublyLinkedList_Tests, constructor_test)
{
    // arrange
    IntegerDoublyLinkedList list;
    int expected_count = 0;
    int expected_first_value = 0;
    int expected_last_value = 0;

    // act
    int actual_count = list.count();
    int actual_first_value = list.first();
    int actual_last_value = list.last();

    // assert
    EXPECT_EQ(actual_count, expected_count);
    EXPECT_EQ(actual_first_value, expected_first_value);
    EXPECT_EQ(actual_last_value, expected_last_value);
}

TEST(IntegerDoublyLinkedList_Tests, first_last_count_test)
{
    // arrange
    IntegerDoublyLinkedList list;
    list.push_back(1);
    list.push_back(2);

    // act
    int actual_first_value = list.first();
    int actual_last_value = list.last();
    int actual_count = list.count();

    // assert
    EXPECT_EQ(actual_first_value, 1);
    EXPECT_EQ(actual_last_value, 2);
    EXPECT_EQ(actual_count, 2);
}

TEST(IntegerDoublyLinkedList_Tests, contains_test_does_contain)
{
    // arrange
    IntegerDoublyLinkedList list;
    list.push_back(1);
    list.push_back(2);

    // act
    bool contains_result = list.contains(1);

    // assert
    ASSERT_TRUE(contains_result);
}

TEST(IntegerDoublyLinkedList_Tests, contains_test_does_not_contain)
{
    // arrange
    IntegerDoublyLinkedList list;
    list.push_back(1);
    list.push_back(2);

    // act
    bool contains_result = list.contains(3);

    // assert
    ASSERT_FALSE(contains_result);
}

TEST(IntegerDoublyLinkedList_Tests, maximum_test)
{
    // arrange
    IntegerDoublyLinkedList list;
    list.push_back(2);
    list.push_back(1);
    list.push_back(3);

    // act
    int actual_result = list.maximum();

    // assert
    EXPECT_EQ(actual_result, 3);
}
#include <gtest/gtest.h>
#include "../src/IntegerSet.h"

TEST(IntegerSet_Tests, add_test_originally_empty)
{
     // arrange
     IntegerSet* set = new IntegerSet();

     // act
     set->add(1);
     set->add(2);

     // assert
     EXPECT_EQ(set->get_size(), 2);
     ASSERT_TRUE(set->contains(2));
     ASSERT_FALSE(set->contains(3));
}
cmake_minimum_required(VERSION 3.14)
project(CppImplementations)

# GoogleTest requires at least C++14
set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include(FetchContent)
FetchContent_Declare(
  googletest
  URL https://github.com/google/googletest/archive/03597a01ee50ed33e9dfd640b249b4be3799d395.zip
)
# For Windows: Prevent overriding the parent project's compiler/linker settings
set(gtest_force_shared_crt ON CACHE BOOL "" FORCE)
FetchContent_MakeAvailable(googletest)

enable_testing()

include_directories(${PROJECT_SOURCE_DIR}/src)
set(SOURCES src/LinkedLists/IntegerDoublyLinkedList.cpp src/StringBinarySearchTree.cpp src/IntegerSet.cpp test/IntegerDoublyLinkedList_Test.cpp test/StringBinarySearchTree_Test.cpp test/IntegerSet_Test.cpp)

add_executable(cpp_implementations ${SOURCES})

target_link_libraries(
  cpp_implementations
  GTest::gtest_main
)

include(GoogleTest)
gtest_discover_tests(cpp_implementations)
cmake -S. -Bbuild
cmake --build build
cd build
ctest --rerun-failed --output-on-failure
cd ..
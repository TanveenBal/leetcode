#include <set>
#include <vector>

using namespace std;

bool containsDuplicate(vector<int> &nums) {
  set<int> seen;
  size_t size = nums.size();
  for (int i = 0; i < size; ++i) {
    set<int>::iterator find = seen.find(nums[i]);
    if (find != seen.end()) {
      return true;
    }
    seen.insert(nums[i]);
  }
  return false;
}

public class SolutionMerge
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = 0;
        int p2 = 0;
        int tmp;
        while (p1 < m && p2 < n)
        {
            if (nums1[p1] <= nums2[p2])
                p1++;
            else
            {
                tmp = nums1[p1];
                nums1[p1] = nums2[p2];
                nums2[p2] = tmp;
                p1++;
                int k = p2;
                /*Array.Sort(nums2);*/
                while (k + 1 < n && nums2[k] > nums2[k + 1])
                {
                    tmp = nums2[k];
                    nums2[k] = nums2[k + 1];
                    nums2[k + 1] = tmp;
                    k++;
                }
            }
        }

        for (; p2 < n; p2++) { nums1[m + p2] = nums2[p2]; }
    }
}

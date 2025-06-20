public class SolutionProductExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int len = nums.Length;
        int[] ans = new int[len];
        int prefix = 1;
        for (int i = 0; i < len; i++)
        {
            ans[i] = prefix;
            prefix *= nums[i];
        }

        int postfix = 1;
        for (int i = len - 1; i >= 0; i--)
        {
            ans[i] *= postfix;
            postfix *= nums[i];
        }

        return ans;
    }
    /*public int[] ProductExceptSelf(int[] nums)*/
    /*{*/
    /*    int zeroes = 0;*/
    /*    int zero_index = -1;*/
    /*    int totalProd = 1;*/
    /*    int len = nums.Length;*/
    /*    for (int i = 0; i < len; i++)*/
    /*    {*/
    /*        if (nums[i] == 0)*/
    /*        {*/
    /*            zeroes++;*/
    /*            if (zeroes > 1)*/
    /*                break;*/
    /*            zero_index = i;*/
    /*        }*/
    /*        else*/
    /*            totalProd *= nums[i];*/
    /*    }*/
    /**/
    /*    if (zeroes == 0)*/
    /*    {*/
    /*        for (int i = 0; i < len; i++)*/
    /*            nums[i] = totalProd / nums[i];*/
    /*    }*/
    /*    else if (zeroes == 1)*/
    /*    {*/
    /*        for (int i = 0; i < len; i++)*/
    /*            nums[i] = 0;*/
    /*        nums[zero_index] = totalProd;*/
    /*    }*/
    /*    else*/
    /*    {*/
    /*        for (int i = 0; i < len; i++)*/
    /*            nums[i] = 0;*/
    /*    }*/
    /**/
    /*    return nums;*/
    /*}*/
}

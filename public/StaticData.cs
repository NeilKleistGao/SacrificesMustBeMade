using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticData{
    public static int level = 0;
    public static bool win = false;
    public static List<string> saved_list = new List<string>(), sacrificed_list = new List<string>();
    public static int res = 0;
    public static int[] min = {1, 1, 1, 1, 2, 2, 1};
    public static bool suicide = false;
}

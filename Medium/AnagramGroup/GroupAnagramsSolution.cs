public class GroupAnagramsSolution {
    public IList<IList<string>> GroupAnagrams(string[] strs) { // O(mlogn) time, O(mn) space
        var map = new Dictionary<string, List<string>>();

        for(int i=0; i<strs.Length; i++){
            var chars = strs[i].ToCharArray();
            Array.Sort(chars);
            var key = new String(chars);

            if(!map.ContainsKey(key)){
                map.Add(key, new List<string>());
            }

            map[key].Add(strs[i]);
        }
        var result = new List<IList<string>>();

        foreach (var group in map.Values){
            result.Add(group);
        }
        return result;
    }
}
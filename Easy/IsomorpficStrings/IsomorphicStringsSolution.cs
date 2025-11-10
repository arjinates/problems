public class IsomorphicStringsSolution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length) return false;

        var sToT = new Dictionary<char, char>();
        var tToS = new Dictionary<char, char>();

        for(int i=0; i<s.Length; i++){
            char cs = s[i];
            char ct = t[i];

            if(sToT.TryGetValue(cs, out var mapped)){
                if(mapped != ct) return false;
            }
            else{
                if(tToS.TryGetValue(ct, out var back)){
                    if(back != cs) return false;
                }

                sToT[cs] = ct;
                tToS[ct] = cs;
            }
        }

        return true;
    }
}
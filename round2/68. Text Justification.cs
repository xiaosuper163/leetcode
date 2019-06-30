public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        var res = new List<string>();
        int index = 0;
        int size = words.Length;
        while (index < size) {
            int last = index + 1;
            int line_width = words[index].Length;
            while (last < size) {
                if (line_width + 1 + words[last].Length > maxWidth) break;
                line_width += 1 + words[last].Length;
                last++;
            }
            StringBuilder sb = new StringBuilder();
            int diff = last - 1 - index;
            int num_emp = maxWidth - line_width;
            sb.Append(words[index]);
            Console.WriteLine(num_emp);
            // last line or only one word in one line
            if (diff == 0 || last > size-1) {
                for (int i=index+1; i<last; i++) {
                    sb.Append(" ");
                    sb.Append(words[i]);
                }
                while (num_emp > 0) {
                    sb.Append(" ");
                    num_emp--;
                }
            } else {
                int single_slot_size = num_emp / diff;
                int remainder = num_emp % diff;
                //Console.WriteLine(single_slot_size);
                for (int i=index+1; i<last; i++) {
                    sb.Append(" ");
                    int temp = single_slot_size;
                    while (temp > 0){
                        sb.Append(" ");
                        temp--;
                    }
                    if (remainder > 0) {
                        sb.Append(" ");
                        remainder--;
                    }
                    sb.Append(words[i]);
                }
            }
            res.Add(sb.ToString());
            index = last;
        }
        return res;
    }
}
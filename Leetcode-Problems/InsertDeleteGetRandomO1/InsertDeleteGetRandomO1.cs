public class RandomizedSet {
    private Dictionary<int, int> dict;
    private List<int> list;
    private Random rand;

    public RandomizedSet() {
        dict = new Dictionary<int, int>();
        list = new List<int>();
        rand = new Random();
    }

    public bool Insert(int val) {
        if (dict.ContainsKey(val)) return false;

        dict[val] = list.Count;
        list.Add(val);
        return true;
    }

    public bool Remove(int val) {
        if (!dict.ContainsKey(val)) return false;

        int index = dict[val];
        int lastElement = list[list.Count - 1];

        // Swap current and last elements
        list[index] = lastElement;
        dict[lastElement] = index;

        // Remove last
        list.RemoveAt(list.Count - 1);
        dict.Remove(val);

        return true;
    }

    public int GetRandom() {
        int index = rand.Next(list.Count);
        return list[index];
    }
}

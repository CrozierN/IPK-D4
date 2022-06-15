namespace Problems;

public class GridChallenge
{
    public string challenge(List<string> grid)
    {
        bool check = false;
        for(int i = 0; i < grid.Count; i++)
        {
            var characters = new string(grid[i].OrderBy(x => x).ToArray());
            check = IsAlphabetic(characters!);
            grid.RemoveAt(i);
            grid.Insert(i, characters!);
        }

        var grid2 = new List<string>();
        for(int i = 0; i < grid.Count; i++)
        {
            string col = "";
            for (int j = 0; j < grid[i].Length; j++)
                col += grid[j][i];
            grid2.Add(col);
        }

        for(int i = 0; i < grid.Count; i++)
        {
            check = IsAlphabetic(grid[i]);
        }


        return (check)? "YES":"NO";
    }

    private static bool IsAlphabetic(string characters)
    {
        var temp = '\u0000';
        foreach(char c in characters)
        {
            if(c < temp) return false;
            temp = c;
        }

        return true;
    }
}

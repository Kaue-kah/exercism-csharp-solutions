using System.Net;

public class GradeSchool
{

    private Dictionary<int, List<string>> _grades = new(); 

    public bool Add(string student, int grade)
    {
        if (_grades.Values.Any(lista => lista.Contains(student)))
        {
            return false;
        }
        
        if (!_grades.ContainsKey(grade))
        {
            _grades[grade] = new List<string>();  
        } 
       
        _grades[grade].Add(student);
        return true;
    }

    public IEnumerable<string> Roster()
    {
        List<string> list = new List<string>();

        foreach (var students in _grades.OrderBy(x => x.Key))
        {
            foreach (var student in students.Value.OrderBy(x => x))
            {
                list.Add(student);
            }
        }

        return list;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (_grades.ContainsKey(grade))
        {
            return _grades[grade].OrderBy(x => x);
        }

        return Enumerable.Empty<string>();
    }
}
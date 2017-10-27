using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptables/Stats/StatsObject")]
public class Stats : ScriptableObject
{
    [SerializeField]
    public List<Stat> _stats;

    private Dictionary<string, Stat> _statsDictionary;

    public List<string> _statNames;

    public void OnEnable()
    {
        _statNames = new List<string>();
        _statsDictionary = new Dictionary<string, Stat>();
        foreach (var s in _stats)
        {
            var copy = Instantiate(s) as Stat;
            copy.Name = s.Name;
            copy.Value = s.Value;
            _statsDictionary.Add(copy.Name, copy);
            _statNames.Add(copy.Name);
        }
    }

    public Stat this[string key]
    {
        get { return _statsDictionary[key]; }
        set { _statsDictionary[key] = value; }
    }
}

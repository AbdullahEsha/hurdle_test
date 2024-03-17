using System;
using System.Collections.Generic;

namespace Iteration1;
public class IdentifiableObject
{
    // Private field to store the identifiers
    private HashSet<string> _identifiers;

    // Constructor to initialize the identifiers
    public IdentifiableObject(string[] idents)
    {
        _identifiers = new HashSet<string>(idents.Select(i => i.ToLower()));
    }

    // Method to check if the object has a specific identifier
    public bool AreYou(string id)
    {
        return _identifiers.Contains(id.ToLower());
    }

    // Property to get the first identifier
    public string FirstId => _identifiers.Count > 0 ? _identifiers.First() : string.Empty;

    // Method to add a new identifier
    public void AddIdentifier(string id)
    {
        string lowerId = id.ToLower();
        if (!_identifiers.Contains(lowerId))
        {
            _identifiers.Add(lowerId);
        }
    }

    // Method to expose the identifiers for demonstration purposes
    public string[] GetIdentifiers()
    {
        return _identifiers.ToArray();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial_17dec2022_2;

public enum PetType
{
    Dog,
    Cat,
    Fish
}
internal class Pet
{
    public Pet(int id, string name, PetType type, float weight)
    {
        Id = id;
        Name = name;
        Type = type;
        Weight = weight;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public PetType Type { get; set; }
    public float Weight { get; set; }
}

using System.Linq;
using UnityEngine;

public class AnimalQuery : MonoBehaviour
{
    public Animal[] animals;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //var upperHP = animals.Where(animal => animal.maxHp > 50).ToList().ForEach();

        //var upperHP = animals.Where(animal => animal.maxHp > 50);
        //foreach (var animal in upperHP) { 
        //    print(animal.name + "의 체력은 " + animal.maxHp);
        //}
        var orderByAge = animals.OrderBy(animal => animal.age).Select(animal => animal.age);
        foreach (var animal in orderByAge)
        {
            //print(animal.name + "의 체력은 " + animal.maxHp);
            print(animal);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < animals.Length; i++) { 
        //    var animal = animals[i];
        //    if (animal.maxHp > 50) { 
        //        print(animal.name + " 의 체력은" + animal.maxHp);
        //    }
        //}
    }
}

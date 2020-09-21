using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
namespace lab3
{
    class Program
    {
        class Zoo
        {
            private string name { get; set; }
            private Cell cell;
            private ArrayList newCell = new ArrayList();

            public Zoo(String Name)
            {
                name = Name;
                
            }
            public void addCell(Cell cell)
            {
                newCell.Add(cell);
            }

            public void removeCell(Cell cell)
            {
                newCell.Remove(cell);
            }

            public Cell getCell()
            {
                return cell;
            }

            /* public void setCell(Cell cell)
             {
                 this.cell = cell;
             }
             public Cell getCell()
             {
                 return cell;
             }
             public string getName()
             {
                 return name;
             }

             public void setName(string newName)
             {
                 name = newName;
             }*/




        }
        
        class Cell
        {
            private int number{ get; set;}
            private int size{get; set;}
            private int maxQuantityAnimal{get; set;} // Максимальное кол-во животных
            private int currentQuantityAnimal{ get; set; } // Текущее кол-во животных
            //private Zoo zoo;
            private Animal animal;

            public Cell (int Number, int Size, int MaxQuantityAnimal, int CurrentQuantityAnimal)
            {
                number = Number;
                size = Size;
                maxQuantityAnimal = MaxQuantityAnimal;
                currentQuantityAnimal = CurrentQuantityAnimal;
            }
            private ArrayList newAnimal = new ArrayList();
            public void addAimal(Animal animal)
            {
                newAnimal.Add(animal);
            }
            public void removeAnimal(Animal animal)
            {
                newAnimal.Remove(animal);
            }

            public Animal getAnimal()
            {
                return animal;
            }
            //
           /* public Zoo getZoo()
            {
                return zoo;
            }

            public void setZoo(Zoo zoo)
            {
                this.zoo = zoo;
            }
            public int getNumber()
            {
                return number;
            }
            public void setNumber(int newNumber)
            {
                number = newNumber;
            }

            public int getSize()
            {
                return size;
            }
            public void setSize(int newSize)
            {
                size = newSize;
            }

            public int getMaxQuantityAnimal()
            {
                return maxQuantityAnimal;
            }

            public void setMaxQuantityAnimal(int newMaxQuantityAnimal)
            {
                maxQuantityAnimal = newMaxQuantityAnimal;
            }

            public int getCurrentQuantityAnimal()
            {
                return currentQuantityAnimal;
            }

            public void setCurrentQuantityAnimal(int newCurrentQuantityAnimal)
            {
                currentQuantityAnimal = newCurrentQuantityAnimal;
            }*/

        }

        class Animal
        {
            private string name;
            private bool predator;
            private Cell cell;

            public Animal (string Name, bool Predator)
            {
                name = Name;
                predator = Predator;
            }
            //
            /*public Cell getCell()
            {
                return cell;
            }

            public void setCell(Cell cell)
            {
                this.cell = cell;
            }

            public string getName()
            {
                return name;
            }

            public void setName(string newNme)
            {
                name = newNme;
            }

            public bool getPredator()
            {
                return predator;
            }

            public void setPredator(bool newPredator)
            {
                predator = newPredator;
            }*/
            
        }


        static void Main(string[] args)
        {
            
            Zoo newZoo = new Zoo("NSK");
            Cell oneCell = new Cell(5, 60, 10, 1);
            Cell twoCell = new Cell(10, 80, 20, 2);
            Animal oneAnimal = new Animal("Тигр",true);
            Animal twoAnimal = new Animal("Лев", true);
            Animal threeAnimal = new Animal("Пантера", true);
            newZoo.addCell(oneCell);
            newZoo.addCell(twoCell);
            oneCell.addAimal(oneAnimal);
            oneCell.addAimal(twoAnimal);
            twoCell.addAimal(threeAnimal);

            Console.WriteLine(oneCell.getAnimal()); //??
           

            
            
            


        }
    }

    }

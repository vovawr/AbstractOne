using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public class Skill
    {
        private static Skill instance;

        public string Agiliti { get; private set; } 
        public string Reaction { get; private set; }        
        public string Speed { get; private set; }   

        protected Skill(string agiliti, string reaction, string speed) 
        { 
            this.Agiliti = agiliti;
            this.Reaction = reaction;   
            this.Speed = speed; 
        }   
        public static Skill getInstance(string agiliti, string reaction, string speed)
        {
            if (instance == null) 
            { 
                instance = new Skill(agiliti, reaction, speed); 
            }
            return instance;    
        } 
    
    }
    class SkullAll
    {
        public Skill Skill { get; set; }    
        public void CarDriv(string skAgiliti, string skReaction,string skSpeed)
        {
            Skill = Skill.getInstance(skReaction, skSpeed, skAgiliti);
        }
    }
    abstract class Car : SkullAll
    {
        public abstract void CarDriv();
    }
    abstract class Player : SkullAll
    {
        public abstract void PlayerDriv();
    }
    abstract class Create
    {
        public abstract Car CreateCar();    
        public abstract Player CreatePlayer();      
    }
    class Factory : Create
    {
        public override Car CreateCar()
        {
            return new NewCar1(); 
        }
        public override Player CreatePlayer()
        {
            return new NewPlayer();
        }
    }
    class NewCar1 : Car
    {
        public override void CarDriv()
        {
            Console.WriteLine();
        }    
    }
    class NewPlayer : Player
    {
        public override void PlayerDriv()
        {
            Console.WriteLine();
        }
    }
    class CarPlayer
    {
        private Car car;
        private Player player;  
        private CarPlayer(Create create) 
        { 
            car = create.CreateCar();   
            player = create.CreatePlayer();    
        }
        public void RunCar()
        {
            car.CarDriv();
        }
        public void RunPlayer()
        {
            player.PlayerDriv();    
        }  
    }
}
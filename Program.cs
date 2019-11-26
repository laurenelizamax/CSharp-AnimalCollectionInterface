using System;

namespace AnimalCollectionInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant1 = new Ant()
            {
                MaxWalkingSpeed = 10
            };
            BettaFish betta1 = new BettaFish();
            CopperheadSnake copper1 = new CopperheadSnake();
            Earthworm worm1 = new Earthworm();
            Finch finch1 = new Finch();
            Gerbil gerbil1 = new Gerbil();
            Mouse mouse1 = new Mouse();
            Parakeet bird1 = new Parakeet();
            Terrapin turtle1 = new Terrapin();
            TimberRattleSnake snake1 = new TimberRattleSnake();

            FlyContainer flyContainer = new FlyContainer();
            flyContainer.flyingAnimals.Add(finch1);
            flyContainer.flyingAnimals.Add(bird1);

            DigContainer digContainer = new DigContainer();
            digContainer.diggingAnimals.Add(worm1);

            SwimContainer swimContainer = new SwimContainer();
            swimContainer.swimmingAnimals.Add(turtle1);
            swimContainer.swimmingAnimals.Add(betta1);

            WalkContainer walkContainer = new WalkContainer();
            walkContainer.walkingAnimals.Add(gerbil1);
            walkContainer.walkingAnimals.Add(mouse1);
            walkContainer.walkingAnimals.Add(snake1);
            walkContainer.walkingAnimals.Add(copper1);



        }
    }
}
